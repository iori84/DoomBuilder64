
#region ================== Copyright (c) 2007 Pascal vd Heiden

/*
 * Copyright (c) 2007 Pascal vd Heiden, www.codeimp.com
 * This program is released under GNU General Public License
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 */

#endregion

#region ================== Namespaces

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using CodeImp.DoomBuilder.Config;
using CodeImp.DoomBuilder.Geometry;
using CodeImp.DoomBuilder.Rendering;
using SlimDX.Direct3D9;
using System.Drawing;
using CodeImp.DoomBuilder.IO;

#endregion

namespace CodeImp.DoomBuilder.Map
{
	public sealed class Linedef : SelectableElement
	{
		#region ================== Constants

		public const float SIDE_POINT_DISTANCE = 0.01f;
		public const int NUM_ARGS = 5;
		
		#endregion

		#region ================== Variables

		// Map
		private MapSet map;

		// List items
		private LinkedListNode<Linedef> startvertexlistitem;
		private LinkedListNode<Linedef> endvertexlistitem;
		private LinkedListNode<Linedef> selecteditem;
		
		// Vertices
		private Vertex start;
		private Vertex end;
		
		// Sidedefs
		private Sidedef front;
		private Sidedef back;

		// Cache
		private bool updateneeded;
		private float lengthsq;
		private float lengthsqinv;
		private float length;
		private float lengthinv;
		private float angle;
		private RectangleF rect;
		private bool blocksoundflag;
		private bool impassableflag;
        private bool invisibleflag; //villsa
        private bool secretflag;    // villsa
        private bool monsterblockflag;  // villsa
        private bool tagonlyflag;   // villsa
		
		// Properties
		private Dictionary<string, bool> flags;
		private int action;
		private int activate;
        private int switchmask; // villsa 9/12/11
		private int tag;
		private int[] args;
		private bool frontinterior;		// for drawing only

		// Clone
		private int serializedindex;
		
		#endregion

		#region ================== Properties

		public MapSet Map { get { return map; } }
		public Vertex Start { get { return start; } }
		public Vertex End { get { return end; } }
		public Sidedef Front { get { return front; } }
		public Sidedef Back { get { return back; } }
		public Line2D Line { get { return new Line2D(start.Position, end.Position); } }
		internal Dictionary<string, bool> Flags { get { return flags; } }
		public int Action { get { return action; } set { BeforePropsChange(); action = value; } }
		public int Activate { get { return activate; } set { BeforePropsChange(); activate = value; } }
        public int SwitchMask { get { return switchmask; } set { BeforePropsChange(); switchmask = value; } }
		public int Tag { get { return tag; } set { BeforePropsChange(); tag = value; if((tag < General.Map.FormatInterface.MinTag) || (tag > General.Map.FormatInterface.MaxTag)) throw new ArgumentOutOfRangeException("Tag", "Invalid tag number"); } }
		public float LengthSq { get { return lengthsq; } }
		public float Length { get { return length; } }
		public float LengthInv { get { return lengthinv; } }
		public float Angle { get { return angle; } }
		public int AngleDeg { get { return (int)(angle * Angle2D.PIDEG); } }
		public RectangleF Rect { get { return rect; } }
		public int[] Args { get { return args; } }
		internal int SerializedIndex { get { return serializedindex; } set { serializedindex = value; } }
		internal bool FrontInterior { get { return frontinterior; } set { frontinterior = value; } }
		internal bool ImpassableFlag { get { return impassableflag; } }
		internal bool BlockSoundFlag { get { return blocksoundflag; } }
        internal bool InvisibleFlag { get { return invisibleflag; } }   // villsa
        internal bool MonsterBlockFlag { get { return monsterblockflag; } }   // villsa
        internal bool SecretFlag { get { return secretflag; } }   // villsa
        internal bool TagonlyFlag { get { return tagonlyflag; } set { tagonlyflag = value; } }   // villsa
		
		#endregion

		#region ================== Constructor / Disposer

