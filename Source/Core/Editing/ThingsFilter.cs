
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
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using CodeImp.DoomBuilder.Map;
using CodeImp.DoomBuilder.IO;
using CodeImp.DoomBuilder.Config;

#endregion

namespace CodeImp.DoomBuilder.Editing
{
	public class ThingsFilter
	{
		#region ================== Constants

		#endregion

		#region ================== Variables

		// Display name of this filter
		protected string name;
		
		// Filter by category
		protected string categoryname;

		// Filter by exact thing
		protected int thingtype;
		
		// Filter by fields
		protected List<string> requiredfields;
		protected List<string> forbiddenfields;
		
		// List of things
		protected List<Thing> visiblethings;
		protected List<Thing> hiddenthings;
		protected Dictionary<Thing, bool> thingsvisiblestate;
		
		// Disposing
		protected bool isdisposed = false;

		#endregion

		#region ================== Properties

		public string Name { get { return name; } internal set { name = value; } }
		public string CategoryName { get { return categoryname; } internal set { categoryname = value; } }
		internal int ThingType { get { return thingtype; } set { thingtype = value; } }
		internal ICollection<string> RequiredFields { get { return requiredfields; } }
		internal ICollection<string> ForbiddenFields { get { return forbiddenfields; } }
		public ICollection<Thing> VisibleThings { get { return visiblethings; } }
		public ICollection<Thing> HiddenThings { get { return hiddenthings; } }
		internal bool IsDisposed { get { return isdisposed; } }

		#endregion

		#region ================== Constructor / Disposer

		// Copy constructor
		internal ThingsFilter(ThingsFilter f)
		{
			// Copy
			name = f.name;
			categoryname = f.categoryname;
			thingtype = f.thingtype;
			requiredfields = new List<string>(f.requiredfields);
			forbiddenfields = new List<string>(f.forbiddenfields);
		}
		
		// Constructor for filter from configuration
		internal ThingsFilter(Configuration cfg, string path)
		{
			IDictionary fields;
			
			// Initialize
			requiredfields = new List<string>();
			forbiddenfields = new List<string>();
			
			// Read settings from config
			name = cfg.ReadSetting(path + ".name", "Unnamed filter");
			categoryname = cfg.ReadSetting(path + ".category", "");
			thingtype = cfg.ReadSetting(path + ".type", -1);
			
			// Read flags
			// key is string, value must be boolean which indicates if
			// its a required field (true) or forbidden field (false).
			fields = cfg.ReadSetting(path + ".fields", new Hashtable());
			foreach(DictionaryEntry de in fields)
			{
				// Add to the corresponding list
				if((bool)de.Value == true)
					requiredfields.Add(de.Key.ToString());
				else
					forbiddenfields.Add(de.Key.ToString());
			}
			
			// We have no destructor
			GC.SuppressFinalize(this);
		}

		// Constructor for a new filter
		internal ThingsFilter()
		{
			// Initialize
			requiredfields = new List<string>();
			forbiddenfields = new List<string>();
			categoryname = "";
			thingtype = -1;
			name = "Unnamed filter";
			
			// We have no destructor
			GC.SuppressFinalize(this);
		}

		// Disposer
		internal virtual void Dispose()
		{
			// Not already disposed?
			if(!isdisposed)
			{
				// Clean up
				visiblethings = null;
				hiddenthings = null;
				thingsvisiblestate = null;
				
				// Done
				isdisposed = true;
			}
		}

		#endregion

		#region ================== Methods

		/// <summary>
		/// This checks if a thing is visible. Throws an exception when the specified Thing does not exist in the map (filter not updated?).
		/// </summary>
		public bool IsThingVisible(Thing t)
		{
			return thingsvisiblestate[t];
		}

		// This writes the filter to configuration
		internal void WriteSettings(Configuration cfg, string path)
		{
			// Write settings to config
			cfg.WriteSetting(path + ".name", name);
			cfg.WriteSetting(path + ".category", categoryname);
			cfg.WriteSetting(path + ".type", thingtype);

			// Write required fields to config
			foreach(string s in requiredfields)
				cfg.WriteSetting(path + ".fields." + s, true);
			
			// Write forbidden fields to config
			foreach(string s in forbiddenfields)
				cfg.WriteSetting(path + ".fields." + s, false);
		}
		
		// This is called when the filter is activated
		internal virtual void Activate()
		{
			// Update the list of things
			Update();
		}
		
		// This is called when the filter is deactivates
		internal virtual void Deactivate()
		{
			// Clear lists
			visiblethings = null;
			hiddenthings = null;
			thingsvisiblestate = null;
		}
		
		/// <summary>
		/// This updates the list of things.
		/// </summary>
		public virtual void Update()
		{
			// Make new list
			visiblethings = new List<Thing>(General.Map.Map.Things.Count);
			hiddenthings = new List<Thing>(General.Map.Map.Things.Count);
			thingsvisiblestate = new Dictionary<Thing, bool>(General.Map.Map.Things.Count);
			foreach(Thing t in General.Map.Map.Things)
			{
				bool qualifies;

				// Get thing info
				ThingTypeInfo ti = General.Map.Data.GetThingInfo(t.Type);

				// Check if thing is in unknown category
				if(ti.Category == null)
				{
					// Check if the thing matches id
					qualifies = ((t.Type == thingtype) || (thingtype == -1)) && (categoryname.Length == 0);
				}
				else
				{
					// Check if the thing matches category and id
					qualifies = ((t.Type == thingtype) || (thingtype == -1)) &&
								((ti.Category.Name == categoryname) || (categoryname.Length == 0));
				}
				
				// Still qualifies?
				if(qualifies)
				{
					// Go for all required fields
					foreach(string s in requiredfields)
					{
						if(t.Flags.ContainsKey(s))
						{
							qualifies = (t.Flags[s] == true);
							break;
						}
						else
						{
							qualifies = false;
							break;
						}
					}
				}

				// Still qualifies?
				if(qualifies)
				{
					// Go for all forbidden fields
					foreach(string s in forbiddenfields)
					{
						if(t.Flags.ContainsKey(s))
						{
							qualifies = (t.Flags[s] == false);
							break;
						}
					}
				}
				
				// Put the thing in the lists
				if(qualifies) visiblethings.Add(t); else hiddenthings.Add(t);
				thingsvisiblestate.Add(t, qualifies);
			}
		}

		// String representation
		public override string ToString()
		{
			return name;
		}
		
		#endregion
	}
}
