namespace CodeImp.DoomBuilder.Windows
{
    partial class ThingEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label taglabel;
            this.cancel = new System.Windows.Forms.Button();
            this.apply = new System.Windows.Forms.Button();
            this.tabproperties = new System.Windows.Forms.TabPage();
            this.thingtype = new CodeImp.DoomBuilder.Controls.ThingBrowserControl();
            this.settingsgroup = new System.Windows.Forms.GroupBox();
            this.flags = new CodeImp.DoomBuilder.Controls.CheckboxArrayControl();
            this.anglecontrol = new CodeImp.DoomBuilder.Controls.AngleControl();
            this.heightlabel = new System.Windows.Forms.Label();
            this.angle = new CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox();
            this.height = new CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox();
            this.spritetex = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.newtag = new System.Windows.Forms.Button();
            this.tag = new CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox();
            this.tabs = new System.Windows.Forms.TabControl();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label5 = new System.Windows.Forms.Label();
            taglabel = new System.Windows.Forms.Label();
            this.tabproperties.SuspendLayout();
            groupBox1.SuspendLayout();
            this.settingsgroup.SuspendLayout();
            groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(558, 406);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(112, 25);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // apply
            // 
            this.apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.apply.Location = new System.Drawing.Point(439, 406);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(112, 25);
            this.apply.TabIndex = 1;
            this.apply.Text = "OK";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // tabproperties
            // 
            this.tabproperties.Controls.Add(this.groupBox3);
            this.tabproperties.Controls.Add(this.spritetex);
            this.tabproperties.Controls.Add(groupBox2);
            this.tabproperties.Controls.Add(this.settingsgroup);
            this.tabproperties.Controls.Add(groupBox1);
            this.tabproperties.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabproperties.Location = new System.Drawing.Point(4, 23);
            this.tabproperties.Name = "tabproperties";
            this.tabproperties.Padding = new System.Windows.Forms.Padding(3);
            this.tabproperties.Size = new System.Drawing.Size(652, 352);
            this.tabproperties.TabIndex = 0;
            this.tabproperties.Text = "Properties";
            this.tabproperties.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            groupBox1.Controls.Add(this.thingtype);
            groupBox1.Location = new System.Drawing.Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(269, 340);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = " Thing ";
            // 
            // thingtype
            // 
            this.thingtype.Location = new System.Drawing.Point(9, 22);
            this.thingtype.Margin = new System.Windows.Forms.Padding(6);
            this.thingtype.Name = "thingtype";
            this.thingtype.Size = new System.Drawing.Size(251, 308);
            this.thingtype.TabIndex = 0;
            this.thingtype.OnTypeChanged += new CodeImp.DoomBuilder.Controls.ThingBrowserControl.TypeChangedDeletegate(this.thingtype_OnTypeChanged);
            // 
            // settingsgroup
            // 
            this.settingsgroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsgroup.Controls.Add(this.flags);
            this.settingsgroup.Location = new System.Drawing.Point(284, 6);
            this.settingsgroup.Name = "settingsgroup";
            this.settingsgroup.Size = new System.Drawing.Size(362, 162);
            this.settingsgroup.TabIndex = 1;
            this.settingsgroup.TabStop = false;
            this.settingsgroup.Text = " Settings ";
            // 
            // flags
            // 
            this.flags.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flags.AutoScroll = true;
            this.flags.Columns = 2;
            this.flags.Location = new System.Drawing.Point(18, 26);
            this.flags.Name = "flags";
            this.flags.Size = new System.Drawing.Size(338, 129);
            this.flags.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            groupBox2.Controls.Add(this.height);
            groupBox2.Controls.Add(this.angle);
            groupBox2.Controls.Add(this.heightlabel);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(this.anglecontrol);
            groupBox2.Location = new System.Drawing.Point(397, 241);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(249, 105);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = " Coordination ";
            // 
            // anglecontrol
            // 
            this.anglecontrol.BackColor = System.Drawing.SystemColors.Control;
            this.anglecontrol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.anglecontrol.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anglecontrol.Location = new System.Drawing.Point(156, 13);
            this.anglecontrol.Name = "anglecontrol";
            this.anglecontrol.Size = new System.Drawing.Size(84, 84);
            this.anglecontrol.TabIndex = 2;
            this.anglecontrol.Value = 0;
            this.anglecontrol.ButtonClicked += new System.EventHandler(this.anglecontrol_ButtonClicked);
            // 
            // label5
            // 
            label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(24, 31);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(38, 14);
            label5.TabIndex = 8;
            label5.Text = "Angle:";
            // 
            // heightlabel
            // 
            this.heightlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.heightlabel.AutoSize = true;
            this.heightlabel.Location = new System.Drawing.Point(12, 66);
            this.heightlabel.Name = "heightlabel";
            this.heightlabel.Size = new System.Drawing.Size(50, 14);
            this.heightlabel.TabIndex = 9;
            this.heightlabel.Text = "Z Height:";
            // 
            // angle
            // 
            this.angle.AllowDecimal = false;
            this.angle.AllowNegative = true;
            this.angle.AllowRelative = true;
            this.angle.ButtonStep = 45;
            this.angle.Location = new System.Drawing.Point(68, 26);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(72, 24);
            this.angle.StepValues = null;
            this.angle.TabIndex = 10;
            this.angle.WhenTextChanged += new System.EventHandler(this.angle_TextChanged);
            // 
            // height
            // 
            this.height.AllowDecimal = false;
            this.height.AllowNegative = true;
            this.height.AllowRelative = true;
            this.height.ButtonStep = 8;
            this.height.Location = new System.Drawing.Point(68, 61);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(72, 24);
            this.height.StepValues = null;
            this.height.TabIndex = 11;
            // 
            // spritetex
            // 
            this.spritetex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.spritetex.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.spritetex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.spritetex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spritetex.Location = new System.Drawing.Point(284, 246);
            this.spritetex.Name = "spritetex";
            this.spritetex.Size = new System.Drawing.Size(104, 100);
            this.spritetex.TabIndex = 22;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tag);
            this.groupBox3.Controls.Add(taglabel);
            this.groupBox3.Controls.Add(this.newtag);
            this.groupBox3.Location = new System.Drawing.Point(284, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(362, 66);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Identification ";
            // 
            // newtag
            // 
            this.newtag.Location = new System.Drawing.Point(154, 27);
            this.newtag.Name = "newtag";
            this.newtag.Size = new System.Drawing.Size(76, 23);
            this.newtag.TabIndex = 1;
            this.newtag.Text = "New Tag";
            this.newtag.UseVisualStyleBackColor = true;
            // 
            // taglabel
            // 
            taglabel.AutoSize = true;
            taglabel.Location = new System.Drawing.Point(28, 31);
            taglabel.Name = "taglabel";
            taglabel.Size = new System.Drawing.Size(27, 14);
            taglabel.TabIndex = 6;
            taglabel.Text = "Tag:";
            // 
            // tag
            // 
            this.tag.AllowDecimal = false;
            this.tag.AllowNegative = false;
            this.tag.AllowRelative = true;
            this.tag.ButtonStep = 1;
            this.tag.Location = new System.Drawing.Point(62, 26);
            this.tag.Name = "tag";
            this.tag.Size = new System.Drawing.Size(80, 24);
            this.tag.StepValues = null;
            this.tag.TabIndex = 7;
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.tabproperties);
            this.tabs.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabs.Location = new System.Drawing.Point(10, 10);
            this.tabs.Margin = new System.Windows.Forms.Padding(1);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(660, 379);
            this.tabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabs.TabIndex = 0;
            // 
            // ThingEditForm
            // 
            this.AcceptButton = this.apply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(680, 441);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.tabs);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThingEditForm";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Thing";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ThingEditForm_HelpRequested);
            this.tabproperties.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            this.settingsgroup.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.TabPage tabproperties;
        private System.Windows.Forms.GroupBox groupBox3;
        private Controls.ButtonsNumericTextbox tag;
        private System.Windows.Forms.Button newtag;
        private System.Windows.Forms.Panel spritetex;
        private Controls.ButtonsNumericTextbox height;
        private Controls.ButtonsNumericTextbox angle;
        private System.Windows.Forms.Label heightlabel;
        private Controls.AngleControl anglecontrol;
        private System.Windows.Forms.GroupBox settingsgroup;
        private Controls.CheckboxArrayControl flags;
        private Controls.ThingBrowserControl thingtype;
        private System.Windows.Forms.TabControl tabs;
    }
}