		// Constructor
		internal Linedef(MapSet map, int listindex, Vertex start, Vertex end)
		{
			// Initialize
			this.map = map;
			this.listindex = listindex;
			this.updateneeded = true;
			this.args = new int[NUM_ARGS];
			this.flags = new Dictionary<string, bool>();
			
			// Attach to vertices
			this.start = start;
			this.startvertexlistitem = start.AttachLinedefP(this);
			this.end = end;
			this.endvertexlistitem = end.AttachLinedefP(this);
			
			if(map == General.Map.Map)
				General.Map.UndoRedo.RecAddLinedef(this);
			
			// We have no destructor
			GC.SuppressFinalize(this);
		}
		
		// Disposer
		public override void Dispose()
		{
			// Not already disposed?
			if(!isdisposed)
			{
				// Already set isdisposed so that changes can be prohibited
				isdisposed = true;

				// Dispose sidedefs
				if((front != null) && map.AutoRemove) front.Dispose(); else AttachFrontP(null);
				if((back != null) && map.AutoRemove) back.Dispose(); else AttachBackP(null);
				
				if(map == General.Map.Map)
					General.Map.UndoRedo.RecRemLinedef(this);

				// Remove from main list
				map.RemoveLinedef(listindex);
				
				// Detach from vertices
				if(startvertexlistitem != null) start.DetachLinedefP(startvertexlistitem);
				startvertexlistitem = null;
				start = null;
				if(endvertexlistitem != null) end.DetachLinedefP(endvertexlistitem);
				endvertexlistitem = null;
				end = null;
				
				// Clean up
				start = null;
				end = null;
				front = null;
				back = null;
				map = null;

				// Clean up base
				base.Dispose();
			}
		}

		#endregion

		#region ================== Management
		
		// Call this before changing properties
		protected override void BeforePropsChange()
		{
			if(map == General.Map.Map)
				General.Map.UndoRedo.RecPrpLinedef(this);
		}
		
		// Serialize / deserialize (passive: doesn't record)
		internal void ReadWrite(IReadWriteStream s)
		{
			if(!s.IsWriting)
			{
				BeforePropsChange();
				updateneeded = true;
			}
			
			base.ReadWrite(s);
			
			if(s.IsWriting)
			{
				s.wInt(flags.Count);
				
				foreach(KeyValuePair<string, bool> f in flags)
				{
					s.wString(f.Key);
					s.wBool(f.Value);
				}
			}
			else
			{
				int c; s.rInt(out c);

				flags = new Dictionary<string, bool>(c);
				for(int i = 0; i < c; i++)
				{
					string t; s.rString(out t);
					bool b; s.rBool(out b);
					flags.Add(t, b);
				}
			}

			s.rwInt(ref action);
			s.rwInt(ref activate);
			s.rwInt(ref tag);
			for(int i = 0; i < NUM_ARGS; i++) s.rwInt(ref args[i]);
		}

		// This sets new start vertex
		public void SetStartVertex(Vertex v)
		{
			if(map == General.Map.Map)
				General.Map.UndoRedo.RecRefLinedefStart(this);
			
			// Change start
			if(startvertexlistitem != null) start.DetachLinedefP(startvertexlistitem);
			startvertexlistitem = null;
			start = v;
			if(start != null) startvertexlistitem = start.AttachLinedefP(this);
			this.updateneeded = true;
		}

		// This sets new end vertex
		public void SetEndVertex(Vertex v)
		{
			if(map == General.Map.Map)
				General.Map.UndoRedo.RecRefLinedefEnd(this);

			// Change end
			if(endvertexlistitem != null) end.DetachLinedefP(endvertexlistitem);
			endvertexlistitem = null;
			end = v;
			if(end != null) endvertexlistitem = end.AttachLinedefP(this);
			this.updateneeded = true;
		}

		// This detaches a vertex
		internal void DetachVertexP(Vertex v)
		{
			if(v == start)
			{
				if(startvertexlistitem != null) start.DetachLinedefP(startvertexlistitem);
				startvertexlistitem = null;
				start = null;
			}
			else if(v == end)
			{
				if(endvertexlistitem != null) end.DetachLinedefP(endvertexlistitem);
				endvertexlistitem = null;
				end = null;
			}
			else 
				throw new Exception("Specified Vertex is not attached to this Linedef.");
		}
		
