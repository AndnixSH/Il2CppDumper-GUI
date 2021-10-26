namespace Il2CppDumper
{
    partial class FormGUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGUI));
            this.startBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.selBinFile = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.titleLbl = new System.Windows.Forms.Label();
            this.exeFileLbl = new System.Windows.Forms.Label();
            this.datFileLbl = new System.Windows.Forms.Label();
            this.selDatFile = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CodeRegistrationTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.metadataRegistrationTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxLogs = new System.Windows.Forms.RichTextBox();
            this.selOutDir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label6 = new System.Windows.Forms.Label();
            this.openFolderBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label17 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.settingsPicBox = new System.Windows.Forms.PictureBox();
            this.outputTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.datFileTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.binFileTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.aboutPicBox = new System.Windows.Forms.PictureBox();
            this.androArch = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboutPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Active = false;
            this.startBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(163)))), ((int)(((byte)(103)))));
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.startBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startBtn.BorderRadius = 0;
            this.startBtn.ButtonText = "Start dumping";
            this.startBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startBtn.DisabledColor = System.Drawing.Color.Gray;
            this.startBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.startBtn.Iconimage = null;
            this.startBtn.Iconimage_right = null;
            this.startBtn.Iconimage_right_Selected = null;
            this.startBtn.Iconimage_Selected = null;
            this.startBtn.IconMarginLeft = 0;
            this.startBtn.IconMarginRight = 0;
            this.startBtn.IconRightVisible = true;
            this.startBtn.IconRightZoom = 0D;
            this.startBtn.IconVisible = false;
            this.startBtn.IconZoom = 90D;
            this.startBtn.IsTab = false;
            this.startBtn.Location = new System.Drawing.Point(255, 229);
            this.startBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startBtn.Name = "startBtn";
            this.startBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.startBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(163)))), ((int)(((byte)(103)))));
            this.startBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.startBtn.selected = false;
            this.startBtn.Size = new System.Drawing.Size(201, 48);
            this.startBtn.TabIndex = 13;
            this.startBtn.Text = "Start dumping";
            this.startBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startBtn.Textcolor = System.Drawing.Color.White;
            this.startBtn.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // selBinFile
            // 
            this.selBinFile.Active = false;
            this.selBinFile.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(143)))), ((int)(((byte)(205)))));
            this.selBinFile.BackColor = System.Drawing.Color.DodgerBlue;
            this.selBinFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selBinFile.BorderRadius = 0;
            this.selBinFile.ButtonText = "Select";
            this.selBinFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selBinFile.DisabledColor = System.Drawing.Color.Gray;
            this.selBinFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.selBinFile.Iconcolor = System.Drawing.Color.Transparent;
            this.selBinFile.Iconimage = null;
            this.selBinFile.Iconimage_right = null;
            this.selBinFile.Iconimage_right_Selected = null;
            this.selBinFile.Iconimage_Selected = null;
            this.selBinFile.IconMarginLeft = 0;
            this.selBinFile.IconMarginRight = 0;
            this.selBinFile.IconRightVisible = true;
            this.selBinFile.IconRightZoom = 0D;
            this.selBinFile.IconVisible = false;
            this.selBinFile.IconZoom = 90D;
            this.selBinFile.IsTab = false;
            this.selBinFile.Location = new System.Drawing.Point(611, 41);
            this.selBinFile.Name = "selBinFile";
            this.selBinFile.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.selBinFile.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            this.selBinFile.OnHoverTextColor = System.Drawing.Color.White;
            this.selBinFile.selected = false;
            this.selBinFile.Size = new System.Drawing.Size(71, 35);
            this.selBinFile.TabIndex = 0;
            this.selBinFile.Text = "Select";
            this.selBinFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selBinFile.Textcolor = System.Drawing.Color.White;
            this.selBinFile.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selBinFile.Click += new System.EventHandler(this.selBinFile_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.panel1.Controls.Add(this.minimizeBtn);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.titleLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 33);
            this.panel1.TabIndex = 16;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBtn.Image")));
            this.minimizeBtn.ImageActive = null;
            this.minimizeBtn.Location = new System.Drawing.Point(637, 9);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(23, 27);
            this.minimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeBtn.TabIndex = 21;
            this.minimizeBtn.TabStop = false;
            this.minimizeBtn.Zoom = 10;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.ImageActive = null;
            this.closeBtn.Location = new System.Drawing.Point(663, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(29, 33);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 20;
            this.closeBtn.TabStop = false;
            this.closeBtn.Zoom = 10;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(9, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(129, 16);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Il2CppDumper GUI";
            // 
            // exeFileLbl
            // 
            this.exeFileLbl.AutoSize = true;
            this.exeFileLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exeFileLbl.ForeColor = System.Drawing.Color.White;
            this.exeFileLbl.Location = new System.Drawing.Point(7, 50);
            this.exeFileLbl.Name = "exeFileLbl";
            this.exeFileLbl.Size = new System.Drawing.Size(108, 16);
            this.exeFileLbl.TabIndex = 10;
            this.exeFileLbl.Text = "Executable file:";
            // 
            // datFileLbl
            // 
            this.datFileLbl.AutoSize = true;
            this.datFileLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datFileLbl.ForeColor = System.Drawing.Color.White;
            this.datFileLbl.Location = new System.Drawing.Point(7, 93);
            this.datFileLbl.Name = "datFileLbl";
            this.datFileLbl.Size = new System.Drawing.Size(150, 16);
            this.datFileLbl.TabIndex = 18;
            this.datFileLbl.Text = "global-metadata.dat:";
            // 
            // selDatFile
            // 
            this.selDatFile.Active = false;
            this.selDatFile.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(143)))), ((int)(((byte)(205)))));
            this.selDatFile.BackColor = System.Drawing.Color.DodgerBlue;
            this.selDatFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selDatFile.BorderRadius = 0;
            this.selDatFile.ButtonText = "Select";
            this.selDatFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selDatFile.DisabledColor = System.Drawing.Color.Gray;
            this.selDatFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.selDatFile.Iconcolor = System.Drawing.Color.Transparent;
            this.selDatFile.Iconimage = null;
            this.selDatFile.Iconimage_right = null;
            this.selDatFile.Iconimage_right_Selected = null;
            this.selDatFile.Iconimage_Selected = null;
            this.selDatFile.IconMarginLeft = 0;
            this.selDatFile.IconMarginRight = 0;
            this.selDatFile.IconRightVisible = true;
            this.selDatFile.IconRightZoom = 0D;
            this.selDatFile.IconVisible = false;
            this.selDatFile.IconZoom = 90D;
            this.selDatFile.IsTab = false;
            this.selDatFile.Location = new System.Drawing.Point(611, 84);
            this.selDatFile.Name = "selDatFile";
            this.selDatFile.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.selDatFile.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            this.selDatFile.OnHoverTextColor = System.Drawing.Color.White;
            this.selDatFile.selected = false;
            this.selDatFile.Size = new System.Drawing.Size(71, 35);
            this.selDatFile.TabIndex = 3;
            this.selDatFile.Text = "Select";
            this.selDatFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selDatFile.Textcolor = System.Drawing.Color.White;
            this.selDatFile.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selDatFile.Click += new System.EventHandler(this.selDatFile_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(9, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "CodeRegistration:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(358, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "MetadataRegistration:";
            // 
            // CodeRegistrationTxtBox
            // 
            this.CodeRegistrationTxtBox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            this.CodeRegistrationTxtBox.BorderColorIdle = System.Drawing.Color.DodgerBlue;
            this.CodeRegistrationTxtBox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            this.CodeRegistrationTxtBox.BorderThickness = 1;
            this.CodeRegistrationTxtBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CodeRegistrationTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CodeRegistrationTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CodeRegistrationTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            this.CodeRegistrationTxtBox.isPassword = false;
            this.CodeRegistrationTxtBox.Location = new System.Drawing.Point(170, 169);
            this.CodeRegistrationTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.CodeRegistrationTxtBox.MaxLength = 32767;
            this.CodeRegistrationTxtBox.Name = "CodeRegistrationTxtBox";
            this.CodeRegistrationTxtBox.Size = new System.Drawing.Size(148, 35);
            this.CodeRegistrationTxtBox.TabIndex = 9;
            this.CodeRegistrationTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // metadataRegistrationTxtBox
            // 
            this.metadataRegistrationTxtBox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            this.metadataRegistrationTxtBox.BorderColorIdle = System.Drawing.Color.DodgerBlue;
            this.metadataRegistrationTxtBox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            this.metadataRegistrationTxtBox.BorderThickness = 1;
            this.metadataRegistrationTxtBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.metadataRegistrationTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.metadataRegistrationTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.metadataRegistrationTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            this.metadataRegistrationTxtBox.isPassword = false;
            this.metadataRegistrationTxtBox.Location = new System.Drawing.Point(528, 169);
            this.metadataRegistrationTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.metadataRegistrationTxtBox.MaxLength = 32767;
            this.metadataRegistrationTxtBox.Name = "metadataRegistrationTxtBox";
            this.metadataRegistrationTxtBox.Size = new System.Drawing.Size(154, 35);
            this.metadataRegistrationTxtBox.TabIndex = 11;
            this.metadataRegistrationTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Log output:";
            // 
            // richTextBoxLogs
            // 
            this.richTextBoxLogs.BackColor = System.Drawing.Color.Black;
            this.richTextBoxLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxLogs.Font = new System.Drawing.Font("Consolas", 9F);
            this.richTextBoxLogs.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBoxLogs.Location = new System.Drawing.Point(11, 325);
            this.richTextBoxLogs.Name = "richTextBoxLogs";
            this.richTextBoxLogs.ReadOnly = true;
            this.richTextBoxLogs.Size = new System.Drawing.Size(671, 144);
            this.richTextBoxLogs.TabIndex = 17;
            this.richTextBoxLogs.Text = "";
            this.richTextBoxLogs.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBoxLogs_LinkClicked);
            this.richTextBoxLogs.TextChanged += new System.EventHandler(this.richTextBoxLogs_TextChanged);
            // 
            // selOutDir
            // 
            this.selOutDir.Active = false;
            this.selOutDir.Activecolor = System.Drawing.Color.DarkTurquoise;
            this.selOutDir.BackColor = System.Drawing.Color.DarkTurquoise;
            this.selOutDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selOutDir.BorderRadius = 0;
            this.selOutDir.ButtonText = "Select";
            this.selOutDir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selOutDir.DisabledColor = System.Drawing.Color.Gray;
            this.selOutDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.selOutDir.Iconcolor = System.Drawing.Color.Transparent;
            this.selOutDir.Iconimage = null;
            this.selOutDir.Iconimage_right = null;
            this.selOutDir.Iconimage_right_Selected = null;
            this.selOutDir.Iconimage_Selected = null;
            this.selOutDir.IconMarginLeft = 0;
            this.selOutDir.IconMarginRight = 0;
            this.selOutDir.IconRightVisible = true;
            this.selOutDir.IconRightZoom = 0D;
            this.selOutDir.IconVisible = false;
            this.selOutDir.IconZoom = 90D;
            this.selOutDir.IsTab = false;
            this.selOutDir.Location = new System.Drawing.Point(611, 127);
            this.selOutDir.Name = "selOutDir";
            this.selOutDir.Normalcolor = System.Drawing.Color.DarkTurquoise;
            this.selOutDir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.selOutDir.OnHoverTextColor = System.Drawing.Color.White;
            this.selOutDir.selected = false;
            this.selOutDir.Size = new System.Drawing.Size(71, 35);
            this.selOutDir.TabIndex = 6;
            this.selOutDir.Text = "Select";
            this.selOutDir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selOutDir.Textcolor = System.Drawing.Color.White;
            this.selOutDir.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selOutDir.Click += new System.EventHandler(this.selOutDir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Output directory:";
            // 
            // openFolderBtn
            // 
            this.openFolderBtn.Active = false;
            this.openFolderBtn.Activecolor = System.Drawing.Color.DarkTurquoise;
            this.openFolderBtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.openFolderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openFolderBtn.BorderRadius = 0;
            this.openFolderBtn.ButtonText = "";
            this.openFolderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openFolderBtn.DisabledColor = System.Drawing.Color.Gray;
            this.openFolderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.openFolderBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.openFolderBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("openFolderBtn.Iconimage")));
            this.openFolderBtn.Iconimage_right = null;
            this.openFolderBtn.Iconimage_right_Selected = null;
            this.openFolderBtn.Iconimage_Selected = null;
            this.openFolderBtn.IconMarginLeft = 0;
            this.openFolderBtn.IconMarginRight = 0;
            this.openFolderBtn.IconRightVisible = true;
            this.openFolderBtn.IconRightZoom = 0D;
            this.openFolderBtn.IconVisible = true;
            this.openFolderBtn.IconZoom = 60D;
            this.openFolderBtn.IsTab = false;
            this.openFolderBtn.Location = new System.Drawing.Point(569, 127);
            this.openFolderBtn.Name = "openFolderBtn";
            this.openFolderBtn.Normalcolor = System.Drawing.Color.DarkTurquoise;
            this.openFolderBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.openFolderBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.openFolderBtn.selected = false;
            this.openFolderBtn.Size = new System.Drawing.Size(35, 35);
            this.openFolderBtn.TabIndex = 5;
            this.openFolderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.openFolderBtn.Textcolor = System.Drawing.Color.White;
            this.openFolderBtn.TextFont = new System.Drawing.Font("Century Gothic", 9.75F);
            this.openFolderBtn.Click += new System.EventHandler(this.openFolderBtn_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label17.ForeColor = System.Drawing.Color.DarkCyan;
            this.label17.Location = new System.Drawing.Point(155, 295);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(395, 17);
            this.label17.TabIndex = 50;
            this.label17.Text = "Drop APK, APKS, XAPK or decrypted IPA file to start dumping";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 33);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 449);
            this.panel4.TabIndex = 58;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 449);
            this.panel5.TabIndex = 29;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(691, 33);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 449);
            this.panel6.TabIndex = 59;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(1, 481);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(690, 1);
            this.panel7.TabIndex = 60;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // settingsPicBox
            // 
            this.settingsPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsPicBox.Image = ((System.Drawing.Image)(resources.GetObject("settingsPicBox.Image")));
            this.settingsPicBox.Location = new System.Drawing.Point(630, 214);
            this.settingsPicBox.Name = "settingsPicBox";
            this.settingsPicBox.Size = new System.Drawing.Size(50, 50);
            this.settingsPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settingsPicBox.TabIndex = 65;
            this.settingsPicBox.TabStop = false;
            this.settingsPicBox.Click += new System.EventHandler(this.settingsPicBox_Click);
            // 
            // outputTxtBox
            // 
            this.outputTxtBox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.outputTxtBox.BorderColorIdle = System.Drawing.Color.DarkTurquoise;
            this.outputTxtBox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.outputTxtBox.BorderThickness = 1;
            this.outputTxtBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.outputTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.outputTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.outputTxtBox.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.outputTxtBox.isPassword = false;
            this.outputTxtBox.Location = new System.Drawing.Point(170, 126);
            this.outputTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.outputTxtBox.MaxLength = 32767;
            this.outputTxtBox.Name = "outputTxtBox";
            this.outputTxtBox.Size = new System.Drawing.Size(390, 35);
            this.outputTxtBox.TabIndex = 4;
            this.outputTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // datFileTxtBox
            // 
            this.datFileTxtBox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            this.datFileTxtBox.BorderColorIdle = System.Drawing.Color.DodgerBlue;
            this.datFileTxtBox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            this.datFileTxtBox.BorderThickness = 1;
            this.datFileTxtBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.datFileTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.datFileTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.datFileTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            this.datFileTxtBox.isPassword = false;
            this.datFileTxtBox.Location = new System.Drawing.Point(170, 83);
            this.datFileTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.datFileTxtBox.MaxLength = 32767;
            this.datFileTxtBox.Name = "datFileTxtBox";
            this.datFileTxtBox.Size = new System.Drawing.Size(434, 35);
            this.datFileTxtBox.TabIndex = 2;
            this.datFileTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // binFileTxtBox
            // 
            this.binFileTxtBox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            this.binFileTxtBox.BorderColorIdle = System.Drawing.Color.DodgerBlue;
            this.binFileTxtBox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            this.binFileTxtBox.BorderThickness = 1;
            this.binFileTxtBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.binFileTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.binFileTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.binFileTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            this.binFileTxtBox.isPassword = false;
            this.binFileTxtBox.Location = new System.Drawing.Point(170, 40);
            this.binFileTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.binFileTxtBox.MaxLength = 32767;
            this.binFileTxtBox.Name = "binFileTxtBox";
            this.binFileTxtBox.Size = new System.Drawing.Size(434, 35);
            this.binFileTxtBox.TabIndex = 1;
            this.binFileTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // aboutPicBox
            // 
            this.aboutPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutPicBox.Image = ((System.Drawing.Image)(resources.GetObject("aboutPicBox.Image")));
            this.aboutPicBox.Location = new System.Drawing.Point(566, 214);
            this.aboutPicBox.Name = "aboutPicBox";
            this.aboutPicBox.Size = new System.Drawing.Size(50, 50);
            this.aboutPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aboutPicBox.TabIndex = 65;
            this.aboutPicBox.TabStop = false;
            this.aboutPicBox.Click += new System.EventHandler(this.aboutPicBox_Click);
            // 
            // androArch
            // 
            this.androArch.BackColor = System.Drawing.Color.Transparent;
            this.androArch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(143)))), ((int)(((byte)(205)))));
            this.androArch.BorderColor = System.Drawing.Color.Transparent;
            this.androArch.BorderRadius = 1;
            this.androArch.Color = System.Drawing.Color.Transparent;
            this.androArch.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.androArch.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.androArch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.androArch.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.androArch.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.androArch.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.androArch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.androArch.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.androArch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.androArch.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.androArch.FillDropDown = true;
            this.androArch.FillIndicator = false;
            this.androArch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.androArch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.androArch.ForeColor = System.Drawing.Color.White;
            this.androArch.FormattingEnabled = true;
            this.androArch.Icon = null;
            this.androArch.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.androArch.IndicatorColor = System.Drawing.Color.White;
            this.androArch.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.androArch.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(93)))), ((int)(((byte)(130)))));
            this.androArch.ItemBorderColor = System.Drawing.Color.White;
            this.androArch.ItemForeColor = System.Drawing.Color.White;
            this.androArch.ItemHeight = 26;
            this.androArch.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.androArch.ItemHighLightForeColor = System.Drawing.Color.White;
            this.androArch.Items.AddRange(new object[] {
            "Default (Dump all)",
            "ARMv7 only",
            "ARM64 only"});
            this.androArch.ItemTopMargin = 3;
            this.androArch.Location = new System.Drawing.Point(12, 233);
            this.androArch.Name = "androArch";
            this.androArch.Size = new System.Drawing.Size(165, 32);
            this.androArch.TabIndex = 66;
            this.androArch.Text = null;
            this.androArch.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.androArch.TextLeftMargin = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 67;
            this.label1.Text = "Android arch:";
            // 
            // FormGUI
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(692, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.androArch);
            this.Controls.Add(this.aboutPicBox);
            this.Controls.Add(this.settingsPicBox);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.openFolderBtn);
            this.Controls.Add(this.outputTxtBox);
            this.Controls.Add(this.richTextBoxLogs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.metadataRegistrationTxtBox);
            this.Controls.Add(this.CodeRegistrationTxtBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.datFileLbl);
            this.Controls.Add(this.exeFileLbl);
            this.Controls.Add(this.datFileTxtBox);
            this.Controls.Add(this.binFileTxtBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.selOutDir);
            this.Controls.Add(this.selDatFile);
            this.Controls.Add(this.selBinFile);
            this.Controls.Add(this.startBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormGUI";
            this.Text = "Il2CppDumper GUI";
            this.Load += new System.EventHandler(this.FormGUI_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormGUI_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormGUI_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.FormGUI_DragOver);
            this.DragLeave += new System.EventHandler(this.FormGUI_DragLeave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboutPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton startBtn;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton selBinFile;
        private System.Windows.Forms.Label datFileLbl;
        private System.Windows.Forms.Label exeFileLbl;
        private System.Windows.Forms.Label titleLbl;
        private Bunifu.Framework.UI.BunifuFlatButton selDatFile;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private Bunifu.Framework.UI.BunifuImageButton minimizeBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuFlatButton selOutDir;
        public Bunifu.Framework.UI.BunifuMetroTextbox metadataRegistrationTxtBox;
        public Bunifu.Framework.UI.BunifuMetroTextbox CodeRegistrationTxtBox;
        private Bunifu.Framework.UI.BunifuFlatButton openFolderBtn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        public Bunifu.Framework.UI.BunifuMetroTextbox binFileTxtBox;
        public Bunifu.Framework.UI.BunifuMetroTextbox datFileTxtBox;
        public Bunifu.Framework.UI.BunifuMetroTextbox outputTxtBox;
        private System.Windows.Forms.PictureBox settingsPicBox;
        internal System.Windows.Forms.RichTextBox richTextBoxLogs;
        private System.Windows.Forms.PictureBox aboutPicBox;
        private Bunifu.UI.WinForms.BunifuDropdown androArch;
        private System.Windows.Forms.Label label1;
    }
}