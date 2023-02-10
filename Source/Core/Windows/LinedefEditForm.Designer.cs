namespace CodeImp.DoomBuilder.Windows
{
    partial class LinedefEditForm
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
            System.Windows.Forms.Label labelAction;
            System.Windows.Forms.Label taglabel;
            System.Windows.Forms.Label labelFrontUpper;
            System.Windows.Forms.Label labelFrontMiddle;
            System.Windows.Forms.Label labelFrontLower;
            System.Windows.Forms.Label labelFrontOffset;
            System.Windows.Forms.Label labelBackOffset;
            System.Windows.Forms.Label labelBackLower;
            System.Windows.Forms.Label labelBackMiddle;
            System.Windows.Forms.Label labelBackUpper;
            System.Windows.Forms.Label labelFrontSecIndex;
            System.Windows.Forms.Label labelBackSecIndex;
            System.Windows.Forms.Label switchtexturelbl;
            System.Windows.Forms.Label displayswitchlbl;
            this.cancel = new System.Windows.Forms.Button();
            this.apply = new System.Windows.Forms.Button();
            this.actiongroup = new System.Windows.Forms.GroupBox();
            this.action = new CodeImp.DoomBuilder.Controls.ActionSelectorControl();
            this.browseaction = new System.Windows.Forms.Button();
            this.newtag = new System.Windows.Forms.Button();
            this.settingsgroup = new System.Windows.Forms.GroupBox();
            this.flags = new CodeImp.DoomBuilder.Controls.CheckboxArrayControl();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabproperties = new System.Windows.Forms.TabPage();
            this.switchsetupbox = new System.Windows.Forms.GroupBox();
            this.chkSwitchTextureLower = new System.Windows.Forms.CheckBox();
            this.chkSwitchDisplayLower = new System.Windows.Forms.CheckBox();
            this.chkSwitchTextureMiddle = new System.Windows.Forms.CheckBox();
            this.chkSwitchDisplayMiddle = new System.Windows.Forms.CheckBox();
            this.chkSwitchTextureUpper = new System.Windows.Forms.CheckBox();
            this.chkSwitchDisplayUpper = new System.Windows.Forms.CheckBox();
            this.activationtype = new System.Windows.Forms.GroupBox();
            this.activationtyperepeat = new System.Windows.Forms.CheckBox();
            this.activationtypeyellow = new System.Windows.Forms.CheckBox();
            this.activationtypered = new System.Windows.Forms.CheckBox();
            this.activationtypeblue = new System.Windows.Forms.CheckBox();
            this.activationtypeshoot = new System.Windows.Forms.CheckBox();
            this.activationtypecross = new System.Windows.Forms.CheckBox();
            this.activationtypeuse = new System.Windows.Forms.CheckBox();
            this.idgroup = new System.Windows.Forms.GroupBox();
            this.tag = new CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox();
            this.tabsidedefs = new System.Windows.Forms.TabPage();
            this.splitter = new System.Windows.Forms.SplitContainer();
            this.frontside = new System.Windows.Forms.CheckBox();
            this.frontgroup = new System.Windows.Forms.GroupBox();
            this.frontoffsety = new CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox();
            this.frontoffsetx = new CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox();
            this.frontsector = new CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox();
            this.customfrontbutton = new System.Windows.Forms.Button();
            this.frontlow = new CodeImp.DoomBuilder.Controls.TextureSelectorControl();
            this.frontmid = new CodeImp.DoomBuilder.Controls.TextureSelectorControl();
            this.fronthigh = new CodeImp.DoomBuilder.Controls.TextureSelectorControl();
            this.backside = new System.Windows.Forms.CheckBox();
            this.backgroup = new System.Windows.Forms.GroupBox();
            this.backoffsety = new CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox();
            this.backoffsetx = new CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox();
            this.backsector = new CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox();
            this.custombackbutton = new System.Windows.Forms.Button();
            this.backlow = new CodeImp.DoomBuilder.Controls.TextureSelectorControl();
            this.backmid = new CodeImp.DoomBuilder.Controls.TextureSelectorControl();
            this.backhigh = new CodeImp.DoomBuilder.Controls.TextureSelectorControl();
            this.heightpanel1 = new System.Windows.Forms.Panel();
            this.heightpanel2 = new System.Windows.Forms.Panel();
            this.heightpanel3 = new System.Windows.Forms.Panel();
            labelAction = new System.Windows.Forms.Label();
            taglabel = new System.Windows.Forms.Label();
            labelFrontUpper = new System.Windows.Forms.Label();
            labelFrontMiddle = new System.Windows.Forms.Label();
            labelFrontLower = new System.Windows.Forms.Label();
            labelFrontOffset = new System.Windows.Forms.Label();
            labelBackOffset = new System.Windows.Forms.Label();
            labelBackLower = new System.Windows.Forms.Label();
            labelBackMiddle = new System.Windows.Forms.Label();
            labelBackUpper = new System.Windows.Forms.Label();
            labelFrontSecIndex = new System.Windows.Forms.Label();
            labelBackSecIndex = new System.Windows.Forms.Label();
            switchtexturelbl = new System.Windows.Forms.Label();
            displayswitchlbl = new System.Windows.Forms.Label();
            this.actiongroup.SuspendLayout();
            this.settingsgroup.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabproperties.SuspendLayout();
            this.switchsetupbox.SuspendLayout();
            this.activationtype.SuspendLayout();
            this.idgroup.SuspendLayout();
            this.tabsidedefs.SuspendLayout();
            this.splitter.Panel1.SuspendLayout();
            this.splitter.Panel2.SuspendLayout();
            this.splitter.SuspendLayout();
            this.frontgroup.SuspendLayout();
            this.backgroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAction
            // 
            labelAction.AutoSize = true;
            labelAction.Location = new System.Drawing.Point(15, 30);
            labelAction.Name = "labelAction";
            labelAction.Size = new System.Drawing.Size(41, 14);
            labelAction.TabIndex = 9;
            labelAction.Text = "Action:";
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
            // labelFrontUpper
            // 
            labelFrontUpper.Location = new System.Drawing.Point(252, 18);
            labelFrontUpper.Name = "labelFrontUpper";
            labelFrontUpper.Size = new System.Drawing.Size(83, 16);
            labelFrontUpper.TabIndex = 3;
            labelFrontUpper.Text = "Upper";
            labelFrontUpper.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelFrontMiddle
            // 
            labelFrontMiddle.Location = new System.Drawing.Point(343, 18);
            labelFrontMiddle.Name = "labelFrontMiddle";
            labelFrontMiddle.Size = new System.Drawing.Size(83, 16);
            labelFrontMiddle.TabIndex = 4;
            labelFrontMiddle.Text = "Middle";
            labelFrontMiddle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelFrontLower
            // 
            labelFrontLower.Location = new System.Drawing.Point(434, 18);
            labelFrontLower.Name = "labelFrontLower";
            labelFrontLower.Size = new System.Drawing.Size(83, 16);
            labelFrontLower.TabIndex = 5;
            labelFrontLower.Text = "Lower";
            labelFrontLower.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelFrontOffset
            // 
            labelFrontOffset.AutoSize = true;
            labelFrontOffset.Location = new System.Drawing.Point(16, 79);
            labelFrontOffset.Name = "labelFrontOffset";
            labelFrontOffset.Size = new System.Drawing.Size(80, 14);
            labelFrontOffset.TabIndex = 7;
            labelFrontOffset.Text = "Texture Offset:";
            // 
            // labelBackOffset
            // 
            labelBackOffset.AutoSize = true;
            labelBackOffset.Location = new System.Drawing.Point(16, 79);
            labelBackOffset.Name = "labelBackOffset";
            labelBackOffset.Size = new System.Drawing.Size(80, 14);
            labelBackOffset.TabIndex = 7;
            labelBackOffset.Text = "Texture Offset:";
            // 
            // labelBackLower
            // 
            labelBackLower.Location = new System.Drawing.Point(437, 18);
            labelBackLower.Name = "labelBackLower";
            labelBackLower.Size = new System.Drawing.Size(83, 16);
            labelBackLower.TabIndex = 5;
            labelBackLower.Text = "Lower";
            labelBackLower.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelBackMiddle
            // 
            labelBackMiddle.Location = new System.Drawing.Point(346, 18);
            labelBackMiddle.Name = "labelBackMiddle";
            labelBackMiddle.Size = new System.Drawing.Size(83, 16);
            labelBackMiddle.TabIndex = 4;
            labelBackMiddle.Text = "Middle";
            labelBackMiddle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelBackUpper
            // 
            labelBackUpper.Location = new System.Drawing.Point(255, 18);
            labelBackUpper.Name = "labelBackUpper";
            labelBackUpper.Size = new System.Drawing.Size(83, 16);
            labelBackUpper.TabIndex = 3;
            labelBackUpper.Text = "Upper";
            labelBackUpper.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelFrontSecIndex
            // 
            labelFrontSecIndex.AutoSize = true;
            labelFrontSecIndex.Location = new System.Drawing.Point(26, 40);
            labelFrontSecIndex.Name = "labelFrontSecIndex";
            labelFrontSecIndex.Size = new System.Drawing.Size(71, 14);
            labelFrontSecIndex.TabIndex = 13;
            labelFrontSecIndex.Text = "Sector Index:";
            // 
            // labelBackSecIndex
            // 
            labelBackSecIndex.AutoSize = true;
            labelBackSecIndex.Location = new System.Drawing.Point(26, 40);
            labelBackSecIndex.Name = "labelBackSecIndex";
            labelBackSecIndex.Size = new System.Drawing.Size(71, 14);
            labelBackSecIndex.TabIndex = 16;
            labelBackSecIndex.Text = "Sector Index:";
            // 
            // switchtexturelbl
            // 
            switchtexturelbl.AutoSize = true;
            switchtexturelbl.Location = new System.Drawing.Point(12, 56);
            switchtexturelbl.Name = "switchtexturelbl";
            switchtexturelbl.Size = new System.Drawing.Size(83, 14);
            switchtexturelbl.TabIndex = 20;
            switchtexturelbl.Text = "Switch Texture:";
            // 
            // displayswitchlbl
            // 
            displayswitchlbl.AutoSize = true;
            displayswitchlbl.Location = new System.Drawing.Point(12, 34);
            displayswitchlbl.Name = "displayswitchlbl";
            displayswitchlbl.Size = new System.Drawing.Size(82, 14);
            displayswitchlbl.TabIndex = 19;
            displayswitchlbl.Text = "Switch Display:";
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(455, 600);
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
            this.apply.Location = new System.Drawing.Point(337, 600);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(112, 25);
            this.apply.TabIndex = 1;
            this.apply.Text = "OK";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // actiongroup
            // 
            this.actiongroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actiongroup.Controls.Add(labelAction);
            this.actiongroup.Controls.Add(this.action);
            this.actiongroup.Controls.Add(this.browseaction);
            this.actiongroup.Location = new System.Drawing.Point(8, 234);
            this.actiongroup.Name = "actiongroup";
            this.actiongroup.Size = new System.Drawing.Size(533, 68);
            this.actiongroup.TabIndex = 1;
            this.actiongroup.TabStop = false;
            this.actiongroup.Text = " Action ";
            // 
            // action
            // 
            this.action.BackColor = System.Drawing.Color.Transparent;
            this.action.Cursor = System.Windows.Forms.Cursors.Default;
            this.action.Empty = false;
            this.action.GeneralizedCategories = null;
            this.action.Location = new System.Drawing.Point(62, 27);
            this.action.Macro = false;
            this.action.Name = "action";
            this.action.Size = new System.Drawing.Size(401, 21);
            this.action.TabIndex = 0;
            this.action.Value = 402;
            this.action.ValueChanges += new System.EventHandler(this.action_ValueChanges);
            // 
            // browseaction
            // 
            this.browseaction.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseaction.Image = global::CodeImp.DoomBuilder.Properties.Resources.treeview;
            this.browseaction.Location = new System.Drawing.Point(469, 26);
            this.browseaction.Name = "browseaction";
            this.browseaction.Padding = new System.Windows.Forms.Padding(0, 0, 1, 3);
            this.browseaction.Size = new System.Drawing.Size(30, 23);
            this.browseaction.TabIndex = 1;
            this.browseaction.Text = " ";
            this.browseaction.UseVisualStyleBackColor = true;
            this.browseaction.Click += new System.EventHandler(this.browseaction_Click);
            // 
            // newtag
            // 
            this.newtag.Location = new System.Drawing.Point(149, 27);
            this.newtag.Name = "newtag";
            this.newtag.Size = new System.Drawing.Size(76, 23);
            this.newtag.TabIndex = 1;
            this.newtag.Text = "New Tag";
            this.newtag.UseVisualStyleBackColor = true;
            this.newtag.Click += new System.EventHandler(this.newtag_Click);
            // 
            // settingsgroup
            // 
            this.settingsgroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsgroup.Controls.Add(this.flags);
            this.settingsgroup.Location = new System.Drawing.Point(8, 8);
            this.settingsgroup.Name = "settingsgroup";
            this.settingsgroup.Size = new System.Drawing.Size(533, 220);
            this.settingsgroup.TabIndex = 0;
            this.settingsgroup.TabStop = false;
            this.settingsgroup.Text = " Settings ";
            // 
            // flags
            // 
            this.flags.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flags.AutoScroll = true;
            this.flags.Columns = 3;
            this.flags.Location = new System.Drawing.Point(18, 26);
            this.flags.Name = "flags";
            this.flags.Size = new System.Drawing.Size(509, 182);
            this.flags.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.tabproperties);
            this.tabs.Controls.Add(this.tabsidedefs);
            this.tabs.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabs.Location = new System.Drawing.Point(10, 10);
            this.tabs.Margin = new System.Windows.Forms.Padding(1);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(557, 586);
            this.tabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabs.TabIndex = 0;
            // 
            // tabproperties
            // 
            this.tabproperties.Controls.Add(this.switchsetupbox);
            this.tabproperties.Controls.Add(this.activationtype);
            this.tabproperties.Controls.Add(this.idgroup);
            this.tabproperties.Controls.Add(this.settingsgroup);
            this.tabproperties.Controls.Add(this.actiongroup);
            this.tabproperties.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabproperties.Location = new System.Drawing.Point(4, 23);
            this.tabproperties.Name = "tabproperties";
            this.tabproperties.Padding = new System.Windows.Forms.Padding(5);
            this.tabproperties.Size = new System.Drawing.Size(549, 559);
            this.tabproperties.TabIndex = 0;
            this.tabproperties.Tag = "0";
            this.tabproperties.Text = "Properties";
            this.tabproperties.UseVisualStyleBackColor = true;
            // 
            // switchsetupbox
            // 
            this.switchsetupbox.Controls.Add(this.chkSwitchTextureLower);
            this.switchsetupbox.Controls.Add(this.chkSwitchDisplayLower);
            this.switchsetupbox.Controls.Add(this.chkSwitchTextureMiddle);
            this.switchsetupbox.Controls.Add(this.chkSwitchDisplayMiddle);
            this.switchsetupbox.Controls.Add(this.chkSwitchTextureUpper);
            this.switchsetupbox.Controls.Add(this.chkSwitchDisplayUpper);
            this.switchsetupbox.Controls.Add(switchtexturelbl);
            this.switchsetupbox.Controls.Add(displayswitchlbl);
            this.switchsetupbox.Location = new System.Drawing.Point(8, 458);
            this.switchsetupbox.Name = "switchsetupbox";
            this.switchsetupbox.Size = new System.Drawing.Size(533, 94);
            this.switchsetupbox.TabIndex = 32;
            this.switchsetupbox.TabStop = false;
            this.switchsetupbox.Text = "Switch Setup";
            // 
            // chkSwitchTextureLower
            // 
            this.chkSwitchTextureLower.AutoSize = true;
            this.chkSwitchTextureLower.Location = new System.Drawing.Point(240, 55);
            this.chkSwitchTextureLower.Name = "chkSwitchTextureLower";
            this.chkSwitchTextureLower.Size = new System.Drawing.Size(58, 18);
            this.chkSwitchTextureLower.TabIndex = 26;
            this.chkSwitchTextureLower.Text = "Lower";
            this.chkSwitchTextureLower.UseVisualStyleBackColor = true;
            this.chkSwitchTextureLower.CheckedChanged += new System.EventHandler(this.chkSwitchTextureLower_CheckedChanged_1);
            // 
            // chkSwitchDisplayLower
            // 
            this.chkSwitchDisplayLower.AutoSize = true;
            this.chkSwitchDisplayLower.Location = new System.Drawing.Point(240, 33);
            this.chkSwitchDisplayLower.Name = "chkSwitchDisplayLower";
            this.chkSwitchDisplayLower.Size = new System.Drawing.Size(58, 18);
            this.chkSwitchDisplayLower.TabIndex = 25;
            this.chkSwitchDisplayLower.Text = "Lower";
            this.chkSwitchDisplayLower.UseVisualStyleBackColor = true;
            this.chkSwitchDisplayLower.CheckedChanged += new System.EventHandler(this.chkSwitchDisplayLower_CheckedChanged_1);
            // 
            // chkSwitchTextureMiddle
            // 
            this.chkSwitchTextureMiddle.AutoSize = true;
            this.chkSwitchTextureMiddle.Location = new System.Drawing.Point(179, 55);
            this.chkSwitchTextureMiddle.Name = "chkSwitchTextureMiddle";
            this.chkSwitchTextureMiddle.Size = new System.Drawing.Size(56, 18);
            this.chkSwitchTextureMiddle.TabIndex = 24;
            this.chkSwitchTextureMiddle.Text = "Middle";
            this.chkSwitchTextureMiddle.UseVisualStyleBackColor = true;
            this.chkSwitchTextureMiddle.CheckedChanged += new System.EventHandler(this.chkSwitchTextureMiddle_CheckedChanged_1);
            // 
            // chkSwitchDisplayMiddle
            // 
            this.chkSwitchDisplayMiddle.AutoSize = true;
            this.chkSwitchDisplayMiddle.Location = new System.Drawing.Point(178, 33);
            this.chkSwitchDisplayMiddle.Name = "chkSwitchDisplayMiddle";
            this.chkSwitchDisplayMiddle.Size = new System.Drawing.Size(56, 18);
            this.chkSwitchDisplayMiddle.TabIndex = 23;
            this.chkSwitchDisplayMiddle.Text = "Middle";
            this.chkSwitchDisplayMiddle.UseVisualStyleBackColor = true;
            this.chkSwitchDisplayMiddle.CheckedChanged += new System.EventHandler(this.chkSwitchDisplayMiddle_CheckedChanged_1);
            // 
            // chkSwitchTextureUpper
            // 
            this.chkSwitchTextureUpper.AutoSize = true;
            this.chkSwitchTextureUpper.Location = new System.Drawing.Point(118, 55);
            this.chkSwitchTextureUpper.Name = "chkSwitchTextureUpper";
            this.chkSwitchTextureUpper.Size = new System.Drawing.Size(55, 18);
            this.chkSwitchTextureUpper.TabIndex = 22;
            this.chkSwitchTextureUpper.Text = "Upper";
            this.chkSwitchTextureUpper.UseVisualStyleBackColor = true;
            this.chkSwitchTextureUpper.CheckedChanged += new System.EventHandler(this.chkSwitchTextureUpper_CheckedChanged_1);
            // 
            // chkSwitchDisplayUpper
            // 
            this.chkSwitchDisplayUpper.AutoSize = true;
            this.chkSwitchDisplayUpper.Location = new System.Drawing.Point(118, 33);
            this.chkSwitchDisplayUpper.Name = "chkSwitchDisplayUpper";
            this.chkSwitchDisplayUpper.Size = new System.Drawing.Size(55, 18);
            this.chkSwitchDisplayUpper.TabIndex = 21;
            this.chkSwitchDisplayUpper.Text = "Upper";
            this.chkSwitchDisplayUpper.UseVisualStyleBackColor = true;
            this.chkSwitchDisplayUpper.CheckedChanged += new System.EventHandler(this.chkSwitchDisplayUpper_CheckedChanged_1);
            // 
            // activationtype
            // 
            this.activationtype.Controls.Add(this.activationtyperepeat);
            this.activationtype.Controls.Add(this.activationtypeyellow);
            this.activationtype.Controls.Add(this.activationtypered);
            this.activationtype.Controls.Add(this.activationtypeblue);
            this.activationtype.Controls.Add(this.activationtypeshoot);
            this.activationtype.Controls.Add(this.activationtypecross);
            this.activationtype.Controls.Add(this.activationtypeuse);
            this.activationtype.Location = new System.Drawing.Point(8, 380);
            this.activationtype.Name = "activationtype";
            this.activationtype.Size = new System.Drawing.Size(533, 72);
            this.activationtype.TabIndex = 31;
            this.activationtype.TabStop = false;
            this.activationtype.Text = "Activation Type";
            this.activationtype.Visible = false;
            // 
            // activationtyperepeat
            // 
            this.activationtyperepeat.AutoSize = true;
            this.activationtyperepeat.Location = new System.Drawing.Point(284, 19);
            this.activationtyperepeat.Name = "activationtyperepeat";
            this.activationtyperepeat.Size = new System.Drawing.Size(80, 18);
            this.activationtyperepeat.TabIndex = 3;
            this.activationtyperepeat.Text = "Repeatable";
            this.activationtyperepeat.UseVisualStyleBackColor = true;
            // 
            // activationtypeyellow
            // 
            this.activationtypeyellow.AutoSize = true;
            this.activationtypeyellow.Location = new System.Drawing.Point(119, 43);
            this.activationtypeyellow.Name = "activationtypeyellow";
            this.activationtypeyellow.Size = new System.Drawing.Size(81, 18);
            this.activationtypeyellow.TabIndex = 6;
            this.activationtypeyellow.Text = "Yellow Key";
            this.activationtypeyellow.UseVisualStyleBackColor = true;
            // 
            // activationtypered
            // 
            this.activationtypered.AutoSize = true;
            this.activationtypered.Location = new System.Drawing.Point(207, 43);
            this.activationtypered.Name = "activationtypered";
            this.activationtypered.Size = new System.Drawing.Size(67, 18);
            this.activationtypered.TabIndex = 5;
            this.activationtypered.Text = "Red Key";
            this.activationtypered.UseVisualStyleBackColor = true;
            // 
            // activationtypeblue
            // 
            this.activationtypeblue.AutoSize = true;
            this.activationtypeblue.Location = new System.Drawing.Point(44, 43);
            this.activationtypeblue.Name = "activationtypeblue";
            this.activationtypeblue.Size = new System.Drawing.Size(69, 18);
            this.activationtypeblue.TabIndex = 4;
            this.activationtypeblue.Text = "Blue Key";
            this.activationtypeblue.UseVisualStyleBackColor = true;
            // 
            // activationtypeshoot
            // 
            this.activationtypeshoot.AutoSize = true;
            this.activationtypeshoot.Location = new System.Drawing.Point(207, 19);
            this.activationtypeshoot.Name = "activationtypeshoot";
            this.activationtypeshoot.Size = new System.Drawing.Size(54, 18);
            this.activationtypeshoot.TabIndex = 2;
            this.activationtypeshoot.Text = "Shoot";
            this.activationtypeshoot.UseVisualStyleBackColor = true;
            // 
            // activationtypecross
            // 
            this.activationtypecross.AutoSize = true;
            this.activationtypecross.Location = new System.Drawing.Point(119, 19);
            this.activationtypecross.Name = "activationtypecross";
            this.activationtypecross.Size = new System.Drawing.Size(55, 18);
            this.activationtypecross.TabIndex = 1;
            this.activationtypecross.Text = "Cross";
            this.activationtypecross.UseVisualStyleBackColor = true;
            // 
            // activationtypeuse
            // 
            this.activationtypeuse.AutoSize = true;
            this.activationtypeuse.Location = new System.Drawing.Point(44, 19);
            this.activationtypeuse.Name = "activationtypeuse";
            this.activationtypeuse.Size = new System.Drawing.Size(45, 18);
            this.activationtypeuse.TabIndex = 0;
            this.activationtypeuse.Text = "Use";
            this.activationtypeuse.UseVisualStyleBackColor = true;
            // 
            // idgroup
            // 
            this.idgroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idgroup.Controls.Add(this.tag);
            this.idgroup.Controls.Add(taglabel);
            this.idgroup.Controls.Add(this.newtag);
            this.idgroup.Location = new System.Drawing.Point(8, 308);
            this.idgroup.Name = "idgroup";
            this.idgroup.Size = new System.Drawing.Size(533, 66);
            this.idgroup.TabIndex = 2;
            this.idgroup.TabStop = false;
            this.idgroup.Text = " Identification ";
            // 
            // tag
            // 
            this.tag.AllowDecimal = false;
            this.tag.AllowNegative = false;
            this.tag.AllowRelative = true;
            this.tag.ButtonStep = 1;
            this.tag.Location = new System.Drawing.Point(62, 26);
            this.tag.Name = "tag";
            this.tag.Size = new System.Drawing.Size(75, 24);
            this.tag.StepValues = null;
            this.tag.TabIndex = 7;
            // 
            // tabsidedefs
            // 
            this.tabsidedefs.Controls.Add(this.splitter);
            this.tabsidedefs.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabsidedefs.Location = new System.Drawing.Point(4, 23);
            this.tabsidedefs.Name = "tabsidedefs";
            this.tabsidedefs.Padding = new System.Windows.Forms.Padding(5);
            this.tabsidedefs.Size = new System.Drawing.Size(549, 559);
            this.tabsidedefs.TabIndex = 1;
            this.tabsidedefs.Tag = "1";
            this.tabsidedefs.Text = "Sidedefs";
            this.tabsidedefs.UseVisualStyleBackColor = true;
            // 
            // splitter
            // 
            this.splitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitter.IsSplitterFixed = true;
            this.splitter.Location = new System.Drawing.Point(5, 5);
            this.splitter.Name = "splitter";
            this.splitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitter.Panel1
            // 
            this.splitter.Panel1.Controls.Add(this.frontside);
            this.splitter.Panel1.Controls.Add(this.frontgroup);
            // 
            // splitter.Panel2
            // 
            this.splitter.Panel2.Controls.Add(this.backside);
            this.splitter.Panel2.Controls.Add(this.backgroup);
            this.splitter.Size = new System.Drawing.Size(539, 549);
            this.splitter.SplitterDistance = 263;
            this.splitter.TabIndex = 3;
            // 
            // frontside
            // 
            this.frontside.AutoSize = true;
            this.frontside.Location = new System.Drawing.Point(15, 1);
            this.frontside.Name = "frontside";
            this.frontside.Size = new System.Drawing.Size(75, 18);
            this.frontside.TabIndex = 0;
            this.frontside.Text = "Front Side";
            this.frontside.UseVisualStyleBackColor = true;
            this.frontside.CheckStateChanged += new System.EventHandler(this.frontside_CheckStateChanged);
            // 
            // frontgroup
            // 
            this.frontgroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frontgroup.Controls.Add(this.frontoffsety);
            this.frontgroup.Controls.Add(this.frontoffsetx);
            this.frontgroup.Controls.Add(this.frontsector);
            this.frontgroup.Controls.Add(this.customfrontbutton);
            this.frontgroup.Controls.Add(labelFrontSecIndex);
            this.frontgroup.Controls.Add(this.frontlow);
            this.frontgroup.Controls.Add(this.frontmid);
            this.frontgroup.Controls.Add(this.fronthigh);
            this.frontgroup.Controls.Add(labelFrontOffset);
            this.frontgroup.Controls.Add(labelFrontLower);
            this.frontgroup.Controls.Add(labelFrontMiddle);
            this.frontgroup.Controls.Add(labelFrontUpper);
            this.frontgroup.Enabled = false;
            this.frontgroup.Location = new System.Drawing.Point(3, 3);
            this.frontgroup.Name = "frontgroup";
            this.frontgroup.Size = new System.Drawing.Size(533, 257);
            this.frontgroup.TabIndex = 1;
            this.frontgroup.TabStop = false;
            this.frontgroup.Text = "     ";
            // 
            // frontoffsety
            // 
            this.frontoffsety.AllowDecimal = false;
            this.frontoffsety.AllowNegative = true;
            this.frontoffsety.AllowRelative = true;
            this.frontoffsety.ButtonStep = 1;
            this.frontoffsety.Location = new System.Drawing.Point(171, 74);
            this.frontoffsety.Name = "frontoffsety";
            this.frontoffsety.Size = new System.Drawing.Size(62, 24);
            this.frontoffsety.StepValues = null;
            this.frontoffsety.TabIndex = 16;
            // 
            // frontoffsetx
            // 
            this.frontoffsetx.AllowDecimal = false;
            this.frontoffsetx.AllowNegative = true;
            this.frontoffsetx.AllowRelative = true;
            this.frontoffsetx.ButtonStep = 1;
            this.frontoffsetx.Location = new System.Drawing.Point(103, 74);
            this.frontoffsetx.Name = "frontoffsetx";
            this.frontoffsetx.Size = new System.Drawing.Size(62, 24);
            this.frontoffsetx.StepValues = null;
            this.frontoffsetx.TabIndex = 15;
            // 
            // frontsector
            // 
            this.frontsector.AllowDecimal = false;
            this.frontsector.AllowNegative = false;
            this.frontsector.AllowRelative = false;
            this.frontsector.ButtonStep = 1;
            this.frontsector.Location = new System.Drawing.Point(103, 35);
            this.frontsector.Name = "frontsector";
            this.frontsector.Size = new System.Drawing.Size(130, 24);
            this.frontsector.StepValues = null;
            this.frontsector.TabIndex = 14;
            // 
            // customfrontbutton
            // 
            this.customfrontbutton.Location = new System.Drawing.Point(103, 124);
            this.customfrontbutton.Name = "customfrontbutton";
            this.customfrontbutton.Size = new System.Drawing.Size(115, 25);
            this.customfrontbutton.TabIndex = 3;
            this.customfrontbutton.Text = "Custom fields...";
            this.customfrontbutton.UseVisualStyleBackColor = true;
            this.customfrontbutton.Visible = false;
            this.customfrontbutton.Click += new System.EventHandler(this.customfrontbutton_Click);
            // 
            // frontlow
            // 
            this.frontlow.Location = new System.Drawing.Point(434, 37);
            this.frontlow.Name = "frontlow";
            this.frontlow.Required = false;
            this.frontlow.Size = new System.Drawing.Size(83, 112);
            this.frontlow.TabIndex = 6;
            this.frontlow.TextureName = "";
            // 
            // frontmid
            // 
            this.frontmid.Location = new System.Drawing.Point(343, 37);
            this.frontmid.Name = "frontmid";
            this.frontmid.Required = false;
            this.frontmid.Size = new System.Drawing.Size(83, 112);
            this.frontmid.TabIndex = 5;
            this.frontmid.TextureName = "";
            // 
            // fronthigh
            // 
            this.fronthigh.Location = new System.Drawing.Point(252, 37);
            this.fronthigh.Name = "fronthigh";
            this.fronthigh.Required = false;
            this.fronthigh.Size = new System.Drawing.Size(83, 112);
            this.fronthigh.TabIndex = 4;
            this.fronthigh.TextureName = "";
            // 
            // backside
            // 
            this.backside.AutoSize = true;
            this.backside.Location = new System.Drawing.Point(15, 1);
            this.backside.Name = "backside";
            this.backside.Size = new System.Drawing.Size(74, 18);
            this.backside.TabIndex = 0;
            this.backside.Text = "Back Side";
            this.backside.UseVisualStyleBackColor = true;
            this.backside.CheckStateChanged += new System.EventHandler(this.backside_CheckStateChanged);
            // 
            // backgroup
            // 
            this.backgroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backgroup.Controls.Add(this.backoffsety);
            this.backgroup.Controls.Add(this.backoffsetx);
            this.backgroup.Controls.Add(this.backsector);
            this.backgroup.Controls.Add(this.custombackbutton);
            this.backgroup.Controls.Add(labelBackSecIndex);
            this.backgroup.Controls.Add(this.backlow);
            this.backgroup.Controls.Add(this.backmid);
            this.backgroup.Controls.Add(this.backhigh);
            this.backgroup.Controls.Add(labelBackOffset);
            this.backgroup.Controls.Add(labelBackLower);
            this.backgroup.Controls.Add(labelBackMiddle);
            this.backgroup.Controls.Add(labelBackUpper);
            this.backgroup.Enabled = false;
            this.backgroup.Location = new System.Drawing.Point(3, 3);
            this.backgroup.Name = "backgroup";
            this.backgroup.Size = new System.Drawing.Size(535, 276);
            this.backgroup.TabIndex = 1;
            this.backgroup.TabStop = false;
            this.backgroup.Text = "     ";
            // 
            // backoffsety
            // 
            this.backoffsety.AllowDecimal = false;
            this.backoffsety.AllowNegative = true;
            this.backoffsety.AllowRelative = true;
            this.backoffsety.ButtonStep = 1;
            this.backoffsety.Location = new System.Drawing.Point(171, 74);
            this.backoffsety.Name = "backoffsety";
            this.backoffsety.Size = new System.Drawing.Size(62, 24);
            this.backoffsety.StepValues = null;
            this.backoffsety.TabIndex = 19;
            // 
            // backoffsetx
            // 
            this.backoffsetx.AllowDecimal = false;
            this.backoffsetx.AllowNegative = true;
            this.backoffsetx.AllowRelative = true;
            this.backoffsetx.ButtonStep = 1;
            this.backoffsetx.Location = new System.Drawing.Point(103, 74);
            this.backoffsetx.Name = "backoffsetx";
            this.backoffsetx.Size = new System.Drawing.Size(62, 24);
            this.backoffsetx.StepValues = null;
            this.backoffsetx.TabIndex = 18;
            // 
            // backsector
            // 
            this.backsector.AllowDecimal = false;
            this.backsector.AllowNegative = false;
            this.backsector.AllowRelative = false;
            this.backsector.ButtonStep = 1;
            this.backsector.Location = new System.Drawing.Point(103, 35);
            this.backsector.Name = "backsector";
            this.backsector.Size = new System.Drawing.Size(130, 24);
            this.backsector.StepValues = null;
            this.backsector.TabIndex = 17;
            // 
            // custombackbutton
            // 
            this.custombackbutton.Location = new System.Drawing.Point(103, 124);
            this.custombackbutton.Name = "custombackbutton";
            this.custombackbutton.Size = new System.Drawing.Size(115, 25);
            this.custombackbutton.TabIndex = 3;
            this.custombackbutton.Text = "Custom fields...";
            this.custombackbutton.UseVisualStyleBackColor = true;
            this.custombackbutton.Visible = false;
            this.custombackbutton.Click += new System.EventHandler(this.custombackbutton_Click);
            // 
            // backlow
            // 
            this.backlow.Location = new System.Drawing.Point(437, 37);
            this.backlow.Name = "backlow";
            this.backlow.Required = false;
            this.backlow.Size = new System.Drawing.Size(83, 112);
            this.backlow.TabIndex = 6;
            this.backlow.TextureName = "";
            // 
            // backmid
            // 
            this.backmid.Location = new System.Drawing.Point(346, 37);
            this.backmid.Name = "backmid";
            this.backmid.Required = false;
            this.backmid.Size = new System.Drawing.Size(83, 112);
            this.backmid.TabIndex = 5;
            this.backmid.TextureName = "";
            // 
            // backhigh
            // 
            this.backhigh.Location = new System.Drawing.Point(255, 37);
            this.backhigh.Name = "backhigh";
            this.backhigh.Required = false;
            this.backhigh.Size = new System.Drawing.Size(83, 112);
            this.backhigh.TabIndex = 4;
            this.backhigh.TextureName = "";
            // 
            // heightpanel1
            // 
            this.heightpanel1.BackColor = System.Drawing.Color.Navy;
            this.heightpanel1.Location = new System.Drawing.Point(0, -19);
            this.heightpanel1.Name = "heightpanel1";
            this.heightpanel1.Size = new System.Drawing.Size(78, 510);
            this.heightpanel1.TabIndex = 3;
            this.heightpanel1.Visible = false;
            // 
            // heightpanel2
            // 
            this.heightpanel2.BackColor = System.Drawing.Color.Navy;
            this.heightpanel2.Location = new System.Drawing.Point(473, -19);
            this.heightpanel2.Name = "heightpanel2";
            this.heightpanel2.Size = new System.Drawing.Size(88, 470);
            this.heightpanel2.TabIndex = 4;
            this.heightpanel2.Visible = false;
            // 
            // heightpanel3
            // 
            this.heightpanel3.BackColor = System.Drawing.Color.Navy;
            this.heightpanel3.Location = new System.Drawing.Point(128, -19);
            this.heightpanel3.Name = "heightpanel3";
            this.heightpanel3.Size = new System.Drawing.Size(78, 682);
            this.heightpanel3.TabIndex = 5;
            this.heightpanel3.Visible = false;
            // 
            // LinedefEditForm
            // 
            this.AcceptButton = this.apply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(577, 627);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.heightpanel1);
            this.Controls.Add(this.heightpanel2);
            this.Controls.Add(this.heightpanel3);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LinedefEditForm";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Linedef";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.LinedefEditForm_HelpRequested);
            this.actiongroup.ResumeLayout(false);
            this.actiongroup.PerformLayout();
            this.settingsgroup.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            this.tabproperties.ResumeLayout(false);
            this.switchsetupbox.ResumeLayout(false);
            this.switchsetupbox.PerformLayout();
            this.activationtype.ResumeLayout(false);
            this.activationtype.PerformLayout();
            this.idgroup.ResumeLayout(false);
            this.idgroup.PerformLayout();
            this.tabsidedefs.ResumeLayout(false);
            this.splitter.Panel1.ResumeLayout(false);
            this.splitter.Panel1.PerformLayout();
            this.splitter.Panel2.ResumeLayout(false);
            this.splitter.Panel2.PerformLayout();
            this.splitter.ResumeLayout(false);
            this.frontgroup.ResumeLayout(false);
            this.frontgroup.PerformLayout();
            this.backgroup.ResumeLayout(false);
            this.backgroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.GroupBox actiongroup;
        private System.Windows.Forms.GroupBox settingsgroup;
        private CodeImp.DoomBuilder.Controls.CheckboxArrayControl flags;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button browseaction;
        private CodeImp.DoomBuilder.Controls.ActionSelectorControl action;
        private System.Windows.Forms.Button newtag;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabproperties;
        private System.Windows.Forms.TabPage tabsidedefs;
        private System.Windows.Forms.GroupBox frontgroup;
        private System.Windows.Forms.CheckBox frontside;
        private System.Windows.Forms.CheckBox backside;
        private System.Windows.Forms.GroupBox backgroup;
        private CodeImp.DoomBuilder.Controls.TextureSelectorControl frontlow;
        private CodeImp.DoomBuilder.Controls.TextureSelectorControl frontmid;
        private CodeImp.DoomBuilder.Controls.TextureSelectorControl fronthigh;
        private CodeImp.DoomBuilder.Controls.TextureSelectorControl backlow;
        private CodeImp.DoomBuilder.Controls.TextureSelectorControl backmid;
        private CodeImp.DoomBuilder.Controls.TextureSelectorControl backhigh;
        private System.Windows.Forms.GroupBox idgroup;
        private System.Windows.Forms.SplitContainer splitter;
        private System.Windows.Forms.Button customfrontbutton;
        private System.Windows.Forms.Button custombackbutton;
        private System.Windows.Forms.Panel heightpanel1;
        private System.Windows.Forms.Panel heightpanel2;
        private System.Windows.Forms.Panel heightpanel3;    // villsa
        private CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox tag;
        private CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox frontoffsetx;
        private CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox frontsector;
        private CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox frontoffsety;
        private CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox backoffsety;
        private CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox backoffsetx;
        private CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox backsector;
        private System.Windows.Forms.GroupBox activationtype;
        private System.Windows.Forms.CheckBox activationtyperepeat;
        private System.Windows.Forms.CheckBox activationtypeyellow;
        private System.Windows.Forms.CheckBox activationtypered;
        private System.Windows.Forms.CheckBox activationtypeblue;
        private System.Windows.Forms.CheckBox activationtypeshoot;
        private System.Windows.Forms.CheckBox activationtypecross;
        private System.Windows.Forms.CheckBox activationtypeuse;
        private System.Windows.Forms.GroupBox switchsetupbox;
        private System.Windows.Forms.CheckBox chkSwitchTextureLower;
        private System.Windows.Forms.CheckBox chkSwitchDisplayLower;
        private System.Windows.Forms.CheckBox chkSwitchTextureMiddle;
        private System.Windows.Forms.CheckBox chkSwitchDisplayMiddle;
        private System.Windows.Forms.CheckBox chkSwitchTextureUpper;
        private System.Windows.Forms.CheckBox chkSwitchDisplayUpper;
    }
}