		// This copies all properties to another line
		new public void CopyPropertiesTo(Linedef l)
		{
			l.BeforePropsChange();
			
			// Copy properties
			l.action = action;
			l.args = (int[])args.Clone();
			l.flags = new Dictionary<string, bool>(flags);
			l.tag = tag;
			l.updateneeded = true;
			l.activate = activate;
			l.impassableflag = impassableflag;
			l.blocksoundflag = blocksoundflag;
            l.invisibleflag = invisibleflag;    // villsa
            l.switchmask = switchmask;
            l.secretflag = secretflag;
            l.monsterblockflag = monsterblockflag;
            l.tagonlyflag = tagonlyflag;
			base.CopyPropertiesTo(l);
		}
		
		// This attaches a sidedef on the front
		internal void AttachFront(Sidedef s)
		{
			if(map == General.Map.Map)
				General.Map.UndoRedo.RecRefLinedefFront(this);
			
			// Attach and recalculate
			AttachFrontP(s);
		}
		
		// Passive version, does not record the change
		internal void AttachFrontP(Sidedef s)
		{
			// Attach and recalculate
			front = s;
			if(front != null) front.SetLinedefP(this);
			updateneeded = true;
		}

		// This attaches a sidedef on the back
		internal void AttachBack(Sidedef s)
		{
			if(map == General.Map.Map)
				General.Map.UndoRedo.RecRefLinedefBack(this);

			// Attach and recalculate
			AttachBackP(s);
		}
		
		// Passive version, does not record the change
		internal void AttachBackP(Sidedef s)
		{
			// Attach and recalculate
			back = s;
			if(back != null) back.SetLinedefP(this);
			updateneeded = true;
		}

		// This detaches a sidedef from the front
		internal void DetachSidedefP(Sidedef s)
		{
			// Sidedef is on the front?
			if(front == s)
			{
				// Remove sidedef reference
				if(front != null) front.SetLinedefP(null);
				front = null;
				updateneeded = true;
			}
			// Sidedef is on the back?
			else if(back == s)
			{
				// Remove sidedef reference
				if(back != null) back.SetLinedefP(null);
				back = null;
				updateneeded = true;
			}
			//else throw new Exception("Specified Sidedef is not attached to this Linedef.");
		}
		
		// This updates the line when changes have been made
		public void UpdateCache()
		{
            this.TagonlyFlag = ((this.Tag != 0) && ((this.Action & 511) == 0));

			// Update if needed
			if(updateneeded)
			{
				// Delta vector
				Vector2D delta = end.Position - start.Position;

				// Recalculate values
				lengthsq = delta.GetLengthSq();
				length = (float)Math.Sqrt(lengthsq);
				if(length > 0f) lengthinv = 1f / length; else lengthinv = 1f / 0.0000000001f;
				if(lengthsq > 0f) lengthsqinv = 1f / lengthsq; else lengthsqinv = 1f / 0.0000000001f;
				angle = delta.GetAngle();
				float l = Math.Min(start.Position.x, end.Position.x);
				float t = Math.Min(start.Position.y, end.Position.y);
				float r = Math.Max(start.Position.x, end.Position.x);
				float b = Math.Max(start.Position.y, end.Position.y);
				rect = new RectangleF(l, t, r - l, b - t);
				
				// Cached flags
				blocksoundflag = IsFlagSet(General.Map.Config.SoundLinedefFlag);
				impassableflag = IsFlagSet(General.Map.Config.ImpassableFlag);
                invisibleflag = IsFlagSet(General.Map.Config.InvisibleFlag);   // villsa
                monsterblockflag = IsFlagSet(General.Map.Config.MonsterblockFlag);
                secretflag = IsFlagSet(General.Map.Config.SecretFlag);
				
				// Updated
				updateneeded = false;
			}
		}

		// This flags the line needs an update because it moved
		public void NeedUpdate()
		{
			// Update this line
			updateneeded = true;

			// Update sectors as well
			if(front != null) front.Sector.UpdateNeeded = true;
			if(back != null) back.Sector.UpdateNeeded = true;
		}
		
