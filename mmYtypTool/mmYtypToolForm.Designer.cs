
namespace mmYtypTool
{
    partial class mmYtypToolForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mmYtypToolForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fileDropDownBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.loadYtypFileBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.importYdrFileBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.clearWorkspaceBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.jenkinsHashBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.archetypeTsBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.addArchetypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCurrentArchetypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.textureDictTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.physicsDictTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.drawableDictTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.flagsTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bbMinTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bbMaxTb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bsCentreTb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bsRadiusTb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.hdTextureDistTb = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lodDistTb = new System.Windows.Forms.TextBox();
            this.archeotypesCb = new System.Windows.Forms.ComboBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.loadingLb = new System.Windows.Forms.ToolStripLabel();
            this.currFileLb = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label14 = new System.Windows.Forms.Label();
            this.archetypeIndexLb = new System.Windows.Forms.Label();
            this.assetNameTb = new System.Windows.Forms.TextBox();
            this.assetTypeCb = new System.Windows.Forms.ComboBox();
            this.ytypNameTb = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.archetypeTypeTb = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.specialAttributeCb = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clearFlagsBtn = new System.Windows.Forms.Button();
            this.flagsCalcList = new System.Windows.Forms.CheckedListBox();
            this.editModeCb = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileDropDownBtn,
            this.toolsBtn,
            this.archetypeTsBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(532, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // fileDropDownBtn
            // 
            this.fileDropDownBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileDropDownBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadYtypFileBtn,
            this.importYdrFileBtn,
            this.clearWorkspaceBtn,
            this.saveBtn,
            this.saveAsBtn});
            this.fileDropDownBtn.Enabled = false;
            this.fileDropDownBtn.Image = ((System.Drawing.Image)(resources.GetObject("fileDropDownBtn.Image")));
            this.fileDropDownBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileDropDownBtn.Name = "fileDropDownBtn";
            this.fileDropDownBtn.Size = new System.Drawing.Size(38, 22);
            this.fileDropDownBtn.Text = "File";
            // 
            // loadYtypFileBtn
            // 
            this.loadYtypFileBtn.Name = "loadYtypFileBtn";
            this.loadYtypFileBtn.Size = new System.Drawing.Size(160, 22);
            this.loadYtypFileBtn.Text = "Load Ytyp file";
            this.loadYtypFileBtn.Click += new System.EventHandler(this.loadYtypFileBtn_Click);
            // 
            // importYdrFileBtn
            // 
            this.importYdrFileBtn.Name = "importYdrFileBtn";
            this.importYdrFileBtn.Size = new System.Drawing.Size(160, 22);
            this.importYdrFileBtn.Text = "Import Ydr file";
            this.importYdrFileBtn.Click += new System.EventHandler(this.importYdrFileBtn_Click);
            // 
            // clearWorkspaceBtn
            // 
            this.clearWorkspaceBtn.Name = "clearWorkspaceBtn";
            this.clearWorkspaceBtn.Size = new System.Drawing.Size(160, 22);
            this.clearWorkspaceBtn.Text = "Clear workspace";
            this.clearWorkspaceBtn.Click += new System.EventHandler(this.clearWorkspaceBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(160, 22);
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // saveAsBtn
            // 
            this.saveAsBtn.Name = "saveAsBtn";
            this.saveAsBtn.Size = new System.Drawing.Size(160, 22);
            this.saveAsBtn.Text = "Save as";
            this.saveAsBtn.Click += new System.EventHandler(this.saveAsBtn_Click);
            // 
            // toolsBtn
            // 
            this.toolsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolsBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jenkinsHashBtn});
            this.toolsBtn.Enabled = false;
            this.toolsBtn.Image = ((System.Drawing.Image)(resources.GetObject("toolsBtn.Image")));
            this.toolsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsBtn.Name = "toolsBtn";
            this.toolsBtn.Size = new System.Drawing.Size(47, 22);
            this.toolsBtn.Text = "Tools";
            // 
            // jenkinsHashBtn
            // 
            this.jenkinsHashBtn.Name = "jenkinsHashBtn";
            this.jenkinsHashBtn.Size = new System.Drawing.Size(142, 22);
            this.jenkinsHashBtn.Text = "Jenkins Hash";
            this.jenkinsHashBtn.Click += new System.EventHandler(this.jenkinsHashBtn_Click);
            // 
            // archetypeTsBtn
            // 
            this.archetypeTsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.archetypeTsBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addArchetypeToolStripMenuItem,
            this.removeCurrentArchetypeToolStripMenuItem});
            this.archetypeTsBtn.Enabled = false;
            this.archetypeTsBtn.Image = ((System.Drawing.Image)(resources.GetObject("archetypeTsBtn.Image")));
            this.archetypeTsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.archetypeTsBtn.Name = "archetypeTsBtn";
            this.archetypeTsBtn.Size = new System.Drawing.Size(74, 22);
            this.archetypeTsBtn.Text = "Archetype";
            // 
            // addArchetypeToolStripMenuItem
            // 
            this.addArchetypeToolStripMenuItem.Name = "addArchetypeToolStripMenuItem";
            this.addArchetypeToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.addArchetypeToolStripMenuItem.Text = "Add new archetype";
            this.addArchetypeToolStripMenuItem.Click += new System.EventHandler(this.addBaseArchetypeBtn_Click);
            // 
            // removeCurrentArchetypeToolStripMenuItem
            // 
            this.removeCurrentArchetypeToolStripMenuItem.Name = "removeCurrentArchetypeToolStripMenuItem";
            this.removeCurrentArchetypeToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.removeCurrentArchetypeToolStripMenuItem.Text = "Remove current archetype";
            this.removeCurrentArchetypeToolStripMenuItem.Click += new System.EventHandler(this.removeCurrArcheBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // nameTb
            // 
            this.nameTb.BackColor = System.Drawing.Color.White;
            this.nameTb.Location = new System.Drawing.Point(109, 66);
            this.nameTb.Name = "nameTb";
            this.nameTb.ReadOnly = true;
            this.nameTb.Size = new System.Drawing.Size(202, 20);
            this.nameTb.TabIndex = 4;
            this.nameTb.TextChanged += new System.EventHandler(this.nameTb_TextChanged);
            // 
            // textureDictTb
            // 
            this.textureDictTb.BackColor = System.Drawing.Color.White;
            this.textureDictTb.Location = new System.Drawing.Point(109, 145);
            this.textureDictTb.Name = "textureDictTb";
            this.textureDictTb.ReadOnly = true;
            this.textureDictTb.Size = new System.Drawing.Size(202, 20);
            this.textureDictTb.TabIndex = 7;
            this.textureDictTb.TextChanged += new System.EventHandler(this.textureDictTb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Texture dictionary:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Asset Name:";
            // 
            // physicsDictTb
            // 
            this.physicsDictTb.BackColor = System.Drawing.Color.White;
            this.physicsDictTb.Location = new System.Drawing.Point(109, 171);
            this.physicsDictTb.Name = "physicsDictTb";
            this.physicsDictTb.ReadOnly = true;
            this.physicsDictTb.Size = new System.Drawing.Size(202, 20);
            this.physicsDictTb.TabIndex = 8;
            this.physicsDictTb.TextChanged += new System.EventHandler(this.physicsDictTb_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Physics dictionary:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Drawable dictionary:";
            // 
            // drawableDictTb
            // 
            this.drawableDictTb.BackColor = System.Drawing.Color.White;
            this.drawableDictTb.Location = new System.Drawing.Point(109, 197);
            this.drawableDictTb.Name = "drawableDictTb";
            this.drawableDictTb.ReadOnly = true;
            this.drawableDictTb.Size = new System.Drawing.Size(202, 20);
            this.drawableDictTb.TabIndex = 9;
            this.drawableDictTb.TextChanged += new System.EventHandler(this.drawableDictTb_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Flags:";
            // 
            // flagsTb
            // 
            this.flagsTb.BackColor = System.Drawing.Color.White;
            this.flagsTb.Location = new System.Drawing.Point(109, 250);
            this.flagsTb.Name = "flagsTb";
            this.flagsTb.ReadOnly = true;
            this.flagsTb.Size = new System.Drawing.Size(202, 20);
            this.flagsTb.TabIndex = 11;
            this.flagsTb.TextChanged += new System.EventHandler(this.flagsTb_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Asset Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "bbMin:";
            // 
            // bbMinTb
            // 
            this.bbMinTb.BackColor = System.Drawing.Color.White;
            this.bbMinTb.Location = new System.Drawing.Point(109, 276);
            this.bbMinTb.Name = "bbMinTb";
            this.bbMinTb.ReadOnly = true;
            this.bbMinTb.Size = new System.Drawing.Size(202, 20);
            this.bbMinTb.TabIndex = 12;
            this.bbMinTb.TextChanged += new System.EventHandler(this.bbMinTb_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "bbMax:";
            // 
            // bbMaxTb
            // 
            this.bbMaxTb.BackColor = System.Drawing.Color.White;
            this.bbMaxTb.Location = new System.Drawing.Point(110, 302);
            this.bbMaxTb.Name = "bbMaxTb";
            this.bbMaxTb.ReadOnly = true;
            this.bbMaxTb.Size = new System.Drawing.Size(201, 20);
            this.bbMaxTb.TabIndex = 13;
            this.bbMaxTb.TextChanged += new System.EventHandler(this.bbMaxTb_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "bsCentre:";
            // 
            // bsCentreTb
            // 
            this.bsCentreTb.BackColor = System.Drawing.Color.White;
            this.bsCentreTb.Location = new System.Drawing.Point(110, 328);
            this.bsCentreTb.Name = "bsCentreTb";
            this.bsCentreTb.ReadOnly = true;
            this.bsCentreTb.Size = new System.Drawing.Size(201, 20);
            this.bsCentreTb.TabIndex = 14;
            this.bsCentreTb.TextChanged += new System.EventHandler(this.bsCentreTb_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(48, 357);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "bsRadius:";
            // 
            // bsRadiusTb
            // 
            this.bsRadiusTb.BackColor = System.Drawing.Color.White;
            this.bsRadiusTb.Location = new System.Drawing.Point(110, 354);
            this.bsRadiusTb.Name = "bsRadiusTb";
            this.bsRadiusTb.ReadOnly = true;
            this.bsRadiusTb.Size = new System.Drawing.Size(201, 20);
            this.bsRadiusTb.TabIndex = 15;
            this.bsRadiusTb.TextChanged += new System.EventHandler(this.bsRadiusTb_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 383);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "hdTextureDist:";
            // 
            // hdTextureDistTb
            // 
            this.hdTextureDistTb.BackColor = System.Drawing.Color.White;
            this.hdTextureDistTb.Location = new System.Drawing.Point(110, 380);
            this.hdTextureDistTb.Name = "hdTextureDistTb";
            this.hdTextureDistTb.ReadOnly = true;
            this.hdTextureDistTb.Size = new System.Drawing.Size(202, 20);
            this.hdTextureDistTb.TabIndex = 16;
            this.hdTextureDistTb.TextChanged += new System.EventHandler(this.hdTextureDistTb_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(62, 409);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "lodDist:";
            // 
            // lodDistTb
            // 
            this.lodDistTb.BackColor = System.Drawing.Color.White;
            this.lodDistTb.Location = new System.Drawing.Point(109, 406);
            this.lodDistTb.Name = "lodDistTb";
            this.lodDistTb.ReadOnly = true;
            this.lodDistTb.Size = new System.Drawing.Size(202, 20);
            this.lodDistTb.TabIndex = 17;
            this.lodDistTb.TextChanged += new System.EventHandler(this.lodDistTb_TextChanged);
            // 
            // archeotypesCb
            // 
            this.archeotypesCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.archeotypesCb.FormattingEnabled = true;
            this.archeotypesCb.Location = new System.Drawing.Point(110, 13);
            this.archeotypesCb.Name = "archeotypesCb";
            this.archeotypesCb.Size = new System.Drawing.Size(143, 21);
            this.archeotypesCb.TabIndex = 2;
            this.archeotypesCb.SelectionChangeCommitted += new System.EventHandler(this.archeotypesCb_SelectionChangeCommitted);
            // 
            // toolStrip2
            // 
            this.toolStrip2.CanOverflow = false;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadingLb,
            this.currFileLb,
            this.toolStripSeparator1,
            this.toolStripSeparator2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 487);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(532, 25);
            this.toolStrip2.TabIndex = 28;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // loadingLb
            // 
            this.loadingLb.Name = "loadingLb";
            this.loadingLb.Size = new System.Drawing.Size(0, 22);
            // 
            // currFileLb
            // 
            this.currFileLb.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.currFileLb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.currFileLb.Name = "currFileLb";
            this.currFileLb.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(44, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Archetype:";
            // 
            // archetypeIndexLb
            // 
            this.archetypeIndexLb.AutoSize = true;
            this.archetypeIndexLb.Location = new System.Drawing.Point(258, 16);
            this.archetypeIndexLb.Name = "archetypeIndexLb";
            this.archetypeIndexLb.Size = new System.Drawing.Size(39, 13);
            this.archetypeIndexLb.TabIndex = 30;
            this.archetypeIndexLb.Text = "Index: ";
            // 
            // assetNameTb
            // 
            this.assetNameTb.BackColor = System.Drawing.Color.White;
            this.assetNameTb.Location = new System.Drawing.Point(109, 92);
            this.assetNameTb.Name = "assetNameTb";
            this.assetNameTb.ReadOnly = true;
            this.assetNameTb.Size = new System.Drawing.Size(202, 20);
            this.assetNameTb.TabIndex = 5;
            this.assetNameTb.TextChanged += new System.EventHandler(this.assetNameTb_TextChanged);
            // 
            // assetTypeCb
            // 
            this.assetTypeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.assetTypeCb.Enabled = false;
            this.assetTypeCb.FormattingEnabled = true;
            this.assetTypeCb.Items.AddRange(new object[] {
            "ASSET_TYPE_UNINITIALIZED",
            "ASSET_TYPE_FRAGMENT",
            "ASSET_TYPE_DRAWABLE",
            "ASSET_TYPE_DRAWABLEDICTIONARY",
            "ASSET_TYPE_ASSETLESS"});
            this.assetTypeCb.Location = new System.Drawing.Point(109, 118);
            this.assetTypeCb.Name = "assetTypeCb";
            this.assetTypeCb.Size = new System.Drawing.Size(202, 21);
            this.assetTypeCb.TabIndex = 6;
            this.assetTypeCb.TextChanged += new System.EventHandler(this.assetTypeCb_TextChanged);
            // 
            // ytypNameTb
            // 
            this.ytypNameTb.BackColor = System.Drawing.Color.White;
            this.ytypNameTb.Location = new System.Drawing.Point(113, 29);
            this.ytypNameTb.Name = "ytypNameTb";
            this.ytypNameTb.ReadOnly = true;
            this.ytypNameTb.Size = new System.Drawing.Size(201, 20);
            this.ytypNameTb.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(45, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Ytyp name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.archetypeTypeTb);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.archeotypesCb);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.assetTypeCb);
            this.groupBox1.Controls.Add(this.nameTb);
            this.groupBox1.Controls.Add(this.assetNameTb);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.drawableDictTb);
            this.groupBox1.Controls.Add(this.textureDictTb);
            this.groupBox1.Controls.Add(this.physicsDictTb);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lodDistTb);
            this.groupBox1.Controls.Add(this.hdTextureDistTb);
            this.groupBox1.Controls.Add(this.bsRadiusTb);
            this.groupBox1.Controls.Add(this.bsCentreTb);
            this.groupBox1.Controls.Add(this.bbMaxTb);
            this.groupBox1.Controls.Add(this.bbMinTb);
            this.groupBox1.Controls.Add(this.flagsTb);
            this.groupBox1.Controls.Add(this.specialAttributeCb);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.archetypeIndexLb);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 436);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // archetypeTypeTb
            // 
            this.archetypeTypeTb.BackColor = System.Drawing.Color.White;
            this.archetypeTypeTb.Location = new System.Drawing.Point(109, 40);
            this.archetypeTypeTb.Name = "archetypeTypeTb";
            this.archetypeTypeTb.ReadOnly = true;
            this.archetypeTypeTb.Size = new System.Drawing.Size(202, 20);
            this.archetypeTypeTb.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(68, 43);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 42;
            this.label17.Text = "Type:";
            // 
            // specialAttributeCb
            // 
            this.specialAttributeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specialAttributeCb.Enabled = false;
            this.specialAttributeCb.FormattingEnabled = true;
            this.specialAttributeCb.Items.AddRange(new object[] {
            "0. special functions disabled",
            "1. slides left <-> right when player aproach",
            "2. slides left <-> right when player aproach",
            "3. slides left <-> right when player aproach",
            "4. slides left <-> right when player aproach",
            "5. up/down 90 degrees (like garage door)",
            "6. slides left <-> right when player aproach",
            "7. pushed by player",
            "8. slides left <-> right when player aproach",
            "9. doors move in contact with player in 90 degrees to left",
            "10. vertical auto move in straight line up/down when player aproach",
            "11. slides left <-> right when player aproach, doors collision don\'t work",
            "12. doors move in contact with player in 90 degrees to left",
            "13. slides left <-> right when player aproach, doors collision don\'t work",
            "14. unknown",
            "15. unknown",
            "16. unknown",
            "17. unknown",
            "18. unknown",
            "19. unknown",
            "20. unknown"});
            this.specialAttributeCb.Location = new System.Drawing.Point(109, 223);
            this.specialAttributeCb.Name = "specialAttributeCb";
            this.specialAttributeCb.Size = new System.Drawing.Size(202, 21);
            this.specialAttributeCb.TabIndex = 10;
            this.specialAttributeCb.TextChanged += new System.EventHandler(this.specialAttributeCb_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 226);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 13);
            this.label16.TabIndex = 40;
            this.label16.Text = "Special attribute:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clearFlagsBtn);
            this.groupBox2.Controls.Add(this.flagsCalcList);
            this.groupBox2.Location = new System.Drawing.Point(329, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 436);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // clearFlagsBtn
            // 
            this.clearFlagsBtn.Enabled = false;
            this.clearFlagsBtn.Location = new System.Drawing.Point(6, 404);
            this.clearFlagsBtn.Name = "clearFlagsBtn";
            this.clearFlagsBtn.Size = new System.Drawing.Size(188, 23);
            this.clearFlagsBtn.TabIndex = 21;
            this.clearFlagsBtn.Text = "Clear flags";
            this.clearFlagsBtn.UseVisualStyleBackColor = true;
            this.clearFlagsBtn.Click += new System.EventHandler(this.clearFlagsBtn_Click);
            // 
            // flagsCalcList
            // 
            this.flagsCalcList.Enabled = false;
            this.flagsCalcList.FormattingEnabled = true;
            this.flagsCalcList.Items.AddRange(new object[] {
            "1 - Unk01",
            "2 - Unk02",
            "4 - Unk03",
            "8 - Unk04",
            "16 - Unk05",
            "32 - Static",
            "64 - Unk07",
            "128 - Instance",
            "256 - Unk09",
            "512 - Bone anims (YCD)",
            "1024 - UV anims (YCD)",
            "2048 - Unk12",
            "4096 - Unk13",
            "8192 - Object won\'t cast shadows",
            "16384 - Unk15",
            "32768 - Unk16",
            "65536 - Double-sided rendering",
            "131072 - Dynamic",
            "262144 - Unk19",
            "524288 - Unk20",
            "1048576 - Unk21",
            "2097152 - Unk22",
            "4194304 - Unk23",
            "8388608 - Unk24",
            "16777216 - Unk25",
            "33554432 - Unk26",
            "67108864 - Enables special attribute",
            "134217728 - Unk28",
            "268435456 - Disable red vertex",
            "536870912 - Disable blue vertex",
            "1073741824 - Disable green vertex",
            "2147483648 - Disable alpha vertex"});
            this.flagsCalcList.Location = new System.Drawing.Point(6, 13);
            this.flagsCalcList.Name = "flagsCalcList";
            this.flagsCalcList.Size = new System.Drawing.Size(188, 379);
            this.flagsCalcList.TabIndex = 20;
            this.flagsCalcList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.flagsCalcList_ItemCheck);
            // 
            // editModeCb
            // 
            this.editModeCb.AutoSize = true;
            this.editModeCb.Enabled = false;
            this.editModeCb.Location = new System.Drawing.Point(456, 28);
            this.editModeCb.Name = "editModeCb";
            this.editModeCb.Size = new System.Drawing.Size(73, 17);
            this.editModeCb.TabIndex = 21;
            this.editModeCb.Text = "Edit mode";
            this.editModeCb.UseVisualStyleBackColor = true;
            this.editModeCb.CheckedChanged += new System.EventHandler(this.editModeCb_CheckedChanged);
            // 
            // mmYtypToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 512);
            this.Controls.Add(this.editModeCb);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ytypNameTb);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mmYtypToolForm";
            this.ShowIcon = false;
            this.Text = "mmYtypTool";
            this.Shown += new System.EventHandler(this.mmYtypTool_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.TextBox textureDictTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox physicsDictTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox drawableDictTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox flagsTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox bbMinTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox bbMaxTb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox bsCentreTb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox bsRadiusTb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox hdTextureDistTb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox lodDistTb;
        private System.Windows.Forms.ComboBox archeotypesCb;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel loadingLb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label archetypeIndexLb;
        private System.Windows.Forms.ToolStripLabel currFileLb;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TextBox assetNameTb;
        private System.Windows.Forms.ComboBox assetTypeCb;
        private System.Windows.Forms.TextBox ytypNameTb;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox specialAttributeCb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox flagsCalcList;
        private System.Windows.Forms.Button clearFlagsBtn;
        private System.Windows.Forms.ToolStripDropDownButton fileDropDownBtn;
        private System.Windows.Forms.ToolStripMenuItem loadYtypFileBtn;
        private System.Windows.Forms.ToolStripMenuItem importYdrFileBtn;
        private System.Windows.Forms.ToolStripMenuItem clearWorkspaceBtn;
        private System.Windows.Forms.ToolStripMenuItem saveBtn;
        private System.Windows.Forms.ToolStripMenuItem saveAsBtn;
        private System.Windows.Forms.TextBox archetypeTypeTb;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ToolStripDropDownButton toolsBtn;
        private System.Windows.Forms.ToolStripMenuItem jenkinsHashBtn;
        private System.Windows.Forms.CheckBox editModeCb;
        private System.Windows.Forms.ToolStripDropDownButton archetypeTsBtn;
        private System.Windows.Forms.ToolStripMenuItem addArchetypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCurrentArchetypeToolStripMenuItem;
    }
}

