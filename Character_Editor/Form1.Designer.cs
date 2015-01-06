namespace Character_Editor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param firstname="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deselectCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxSkills = new System.Windows.Forms.GroupBox();
            this.buttonRandomize = new System.Windows.Forms.Button();
            this.numericUpDownStealth = new System.Windows.Forms.NumericUpDown();
            this.labelStealth = new System.Windows.Forms.Label();
            this.numericUpDownLeadership = new System.Windows.Forms.NumericUpDown();
            this.labelLeadership = new System.Windows.Forms.Label();
            this.numericUpDownKnowledge = new System.Windows.Forms.NumericUpDown();
            this.labelKnowledge = new System.Windows.Forms.Label();
            this.numericUpDownHealing = new System.Windows.Forms.NumericUpDown();
            this.labelHealing = new System.Windows.Forms.Label();
            this.numericUpDownEndurance = new System.Windows.Forms.NumericUpDown();
            this.labelEndurance = new System.Windows.Forms.Label();
            this.numericUpDownDisguise = new System.Windows.Forms.NumericUpDown();
            this.labelDisguise = new System.Windows.Forms.Label();
            this.numericUpDownCheating = new System.Windows.Forms.NumericUpDown();
            this.labelCheating = new System.Windows.Forms.Label();
            this.numericUpDownBravery = new System.Windows.Forms.NumericUpDown();
            this.labelBravery = new System.Windows.Forms.Label();
            this.groupBoxBasic_Info = new System.Windows.Forms.GroupBox();
            this.labelRace = new System.Windows.Forms.Label();
            this.comboBoxRace = new System.Windows.Forms.ComboBox();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.listBoxCharacter = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxSkills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeadership)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKnowledge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHealing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndurance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDisguise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCheating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBravery)).BeginInit();
            this.groupBoxBasic_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(826, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCharacterToolStripMenuItem,
            this.updateCharacterToolStripMenuItem,
            this.deselectCharacterToolStripMenuItem,
            this.deleteCharacterToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.editToolStripMenuItem.Text = "&Actions";
            // 
            // addCharacterToolStripMenuItem
            // 
            this.addCharacterToolStripMenuItem.Name = "addCharacterToolStripMenuItem";
            this.addCharacterToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.addCharacterToolStripMenuItem.Text = "Add Character";
            this.addCharacterToolStripMenuItem.Click += new System.EventHandler(this.addCharacterToolStripMenuItem_Click);
            // 
            // updateCharacterToolStripMenuItem
            // 
            this.updateCharacterToolStripMenuItem.Enabled = false;
            this.updateCharacterToolStripMenuItem.Name = "updateCharacterToolStripMenuItem";
            this.updateCharacterToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.updateCharacterToolStripMenuItem.Text = "Update Character";
            this.updateCharacterToolStripMenuItem.Click += new System.EventHandler(this.updateCharacterToolStripMenuItem_Click);
            // 
            // deselectCharacterToolStripMenuItem
            // 
            this.deselectCharacterToolStripMenuItem.Enabled = false;
            this.deselectCharacterToolStripMenuItem.Name = "deselectCharacterToolStripMenuItem";
            this.deselectCharacterToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.deselectCharacterToolStripMenuItem.Text = "Deselect Character";
            this.deselectCharacterToolStripMenuItem.Click += new System.EventHandler(this.deselectCharacterToolStripMenuItem_Click);
            // 
            // deleteCharacterToolStripMenuItem
            // 
            this.deleteCharacterToolStripMenuItem.Enabled = false;
            this.deleteCharacterToolStripMenuItem.Name = "deleteCharacterToolStripMenuItem";
            this.deleteCharacterToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.deleteCharacterToolStripMenuItem.Text = "Delete Character";
            this.deleteCharacterToolStripMenuItem.Click += new System.EventHandler(this.deleteCharacterToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skillToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.toolsToolStripMenuItem.Text = "&View";
            // 
            // skillToolStripMenuItem
            // 
            this.skillToolStripMenuItem.Checked = true;
            this.skillToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.skillToolStripMenuItem.Name = "skillToolStripMenuItem";
            this.skillToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.skillToolStripMenuItem.Text = "Skill";
            this.skillToolStripMenuItem.Click += new System.EventHandler(this.skillToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.aboutToolStripMenuItem.Text = "&About Character Editor";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxSkills);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxBasic_Info);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listBoxCharacter);
            this.splitContainer1.Size = new System.Drawing.Size(826, 555);
            this.splitContainer1.SplitterDistance = 215;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBoxSkills
            // 
            this.groupBoxSkills.Controls.Add(this.buttonRandomize);
            this.groupBoxSkills.Controls.Add(this.numericUpDownStealth);
            this.groupBoxSkills.Controls.Add(this.labelStealth);
            this.groupBoxSkills.Controls.Add(this.numericUpDownLeadership);
            this.groupBoxSkills.Controls.Add(this.labelLeadership);
            this.groupBoxSkills.Controls.Add(this.numericUpDownKnowledge);
            this.groupBoxSkills.Controls.Add(this.labelKnowledge);
            this.groupBoxSkills.Controls.Add(this.numericUpDownHealing);
            this.groupBoxSkills.Controls.Add(this.labelHealing);
            this.groupBoxSkills.Controls.Add(this.numericUpDownEndurance);
            this.groupBoxSkills.Controls.Add(this.labelEndurance);
            this.groupBoxSkills.Controls.Add(this.numericUpDownDisguise);
            this.groupBoxSkills.Controls.Add(this.labelDisguise);
            this.groupBoxSkills.Controls.Add(this.numericUpDownCheating);
            this.groupBoxSkills.Controls.Add(this.labelCheating);
            this.groupBoxSkills.Controls.Add(this.numericUpDownBravery);
            this.groupBoxSkills.Controls.Add(this.labelBravery);
            this.groupBoxSkills.Location = new System.Drawing.Point(12, 154);
            this.groupBoxSkills.Name = "groupBoxSkills";
            this.groupBoxSkills.Size = new System.Drawing.Size(144, 271);
            this.groupBoxSkills.TabIndex = 1;
            this.groupBoxSkills.TabStop = false;
            this.groupBoxSkills.Text = "Skills";
            // 
            // buttonRandomize
            // 
            this.buttonRandomize.Location = new System.Drawing.Point(9, 240);
            this.buttonRandomize.Name = "buttonRandomize";
            this.buttonRandomize.Size = new System.Drawing.Size(122, 23);
            this.buttonRandomize.TabIndex = 16;
            this.buttonRandomize.Text = "Randomize";
            this.buttonRandomize.UseVisualStyleBackColor = true;
            this.buttonRandomize.Click += new System.EventHandler(this.buttonRandomize_Click);
            // 
            // numericUpDownStealth
            // 
            this.numericUpDownStealth.Location = new System.Drawing.Point(69, 206);
            this.numericUpDownStealth.Name = "numericUpDownStealth";
            this.numericUpDownStealth.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownStealth.TabIndex = 15;
            // 
            // labelStealth
            // 
            this.labelStealth.AutoSize = true;
            this.labelStealth.Location = new System.Drawing.Point(6, 208);
            this.labelStealth.Name = "labelStealth";
            this.labelStealth.Size = new System.Drawing.Size(40, 13);
            this.labelStealth.TabIndex = 14;
            this.labelStealth.Text = "Stealth";
            // 
            // numericUpDownLeadership
            // 
            this.numericUpDownLeadership.Location = new System.Drawing.Point(69, 180);
            this.numericUpDownLeadership.Name = "numericUpDownLeadership";
            this.numericUpDownLeadership.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownLeadership.TabIndex = 13;
            // 
            // labelLeadership
            // 
            this.labelLeadership.AutoSize = true;
            this.labelLeadership.Location = new System.Drawing.Point(6, 182);
            this.labelLeadership.Name = "labelLeadership";
            this.labelLeadership.Size = new System.Drawing.Size(59, 13);
            this.labelLeadership.TabIndex = 12;
            this.labelLeadership.Text = "Leadership";
            // 
            // numericUpDownKnowledge
            // 
            this.numericUpDownKnowledge.Location = new System.Drawing.Point(69, 154);
            this.numericUpDownKnowledge.Name = "numericUpDownKnowledge";
            this.numericUpDownKnowledge.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownKnowledge.TabIndex = 11;
            // 
            // labelKnowledge
            // 
            this.labelKnowledge.AutoSize = true;
            this.labelKnowledge.Location = new System.Drawing.Point(6, 156);
            this.labelKnowledge.Name = "labelKnowledge";
            this.labelKnowledge.Size = new System.Drawing.Size(60, 13);
            this.labelKnowledge.TabIndex = 10;
            this.labelKnowledge.Text = "Knowledge";
            // 
            // numericUpDownHealing
            // 
            this.numericUpDownHealing.Location = new System.Drawing.Point(69, 128);
            this.numericUpDownHealing.Name = "numericUpDownHealing";
            this.numericUpDownHealing.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownHealing.TabIndex = 9;
            // 
            // labelHealing
            // 
            this.labelHealing.AutoSize = true;
            this.labelHealing.Location = new System.Drawing.Point(6, 130);
            this.labelHealing.Name = "labelHealing";
            this.labelHealing.Size = new System.Drawing.Size(43, 13);
            this.labelHealing.TabIndex = 8;
            this.labelHealing.Text = "Healing";
            // 
            // numericUpDownEndurance
            // 
            this.numericUpDownEndurance.Location = new System.Drawing.Point(69, 102);
            this.numericUpDownEndurance.Name = "numericUpDownEndurance";
            this.numericUpDownEndurance.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownEndurance.TabIndex = 7;
            // 
            // labelEndurance
            // 
            this.labelEndurance.AutoSize = true;
            this.labelEndurance.Location = new System.Drawing.Point(6, 104);
            this.labelEndurance.Name = "labelEndurance";
            this.labelEndurance.Size = new System.Drawing.Size(59, 13);
            this.labelEndurance.TabIndex = 6;
            this.labelEndurance.Text = "Endurance";
            // 
            // numericUpDownDisguise
            // 
            this.numericUpDownDisguise.Location = new System.Drawing.Point(69, 76);
            this.numericUpDownDisguise.Name = "numericUpDownDisguise";
            this.numericUpDownDisguise.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownDisguise.TabIndex = 5;
            // 
            // labelDisguise
            // 
            this.labelDisguise.AutoSize = true;
            this.labelDisguise.Location = new System.Drawing.Point(6, 78);
            this.labelDisguise.Name = "labelDisguise";
            this.labelDisguise.Size = new System.Drawing.Size(47, 13);
            this.labelDisguise.TabIndex = 4;
            this.labelDisguise.Text = "Disguise";
            // 
            // numericUpDownCheating
            // 
            this.numericUpDownCheating.Location = new System.Drawing.Point(69, 50);
            this.numericUpDownCheating.Name = "numericUpDownCheating";
            this.numericUpDownCheating.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownCheating.TabIndex = 3;
            // 
            // labelCheating
            // 
            this.labelCheating.AutoSize = true;
            this.labelCheating.Location = new System.Drawing.Point(6, 52);
            this.labelCheating.Name = "labelCheating";
            this.labelCheating.Size = new System.Drawing.Size(49, 13);
            this.labelCheating.TabIndex = 2;
            this.labelCheating.Text = "Cheating";
            // 
            // numericUpDownBravery
            // 
            this.numericUpDownBravery.Location = new System.Drawing.Point(69, 24);
            this.numericUpDownBravery.Name = "numericUpDownBravery";
            this.numericUpDownBravery.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownBravery.TabIndex = 1;
            // 
            // labelBravery
            // 
            this.labelBravery.AutoSize = true;
            this.labelBravery.Location = new System.Drawing.Point(6, 26);
            this.labelBravery.Name = "labelBravery";
            this.labelBravery.Size = new System.Drawing.Size(43, 13);
            this.labelBravery.TabIndex = 0;
            this.labelBravery.Text = "Bravery";
            // 
            // groupBoxBasic_Info
            // 
            this.groupBoxBasic_Info.Controls.Add(this.labelRace);
            this.groupBoxBasic_Info.Controls.Add(this.comboBoxRace);
            this.groupBoxBasic_Info.Controls.Add(this.numericUpDownAge);
            this.groupBoxBasic_Info.Controls.Add(this.labelAge);
            this.groupBoxBasic_Info.Controls.Add(this.textBoxLastName);
            this.groupBoxBasic_Info.Controls.Add(this.labelLastName);
            this.groupBoxBasic_Info.Controls.Add(this.textBoxFirstName);
            this.groupBoxBasic_Info.Controls.Add(this.labelFirstName);
            this.groupBoxBasic_Info.Location = new System.Drawing.Point(11, 17);
            this.groupBoxBasic_Info.Name = "groupBoxBasic_Info";
            this.groupBoxBasic_Info.Size = new System.Drawing.Size(188, 130);
            this.groupBoxBasic_Info.TabIndex = 0;
            this.groupBoxBasic_Info.TabStop = false;
            this.groupBoxBasic_Info.Text = "Basic Info";
            // 
            // labelRace
            // 
            this.labelRace.AutoSize = true;
            this.labelRace.Location = new System.Drawing.Point(31, 98);
            this.labelRace.Name = "labelRace";
            this.labelRace.Size = new System.Drawing.Size(33, 13);
            this.labelRace.TabIndex = 7;
            this.labelRace.Text = "Race";
            // 
            // comboBoxRace
            // 
            this.comboBoxRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRace.FormattingEnabled = true;
            this.comboBoxRace.Location = new System.Drawing.Point(70, 95);
            this.comboBoxRace.Name = "comboBoxRace";
            this.comboBoxRace.Size = new System.Drawing.Size(100, 21);
            this.comboBoxRace.TabIndex = 6;
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Location = new System.Drawing.Point(70, 69);
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownAge.TabIndex = 5;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(39, 71);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(26, 13);
            this.labelAge.TabIndex = 4;
            this.labelAge.Text = "Age";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(70, 43);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 3;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(7, 46);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last Name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(70, 17);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(7, 20);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name";
            // 
            // listBoxCharacter
            // 
            this.listBoxCharacter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCharacter.FormattingEnabled = true;
            this.listBoxCharacter.Location = new System.Drawing.Point(0, 0);
            this.listBoxCharacter.Name = "listBoxCharacter";
            this.listBoxCharacter.Size = new System.Drawing.Size(605, 553);
            this.listBoxCharacter.TabIndex = 0;
            this.listBoxCharacter.SelectedIndexChanged += new System.EventHandler(this.listBoxCharacter_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 579);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Character Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxSkills.ResumeLayout(false);
            this.groupBoxSkills.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeadership)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKnowledge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHealing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndurance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDisguise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCheating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBravery)).EndInit();
            this.groupBoxBasic_Info.ResumeLayout(false);
            this.groupBoxBasic_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skillToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxBasic_Info;
        private System.Windows.Forms.Label labelRace;
        private System.Windows.Forms.ComboBox comboBoxRace;
        private System.Windows.Forms.NumericUpDown numericUpDownAge;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.ListBox listBoxCharacter;
        private System.Windows.Forms.GroupBox groupBoxSkills;
        private System.Windows.Forms.Button buttonRandomize;
        private System.Windows.Forms.NumericUpDown numericUpDownStealth;
        private System.Windows.Forms.Label labelStealth;
        private System.Windows.Forms.NumericUpDown numericUpDownLeadership;
        private System.Windows.Forms.Label labelLeadership;
        private System.Windows.Forms.NumericUpDown numericUpDownKnowledge;
        private System.Windows.Forms.Label labelKnowledge;
        private System.Windows.Forms.NumericUpDown numericUpDownHealing;
        private System.Windows.Forms.Label labelHealing;
        private System.Windows.Forms.NumericUpDown numericUpDownEndurance;
        private System.Windows.Forms.Label labelEndurance;
        private System.Windows.Forms.NumericUpDown numericUpDownDisguise;
        private System.Windows.Forms.Label labelDisguise;
        private System.Windows.Forms.NumericUpDown numericUpDownCheating;
        private System.Windows.Forms.Label labelCheating;
        private System.Windows.Forms.NumericUpDown numericUpDownBravery;
        private System.Windows.Forms.Label labelBravery;
        private System.Windows.Forms.ToolStripMenuItem addCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deselectCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCharacterToolStripMenuItem;
    }
}