		// This translates the flags and activations into UDMF fields
		internal void TranslateToUDMF()
		{
			// First make a single integer with all bits from activation and flags
			int bits = activate;
			int flagbit = 0;
			foreach(KeyValuePair<string, bool> f in flags)
				if(int.TryParse(f.Key, out flagbit) && f.Value) bits |= flagbit;

            bits |= switchmask;
			
			// Now make the new flags
			flags.Clear();
			foreach(FlagTranslation f in General.Map.Config.LinedefFlagsTranslation)
			{
				// Flag found in bits?
				if((bits & f.Flag) == f.Flag)
				{
					// Add fields and remove bits
					bits &= ~f.Flag;
					for(int i = 0; i < f.Fields.Count; i++)
						flags[f.Fields[i]] = f.FieldValues[i];
				}
				else
				{
					// Add fields with inverted value
					for(int i = 0; i < f.Fields.Count; i++)
						flags[f.Fields[i]] = !f.FieldValues[i];
				}
			}
		}
		
		// This translates UDMF fields back into the normal flags and activations
		internal void TranslateFromUDMF()
		{
			// Make copy of the flags
			Dictionary<string, bool> oldfields = new Dictionary<string, bool>(flags);

			// Make the flags
			flags.Clear();
			foreach(KeyValuePair<string, string> f in General.Map.Config.LinedefFlags)
			{
				// Flag must be numeric
				int flagbit = 0;
				if(int.TryParse(f.Key, out flagbit))
				{
					foreach(FlagTranslation ft in General.Map.Config.LinedefFlagsTranslation)
					{
						if(ft.Flag == flagbit)
						{
							// Only set this flag when the fields match
							bool fieldsmatch = true;
							for(int i = 0; i < ft.Fields.Count; i++)
							{
								if(!oldfields.ContainsKey(ft.Fields[i]) || (oldfields[ft.Fields[i]] != ft.FieldValues[i]))
								{
									fieldsmatch = false;
									break;
								}
							}
							
							// Field match? Then add the flag.
							if(fieldsmatch)
							{
								flags.Add(f.Key, true);
								break;
							}
						}
					}
				}
			}
			
			// Make the activation
			foreach(LinedefActivateInfo a in General.Map.Config.LinedefActivates)
			{
				bool foundactivation = false;
				foreach(FlagTranslation ft in General.Map.Config.LinedefFlagsTranslation)
				{
					if(ft.Flag == a.Index)
					{
						// Only set this activation when the fields match
						bool fieldsmatch = true;
						for(int i = 0; i < ft.Fields.Count; i++)
						{
							if(!oldfields.ContainsKey(ft.Fields[i]) || (oldfields[ft.Fields[i]] != ft.FieldValues[i]))
							{
								fieldsmatch = false;
								break;
							}
						}

						// Field match? Then add the flag.
						if(fieldsmatch)
						{
							activate = a.Index;
							foundactivation = true;
							break;
						}
					}
				}
				if(foundactivation) break;
			}
		}

		// Selected
		protected override void DoSelect()
		{
			base.DoSelect();
			selecteditem = map.SelectedLinedefs.AddLast(this);
		}

		// Deselect
		protected override void DoUnselect()
		{
			base.DoUnselect();
			if(selecteditem.List != null) selecteditem.List.Remove(selecteditem);
			selecteditem = null;
		}
		
		#endregion
		
		#region ================== Methods

		// This checks and returns a flag without creating it
		public bool IsFlagSet(string flagname)
		{
			if(flags.ContainsKey(flagname))
				return flags[flagname];
			else
				return false;
		}

		// This sets a flag
		public void SetFlag(string flagname, bool value)
		{
			if(!flags.ContainsKey(flagname) || (IsFlagSet(flagname) != value))
			{
				BeforePropsChange();
				
				flags[flagname] = value;

				// Cached flags
				if(flagname == General.Map.Config.SoundLinedefFlag) blocksoundflag = value;
				if(flagname == General.Map.Config.ImpassableFlag) impassableflag = value;
                if (flagname == General.Map.Config.InvisibleFlag) invisibleflag = value;   // villsa
                if (flagname == General.Map.Config.MonsterblockFlag) monsterblockflag = value;   // villsa
                if (flagname == General.Map.Config.SecretFlag) secretflag = value;   // villsa
			}
		}

		// This returns a copy of the flags dictionary
		public Dictionary<string, bool> GetFlags()
		{
			return new Dictionary<string, bool>(flags);
		}
		
		// This clears all flags
		public void ClearFlags()
		{
			BeforePropsChange();
			flags.Clear();
			blocksoundflag = false;
			impassableflag = false;
            invisibleflag = false;  // villsa
            monsterblockflag = false;
            secretflag = false;
		}
		
		// This flips the linedef's vertex attachments
		public void FlipVertices()
		{
			// make sure the start/end vertices are not automatically
			// deleted if they do not belong to any other line
			General.Map.Map.AutoRemove = false;

			// Flip vertices
			Vertex oldstart = start;
			Vertex oldend = end;
			SetStartVertex(oldend);
			SetEndVertex(oldstart);

			General.Map.Map.AutoRemove = true;
			
			// For drawing, the interior now lies on the other side
			frontinterior = !frontinterior;

			// Update required (angle changed)
			NeedUpdate();
			General.Map.IsChanged = true;
		}

		// This flips the sidedefs
		public void FlipSidedefs()
		{
			// Flip sidedefs
			Sidedef oldfront = front;
			Sidedef oldback = back;
			AttachFront(oldback);
			AttachBack(oldfront);
			
			General.Map.IsChanged = true;
		}
		
		// This returns a point for testing on one side
		public Vector2D GetSidePoint(bool front)
		{
			Vector2D n = new Vector2D();
			n.x = (end.Position.x - start.Position.x) * lengthinv * SIDE_POINT_DISTANCE;
			n.y = (end.Position.y - start.Position.y) * lengthinv * SIDE_POINT_DISTANCE;

			if(front)
			{
				n.x = -n.x;
				n.y = -n.y;
			}

			Vector2D p = new Vector2D();
			p.x = start.Position.x + (end.Position.x - start.Position.x) * 0.5f - n.y;
			p.y = start.Position.y + (end.Position.y - start.Position.y) * 0.5f + n.x;

			return p;
		}

		// This returns a point in the middle of the line
		public Vector2D GetCenterPoint()
		{
			return start.Position + (end.Position - start.Position) * 0.5f;
		}
		
		// This applies single/double sided flags
		public void ApplySidedFlags()
		{
			// Doublesided?
			if((front != null) && (back != null))
			{
				// Apply or remove flags for doublesided line
				SetFlag(General.Map.Config.SingleSidedFlag, false);
				SetFlag(General.Map.Config.DoubleSidedFlag, true);
			}
			else
			{
				// Apply or remove flags for singlesided line
				SetFlag(General.Map.Config.SingleSidedFlag, true);
				SetFlag(General.Map.Config.DoubleSidedFlag, false);
			}
			
			General.Map.IsChanged = true;
		}

		// This returns all points at which the line intersects with the grid
		public List<Vector2D> GetGridIntersections()
		{
			List<Vector2D> coords = new List<Vector2D>();
			Vector2D v = new Vector2D();
			float gx, gy, minx, maxx, miny, maxy;
			bool reversex, reversey;
			
			if(start.Position.x > end.Position.x)
			{
				minx = end.Position.x;
				maxx = start.Position.x;
				reversex = true;
			}
			else
			{
				minx = start.Position.x;
				maxx = end.Position.x;
				reversex = false;
			}

			if(start.Position.y > end.Position.y)
			{
				miny = end.Position.y;
				maxy = start.Position.y;
				reversey = true;
			}
			else
			{
				miny = start.Position.y;
				maxy = end.Position.y;
				reversey = false;
			}

			// Go for all vertical grid lines in between line start and end
			gx = General.Map.Grid.GetHigher(minx);
			if(gx < maxx)
			{
				for(; gx < maxx; gx += General.Map.Grid.GridSizeF)
				{
					// Add intersection point at this x coordinate
					float u = (gx - minx) / (maxx - minx);
					if(reversex) u = 1.0f - u;
					v.x = gx;
					v.y = start.Position.y + (end.Position.y - start.Position.y) * u;
					coords.Add(v);
				}
			}
			
			// Go for all horizontal grid lines in between line start and end
			gy = General.Map.Grid.GetHigher(miny);
			if(gy < maxy)
			{
				for(; gy < maxy; gy += General.Map.Grid.GridSizeF)
				{
					// Add intersection point at this y coordinate
					float u = (gy - miny) / (maxy - miny);
					if(reversey) u = 1.0f - u;
					v.x = start.Position.x + (end.Position.x - start.Position.x) * u;
					v.y = gy;
					coords.Add(v);
				}
			}
			
			// Profit
			return coords;
		}
		
		// This returns the closest coordinates ON the line
		public Vector2D NearestOnLine(Vector2D pos)
		{
			float u = Line2D.GetNearestOnLine(start.Position, end.Position, pos);
			if(u < 0f) u = 0f; else if(u > 1f) u = 1f;
			return Line2D.GetCoordinatesAt(start.Position, end.Position, u);
		}

		// This returns the shortest distance from given coordinates to line
		public float SafeDistanceToSq(Vector2D p, bool bounded)
		{
			Vector2D v1 = start.Position;
			Vector2D v2 = end.Position;

			// Calculate intersection offset
			float u = ((p.x - v1.x) * (v2.x - v1.x) + (p.y - v1.y) * (v2.y - v1.y)) * lengthsqinv;

			// Limit intersection offset to the line
			if(bounded) if(u < lengthinv) u = lengthinv; else if(u > (1f - lengthinv)) u = 1f - lengthinv;

			// Calculate intersection point
			Vector2D i = v1 + u * (v2 - v1);

			// Return distance between intersection and point
			// which is the shortest distance to the line
			float ldx = p.x - i.x;
			float ldy = p.y - i.y;
			return ldx * ldx + ldy * ldy;
		}

		// This returns the shortest distance from given coordinates to line
		public float SafeDistanceTo(Vector2D p, bool bounded)
		{
			return (float)Math.Sqrt(SafeDistanceToSq(p, bounded));
		}

		// This returns the shortest distance from given coordinates to line
		public float DistanceToSq(Vector2D p, bool bounded)
		{
			Vector2D v1 = start.Position;
			Vector2D v2 = end.Position;
			
			// Calculate intersection offset
			float u = ((p.x - v1.x) * (v2.x - v1.x) + (p.y - v1.y) * (v2.y - v1.y)) * lengthsqinv;

			// Limit intersection offset to the line
			if(bounded) if(u < 0f) u = 0f; else if(u > 1f) u = 1f;
			
			// Calculate intersection point
			Vector2D i = v1 + u * (v2 - v1);

			// Return distance between intersection and point
			// which is the shortest distance to the line
			float ldx = p.x - i.x;
			float ldy = p.y - i.y;
			return ldx * ldx + ldy * ldy;
		}

		// This returns the shortest distance from given coordinates to line
		public float DistanceTo(Vector2D p, bool bounded)
		{
			return (float)Math.Sqrt(DistanceToSq(p, bounded));
		}

		// This tests on which side of the line the given coordinates are
		// returns < 0 for front (right) side, > 0 for back (left) side and 0 if on the line
		public float SideOfLine(Vector2D p)
		{
			Vector2D v1 = start.Position;
			Vector2D v2 = end.Position;
			
			// Calculate and return side information
			return (p.y - v1.y) * (v2.x - v1.x) - (p.x - v1.x) * (v2.y - v1.y);
		}

		// This splits this line by vertex v
		// Returns the new line resulting from the split, or null when it failed
		public Linedef Split(Vertex v)
		{
			Linedef nl;
			Sidedef nsd;

			// Copy linedef and change vertices
			nl = map.CreateLinedef(v, end);
			if(nl == null) return null;
			CopyPropertiesTo(nl);
			SetEndVertex(v);
			nl.Selected = this.Selected;
			nl.marked = this.marked;
			
			// Copy front sidedef if exists
			if(front != null)
			{
				nsd = map.CreateSidedef(nl, true, front.Sector);
				if(nsd == null) return null;
				front.CopyPropertiesTo(nsd);
				nsd.Marked = front.Marked;

				// Make texture offset adjustments
				nsd.OffsetX += (int)Vector2D.Distance(this.start.Position, this.end.Position);
			}

			// Copy back sidedef if exists
			if(back != null)
			{
				nsd = map.CreateSidedef(nl, false, back.Sector);
				if(nsd == null) return null;
				back.CopyPropertiesTo(nsd);
				nsd.Marked = back.Marked;
				
				// Make texture offset adjustments
				back.OffsetX += (int)Vector2D.Distance(nl.start.Position, nl.end.Position);
			}

			// Return result
			General.Map.IsChanged = true;
			return nl;
		}
		
		// This joins the line with another line
		// This line will be disposed
		// Returns false when the operation could not be completed
		public bool Join(Linedef other)
		{
			Sector l1fs, l1bs, l2fs, l2bs;
			bool l1was2s, l2was2s;
			
			// Check which lines were 2 sided
			l1was2s = ((other.Front != null) && (other.Back != null));
			l2was2s = ((this.Front != null) && (this.Back != null));
			
			// Get sector references
			if(other.front != null) l1fs = other.front.Sector; else l1fs = null;
			if(other.back != null) l1bs = other.back.Sector; else l1bs = null;
			if(this.front != null) l2fs = this.front.Sector; else l2fs = null;
			if(this.back != null) l2bs = this.back.Sector; else l2bs = null;

			// This line has no sidedefs?
			if((l2fs == null) && (l2bs == null))
			{
				// We have no sidedefs, so we have no influence
				// Nothing to change on the other line
			}
			// Other line has no sidedefs?
			else if((l1fs == null) && (l1bs == null))
			{
				// The other has no sidedefs, so it has no influence
				// Copy my sidedefs to the other
				if(this.Start == other.Start)
				{
					if(!JoinChangeSidedefs(other, true, front)) return false;
					if(!JoinChangeSidedefs(other, false, back)) return false;
				}
				else
				{
					if(!JoinChangeSidedefs(other, false, front)) return false;
					if(!JoinChangeSidedefs(other, true, back)) return false;
				}

				// Copy my properties to the other
				this.CopyPropertiesTo(other);
			}
			else
			{
				// Compare front sectors
				if((l1fs != null) && (l1fs == l2fs))
				{
					// Copy textures
					if(other.front != null) other.front.AddTexturesTo(this.back);
					if(this.front != null) this.front.AddTexturesTo(other.back);

					// Change sidedefs
					if(!JoinChangeSidedefs(other, true, back)) return false;
				}
				// Compare back sectors
				else if((l1bs != null) && (l1bs == l2bs))
				{
					// Copy textures
					if(other.back != null) other.back.AddTexturesTo(this.front);
					if(this.back != null) this.back.AddTexturesTo(other.front);

					// Change sidedefs
					if(!JoinChangeSidedefs(other, false, front)) return false;
				}
				// Compare front and back
				else if((l1fs != null) && (l1fs == l2bs))
				{
					// Copy textures
					if(other.front != null) other.front.AddTexturesTo(this.front);
					if(this.back != null) this.back.AddTexturesTo(other.back);

					// Change sidedefs
					if(!JoinChangeSidedefs(other, true, front)) return false;
				}
				// Compare back and front
				else if((l1bs != null) && (l1bs == l2fs))
				{
					// Copy textures
					if(other.back != null) other.back.AddTexturesTo(this.back);
					if(this.front != null) this.front.AddTexturesTo(other.front);

					// Change sidedefs
					if(!JoinChangeSidedefs(other, false, back)) return false;
				}
				else
				{
					// Other line single sided?
					if(other.back == null)
					{
						// This line with its back to the other?
						if(this.start == other.end)
						{
							// Copy textures
							if(other.back != null) other.back.AddTexturesTo(this.front);
							if(this.back != null) this.back.AddTexturesTo(other.front);

							// Change sidedefs
							if(!JoinChangeSidedefs(other, false, front)) return false;
						}
						else
						{
							// Copy textures
							if(other.back != null) other.back.AddTexturesTo(this.back);
							if(this.front != null) this.front.AddTexturesTo(other.front);

							// Change sidedefs
							if(!JoinChangeSidedefs(other, false, back)) return false;
						}
					}
					// This line single sided?
					else if(this.back == null)
					{
						// Other line with its back to this?
						if(other.start == this.end)
						{
							// Copy textures
							if(other.back != null) other.back.AddTexturesTo(this.front);
							if(this.back != null) this.back.AddTexturesTo(other.front);

							// Change sidedefs
							if(!JoinChangeSidedefs(other, false, front)) return false;
						}
						else
						{
							// Copy textures
							if(other.front != null) other.front.AddTexturesTo(this.front);
							if(this.back != null) this.back.AddTexturesTo(other.back);

							// Change sidedefs
							if(!JoinChangeSidedefs(other, true, front)) return false;
						}
					}
					else
					{
						// This line with its back to the other?
						if(this.start == other.end)
						{
							// Copy textures
							if(other.back != null) other.back.AddTexturesTo(this.front);
							if(this.back != null) this.back.AddTexturesTo(other.front);

							// Change sidedefs
							if(!JoinChangeSidedefs(other, false, front)) return false;
						}
						else
						{
							// Copy textures
							if(other.back != null) other.back.AddTexturesTo(this.back);
							if(this.front != null) this.front.AddTexturesTo(other.front);

							// Change sidedefs
							if(!JoinChangeSidedefs(other, false, back)) return false;
						}
					}
				}
				
				// Apply single/double sided flags if the double-sided-ness changed
				if( (!l1was2s && ((other.Front != null) && (other.Back != null))) ||
					(l1was2s && ((other.Front == null) || (other.Back == null))) )
					other.ApplySidedFlags();
				
				// Remove unneeded textures
				if(other.front != null) other.front.RemoveUnneededTextures(!(l1was2s && l2was2s));
				if(other.back != null) other.back.RemoveUnneededTextures(!(l1was2s && l2was2s));
			}
			
			// If either of the two lines was selected, keep the other selected
			if(this.Selected) other.Selected = true;
			if(this.marked) other.marked = true;
			
			// I got killed by the other.
			this.Dispose();
			General.Map.IsChanged = true;
			return true;
		}
		
		// This changes sidedefs (used for joining lines)
		// target:		The linedef on which to remove or create a new sidedef
		// front:		Side on which to remove or create the sidedef (true for front side)
		// newside:		The side from which to copy the properties to the new sidedef.
		//				If this is null, no sidedef will be created (only removed)
		// Returns false when the operation could not be completed.
		private bool JoinChangeSidedefs(Linedef target, bool front, Sidedef newside)
		{
			Sidedef sd;
			
			// Change sidedefs
			if(front)
			{
				if(target.front != null) target.front.Dispose();
			}
			else
			{
				if(target.back != null) target.back.Dispose();
			}
			
			if(newside != null)
			{
				sd = map.CreateSidedef(target, front, newside.Sector);
				if(sd == null) return false;
				newside.CopyPropertiesTo(sd);
				sd.Marked = newside.Marked;
			}

			return true;
		}

		// String representation
		public override string ToString()
		{
			return "Linedef " + listindex;
		}
		
		#endregion

		#region ================== Changes
		
		// This updates all properties
		public void Update(Dictionary<string, bool> flags, int activate, int tag, int action, int mask, int[] args)
		{
			BeforePropsChange();
			
			// Apply changes
			this.flags = new Dictionary<string, bool>(flags);
			this.tag = tag;
			this.activate = activate;
			this.action = action;
            this.switchmask = mask; // villsa 9/12/11
			this.args = new int[NUM_ARGS];
			args.CopyTo(this.args, 0);
			this.updateneeded = true;
		}

		#endregion
	}
}
