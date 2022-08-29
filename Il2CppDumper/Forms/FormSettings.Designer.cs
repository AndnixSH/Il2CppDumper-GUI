namespace Il2CppDumper
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.Panel = new System.Windows.Forms.Panel();
            this.titleLbl = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Ok = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.updateChkBox = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.winPosCheckBox = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.autoSetDirCheck = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.script6ChkBox = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.script5ChkBox = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.script4ChkBox = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.script3ChkBox = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.script2ChkBox = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.script1ChkBox = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.extDatChkBox = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.extBinaryChkBox = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.scriptGhiWasmChkBox = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.scriptHeader2GhidraChkBox = new Bunifu.UI.WinForms.BunifuCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.Panel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.ImageActive = null;
            this.closeBtn.Location = new System.Drawing.Point(623, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(29, 33);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 20;
            this.closeBtn.TabStop = false;
            this.closeBtn.Zoom = 10;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.Panel.Controls.Add(this.closeBtn);
            this.Panel.Controls.Add(this.titleLbl);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(652, 33);
            this.Panel.TabIndex = 17;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(9, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(58, 16);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Settings";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(18, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 17);
            this.label15.TabIndex = 49;
            this.label15.Text = "Check for updates:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(18, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 17);
            this.label10.TabIndex = 47;
            this.label10.Text = "Auto set output directory:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(18, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 17);
            this.label7.TabIndex = 46;
            this.label7.Text = "Remember window position:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 33);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 388);
            this.panel4.TabIndex = 59;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 388);
            this.panel5.TabIndex = 29;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(1, 420);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(651, 1);
            this.panel7.TabIndex = 61;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(650, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 1);
            this.panel6.TabIndex = 60;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(651, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 387);
            this.panel2.TabIndex = 62;
            // 
            // Ok
            // 
            this.Ok.AllowAnimations = true;
            this.Ok.AllowMouseEffects = true;
            this.Ok.AllowToggling = false;
            this.Ok.AnimationSpeed = 200;
            this.Ok.AutoGenerateColors = false;
            this.Ok.AutoRoundBorders = false;
            this.Ok.AutoSizeLeftIcon = true;
            this.Ok.AutoSizeRightIcon = true;
            this.Ok.BackColor = System.Drawing.Color.Transparent;
            this.Ok.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(143)))), ((int)(((byte)(205)))));
            this.Ok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ok.BackgroundImage")));
            this.Ok.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Ok.ButtonText = "Save and close";
            this.Ok.ButtonTextMarginLeft = 0;
            this.Ok.ColorContrastOnClick = 45;
            this.Ok.ColorContrastOnHover = 45;
            this.Ok.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.Ok.CustomizableEdges = borderEdges1;
            this.Ok.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Ok.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Ok.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Ok.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Ok.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Ok.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Ok.ForeColor = System.Drawing.Color.White;
            this.Ok.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ok.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Ok.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Ok.IconMarginLeft = 11;
            this.Ok.IconPadding = 10;
            this.Ok.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Ok.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Ok.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Ok.IconSize = 25;
            this.Ok.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(143)))), ((int)(((byte)(205)))));
            this.Ok.IdleBorderRadius = 1;
            this.Ok.IdleBorderThickness = 1;
            this.Ok.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(143)))), ((int)(((byte)(205)))));
            this.Ok.IdleIconLeftImage = null;
            this.Ok.IdleIconRightImage = null;
            this.Ok.IndicateFocus = false;
            this.Ok.Location = new System.Drawing.Point(221, 352);
            this.Ok.Name = "Ok";
            this.Ok.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Ok.OnDisabledState.BorderRadius = 1;
            this.Ok.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Ok.OnDisabledState.BorderThickness = 1;
            this.Ok.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Ok.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Ok.OnDisabledState.IconLeftImage = null;
            this.Ok.OnDisabledState.IconRightImage = null;
            this.Ok.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            this.Ok.onHoverState.BorderRadius = 1;
            this.Ok.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Ok.onHoverState.BorderThickness = 1;
            this.Ok.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            this.Ok.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Ok.onHoverState.IconLeftImage = null;
            this.Ok.onHoverState.IconRightImage = null;
            this.Ok.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(143)))), ((int)(((byte)(205)))));
            this.Ok.OnIdleState.BorderRadius = 1;
            this.Ok.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Ok.OnIdleState.BorderThickness = 1;
            this.Ok.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(143)))), ((int)(((byte)(205)))));
            this.Ok.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Ok.OnIdleState.IconLeftImage = null;
            this.Ok.OnIdleState.IconRightImage = null;
            this.Ok.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Ok.OnPressedState.BorderRadius = 1;
            this.Ok.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Ok.OnPressedState.BorderThickness = 1;
            this.Ok.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Ok.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Ok.OnPressedState.IconLeftImage = null;
            this.Ok.OnPressedState.IconRightImage = null;
            this.Ok.Size = new System.Drawing.Size(207, 39);
            this.Ok.TabIndex = 63;
            this.Ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Ok.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ok.TextMarginLeft = 0;
            this.Ok.TextPadding = new System.Windows.Forms.Padding(0);
            this.Ok.UseDefaultRadiusAndThickness = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Panel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 64;
            this.label1.Text = "Extract binary file:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 71;
            this.label3.Text = "Dumping:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 72;
            this.label4.Text = "General:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(337, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 16);
            this.label2.TabIndex = 71;
            this.label2.Text = "Auto copy script files:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(337, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 64;
            this.label5.Text = "ghidra.py";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(337, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 17);
            this.label6.TabIndex = 64;
            this.label6.Text = "ghidra_with_struct.py";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(337, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 64;
            this.label8.Text = "ida.py";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(337, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 64;
            this.label9.Text = "ida_py3.py";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(337, 236);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 17);
            this.label11.TabIndex = 64;
            this.label11.Text = "ida_with_struct.py";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(337, 271);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 17);
            this.label12.TabIndex = 64;
            this.label12.Text = "ida_with_struct_py3.py";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(18, 241);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(200, 17);
            this.label13.TabIndex = 64;
            this.label13.Text = "Extract global-metadata.dat:";
            // 
            // updateChkBox
            // 
            this.updateChkBox.AllowBindingControlAnimation = true;
            this.updateChkBox.AllowBindingControlColorChanges = false;
            this.updateChkBox.AllowBindingControlLocation = true;
            this.updateChkBox.AllowCheckBoxAnimation = false;
            this.updateChkBox.AllowCheckmarkAnimation = true;
            this.updateChkBox.AllowOnHoverStates = true;
            this.updateChkBox.AutoCheck = true;
            this.updateChkBox.BackColor = System.Drawing.Color.Transparent;
            this.updateChkBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateChkBox.BackgroundImage")));
            this.updateChkBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.updateChkBox.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.updateChkBox.BorderRadius = 12;
            this.updateChkBox.Checked = true;
            this.updateChkBox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.updateChkBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.updateChkBox.CustomCheckmarkImage = null;
            this.updateChkBox.Location = new System.Drawing.Point(289, 67);
            this.updateChkBox.MinimumSize = new System.Drawing.Size(17, 17);
            this.updateChkBox.Name = "updateChkBox";
            this.updateChkBox.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.updateChkBox.OnCheck.BorderRadius = 12;
            this.updateChkBox.OnCheck.BorderThickness = 2;
            this.updateChkBox.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.updateChkBox.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.updateChkBox.OnCheck.CheckmarkThickness = 2;
            this.updateChkBox.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.updateChkBox.OnDisable.BorderRadius = 12;
            this.updateChkBox.OnDisable.BorderThickness = 2;
            this.updateChkBox.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.updateChkBox.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.updateChkBox.OnDisable.CheckmarkThickness = 2;
            this.updateChkBox.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.updateChkBox.OnHoverChecked.BorderRadius = 12;
            this.updateChkBox.OnHoverChecked.BorderThickness = 2;
            this.updateChkBox.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.updateChkBox.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.updateChkBox.OnHoverChecked.CheckmarkThickness = 2;
            this.updateChkBox.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.updateChkBox.OnHoverUnchecked.BorderRadius = 12;
            this.updateChkBox.OnHoverUnchecked.BorderThickness = 1;
            this.updateChkBox.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.updateChkBox.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.updateChkBox.OnUncheck.BorderRadius = 12;
            this.updateChkBox.OnUncheck.BorderThickness = 1;
            this.updateChkBox.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.updateChkBox.Size = new System.Drawing.Size(21, 21);
            this.updateChkBox.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.updateChkBox.TabIndex = 70;
            this.updateChkBox.ThreeState = false;
            this.updateChkBox.ToolTipText = null;
            // 
            // winPosCheckBox
            // 
            this.winPosCheckBox.AllowBindingControlAnimation = true;
            this.winPosCheckBox.AllowBindingControlColorChanges = false;
            this.winPosCheckBox.AllowBindingControlLocation = true;
            this.winPosCheckBox.AllowCheckBoxAnimation = false;
            this.winPosCheckBox.AllowCheckmarkAnimation = true;
            this.winPosCheckBox.AllowOnHoverStates = true;
            this.winPosCheckBox.AutoCheck = true;
            this.winPosCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.winPosCheckBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("winPosCheckBox.BackgroundImage")));
            this.winPosCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.winPosCheckBox.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.winPosCheckBox.BorderRadius = 12;
            this.winPosCheckBox.Checked = false;
            this.winPosCheckBox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.winPosCheckBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.winPosCheckBox.CustomCheckmarkImage = null;
            this.winPosCheckBox.Location = new System.Drawing.Point(289, 100);
            this.winPosCheckBox.MinimumSize = new System.Drawing.Size(17, 17);
            this.winPosCheckBox.Name = "winPosCheckBox";
            this.winPosCheckBox.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.winPosCheckBox.OnCheck.BorderRadius = 12;
            this.winPosCheckBox.OnCheck.BorderThickness = 2;
            this.winPosCheckBox.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.winPosCheckBox.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.winPosCheckBox.OnCheck.CheckmarkThickness = 2;
            this.winPosCheckBox.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.winPosCheckBox.OnDisable.BorderRadius = 12;
            this.winPosCheckBox.OnDisable.BorderThickness = 2;
            this.winPosCheckBox.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.winPosCheckBox.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.winPosCheckBox.OnDisable.CheckmarkThickness = 2;
            this.winPosCheckBox.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.winPosCheckBox.OnHoverChecked.BorderRadius = 12;
            this.winPosCheckBox.OnHoverChecked.BorderThickness = 2;
            this.winPosCheckBox.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.winPosCheckBox.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.winPosCheckBox.OnHoverChecked.CheckmarkThickness = 2;
            this.winPosCheckBox.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.winPosCheckBox.OnHoverUnchecked.BorderRadius = 12;
            this.winPosCheckBox.OnHoverUnchecked.BorderThickness = 1;
            this.winPosCheckBox.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.winPosCheckBox.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.winPosCheckBox.OnUncheck.BorderRadius = 12;
            this.winPosCheckBox.OnUncheck.BorderThickness = 1;
            this.winPosCheckBox.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.winPosCheckBox.Size = new System.Drawing.Size(21, 21);
            this.winPosCheckBox.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.winPosCheckBox.TabIndex = 69;
            this.winPosCheckBox.ThreeState = false;
            this.winPosCheckBox.ToolTipText = null;
            // 
            // autoSetDirCheck
            // 
            this.autoSetDirCheck.AllowBindingControlAnimation = true;
            this.autoSetDirCheck.AllowBindingControlColorChanges = false;
            this.autoSetDirCheck.AllowBindingControlLocation = true;
            this.autoSetDirCheck.AllowCheckBoxAnimation = false;
            this.autoSetDirCheck.AllowCheckmarkAnimation = true;
            this.autoSetDirCheck.AllowOnHoverStates = true;
            this.autoSetDirCheck.AutoCheck = true;
            this.autoSetDirCheck.BackColor = System.Drawing.Color.Transparent;
            this.autoSetDirCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("autoSetDirCheck.BackgroundImage")));
            this.autoSetDirCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.autoSetDirCheck.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.autoSetDirCheck.BorderRadius = 12;
            this.autoSetDirCheck.Checked = true;
            this.autoSetDirCheck.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.autoSetDirCheck.Cursor = System.Windows.Forms.Cursors.Default;
            this.autoSetDirCheck.CustomCheckmarkImage = null;
            this.autoSetDirCheck.Location = new System.Drawing.Point(289, 134);
            this.autoSetDirCheck.MinimumSize = new System.Drawing.Size(17, 17);
            this.autoSetDirCheck.Name = "autoSetDirCheck";
            this.autoSetDirCheck.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.autoSetDirCheck.OnCheck.BorderRadius = 12;
            this.autoSetDirCheck.OnCheck.BorderThickness = 2;
            this.autoSetDirCheck.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.autoSetDirCheck.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.autoSetDirCheck.OnCheck.CheckmarkThickness = 2;
            this.autoSetDirCheck.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.autoSetDirCheck.OnDisable.BorderRadius = 12;
            this.autoSetDirCheck.OnDisable.BorderThickness = 2;
            this.autoSetDirCheck.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.autoSetDirCheck.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.autoSetDirCheck.OnDisable.CheckmarkThickness = 2;
            this.autoSetDirCheck.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.autoSetDirCheck.OnHoverChecked.BorderRadius = 12;
            this.autoSetDirCheck.OnHoverChecked.BorderThickness = 2;
            this.autoSetDirCheck.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.autoSetDirCheck.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.autoSetDirCheck.OnHoverChecked.CheckmarkThickness = 2;
            this.autoSetDirCheck.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.autoSetDirCheck.OnHoverUnchecked.BorderRadius = 12;
            this.autoSetDirCheck.OnHoverUnchecked.BorderThickness = 1;
            this.autoSetDirCheck.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.autoSetDirCheck.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.autoSetDirCheck.OnUncheck.BorderRadius = 12;
            this.autoSetDirCheck.OnUncheck.BorderThickness = 1;
            this.autoSetDirCheck.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.autoSetDirCheck.Size = new System.Drawing.Size(21, 21);
            this.autoSetDirCheck.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.autoSetDirCheck.TabIndex = 68;
            this.autoSetDirCheck.ThreeState = false;
            this.autoSetDirCheck.ToolTipText = null;
            // 
            // script6ChkBox
            // 
            this.script6ChkBox.AllowBindingControlAnimation = true;
            this.script6ChkBox.AllowBindingControlColorChanges = false;
            this.script6ChkBox.AllowBindingControlLocation = true;
            this.script6ChkBox.AllowCheckBoxAnimation = false;
            this.script6ChkBox.AllowCheckmarkAnimation = true;
            this.script6ChkBox.AllowOnHoverStates = true;
            this.script6ChkBox.AutoCheck = true;
            this.script6ChkBox.BackColor = System.Drawing.Color.Transparent;
            this.script6ChkBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("script6ChkBox.BackgroundImage")));
            this.script6ChkBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.script6ChkBox.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.script6ChkBox.BorderRadius = 12;
            this.script6ChkBox.Checked = true;
            this.script6ChkBox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.script6ChkBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.script6ChkBox.CustomCheckmarkImage = null;
            this.script6ChkBox.Location = new System.Drawing.Point(608, 268);
            this.script6ChkBox.MinimumSize = new System.Drawing.Size(17, 17);
            this.script6ChkBox.Name = "script6ChkBox";
            this.script6ChkBox.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.script6ChkBox.OnCheck.BorderRadius = 12;
            this.script6ChkBox.OnCheck.BorderThickness = 2;
            this.script6ChkBox.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.script6ChkBox.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.script6ChkBox.OnCheck.CheckmarkThickness = 2;
            this.script6ChkBox.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.script6ChkBox.OnDisable.BorderRadius = 12;
            this.script6ChkBox.OnDisable.BorderThickness = 2;
            this.script6ChkBox.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.script6ChkBox.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.script6ChkBox.OnDisable.CheckmarkThickness = 2;
            this.script6ChkBox.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.script6ChkBox.OnHoverChecked.BorderRadius = 12;
            this.script6ChkBox.OnHoverChecked.BorderThickness = 2;
            this.script6ChkBox.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.script6ChkBox.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.script6ChkBox.OnHoverChecked.CheckmarkThickness = 2;
            this.script6ChkBox.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.script6ChkBox.OnHoverUnchecked.BorderRadius = 12;
            this.script6ChkBox.OnHoverUnchecked.BorderThickness = 1;
            this.script6ChkBox.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.script6ChkBox.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.script6ChkBox.OnUncheck.BorderRadius = 12;
            this.script6ChkBox.OnUncheck.BorderThickness = 1;
            this.script6ChkBox.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.script6ChkBox.Size = new System.Drawing.Size(21, 21);
            this.script6ChkBox.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.script6ChkBox.TabIndex = 67;
            this.script6ChkBox.ThreeState = false;
            this.script6ChkBox.ToolTipText = null;
            // 
            // script5ChkBox
            // 
            this.script5ChkBox.AllowBindingControlAnimation = true;
            this.script5ChkBox.AllowBindingControlColorChanges = false;
            this.script5ChkBox.AllowBindingControlLocation = true;
            this.script5ChkBox.AllowCheckBoxAnimation = false;
            this.script5ChkBox.AllowCheckmarkAnimation = true;
            this.script5ChkBox.AllowOnHoverStates = true;
            this.script5ChkBox.AutoCheck = true;
            this.script5ChkBox.BackColor = System.Drawing.Color.Transparent;
            this.script5ChkBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("script5ChkBox.BackgroundImage")));
            this.script5ChkBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.script5ChkBox.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.script5ChkBox.BorderRadius = 12;
            this.script5ChkBox.Checked = true;
            this.script5ChkBox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.script5ChkBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.script5ChkBox.CustomCheckmarkImage = null;
            this.script5ChkBox.Location = new System.Drawing.Point(608, 233);
            this.script5ChkBox.MinimumSize = new System.Drawing.Size(17, 17);
            this.script5ChkBox.Name = "script5ChkBox";
            this.script5ChkBox.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.script5ChkBox.OnCheck.BorderRadius = 12;
            this.script5ChkBox.OnCheck.BorderThickness = 2;
            this.script5ChkBox.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.script5ChkBox.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.script5ChkBox.OnCheck.CheckmarkThickness = 2;
            this.script5ChkBox.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.script5ChkBox.OnDisable.BorderRadius = 12;
            this.script5ChkBox.OnDisable.BorderThickness = 2;
            this.script5ChkBox.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.script5ChkBox.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.script5ChkBox.OnDisable.CheckmarkThickness = 2;
            this.script5ChkBox.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.script5ChkBox.OnHoverChecked.BorderRadius = 12;
            this.script5ChkBox.OnHoverChecked.BorderThickness = 2;
            this.script5ChkBox.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.script5ChkBox.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.script5ChkBox.OnHoverChecked.CheckmarkThickness = 2;
            this.script5ChkBox.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.script5ChkBox.OnHoverUnchecked.BorderRadius = 12;
            this.script5ChkBox.OnHoverUnchecked.BorderThickness = 1;
            this.script5ChkBox.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.script5ChkBox.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.script5ChkBox.OnUncheck.BorderRadius = 12;
            this.script5ChkBox.OnUncheck.BorderThickness = 1;
            this.script5ChkBox.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.script5ChkBox.Size = new System.Drawing.Size(21, 21);
            this.script5ChkBox.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.script5ChkBox.TabIndex = 67;
            this.script5ChkBox.ThreeState = false;
            this.script5ChkBox.ToolTipText = null;
            // 
            // script4ChkBox
            // 
            this.script4ChkBox.AllowBindingControlAnimation = true;
            this.script4ChkBox.AllowBindingControlColorChanges = false;
            this.script4ChkBox.AllowBindingControlLocation = true;
            this.script4ChkBox.AllowCheckBoxAnimation = false;
            this.script4ChkBox.AllowCheckmarkAnimation = true;
            this.script4ChkBox.AllowOnHoverStates = true;
            this.script4ChkBox.AutoCheck = true;
            this.script4ChkBox.BackColor = System.Drawing.Color.Transparent;
            this.script4ChkBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("script4ChkBox.BackgroundImage")));
            this.script4ChkBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.script4ChkBox.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.script4ChkBox.BorderRadius = 12;
            this.script4ChkBox.Checked = false;
            this.script4ChkBox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.script4ChkBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.script4ChkBox.CustomCheckmarkImage = null;
            this.script4ChkBox.Location = new System.Drawing.Point(608, 198);
            this.script4ChkBox.MinimumSize = new System.Drawing.Size(17, 17);
            this.script4ChkBox.Name = "script4ChkBox";
            this.script4ChkBox.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.script4ChkBox.OnCheck.BorderRadius = 12;
            this.script4ChkBox.OnCheck.BorderThickness = 2;
            this.script4ChkBox.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.script4ChkBox.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.script4ChkBox.OnCheck.CheckmarkThickness = 2;
            this.script4ChkBox.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.script4ChkBox.OnDisable.BorderRadius = 12;
            this.script4ChkBox.OnDisable.BorderThickness = 2;
            this.script4ChkBox.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.script4ChkBox.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.script4ChkBox.OnDisable.CheckmarkThickness = 2;
            this.script4ChkBox.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.script4ChkBox.OnHoverChecked.BorderRadius = 12;
            this.script4ChkBox.OnHoverChecked.BorderThickness = 2;
            this.script4ChkBox.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.script4ChkBox.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.script4ChkBox.OnHoverChecked.CheckmarkThickness = 2;
            this.script4ChkBox.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.script4ChkBox.OnHoverUnchecked.BorderRadius = 12;
            this.script4ChkBox.OnHoverUnchecked.BorderThickness = 1;
            this.script4ChkBox.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.script4ChkBox.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.script4ChkBox.OnUncheck.BorderRadius = 12;
            this.script4ChkBox.OnUncheck.BorderThickness = 1;
            this.script4ChkBox.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.script4ChkBox.Size = new System.Drawing.Size(21, 21);
            this.script4ChkBox.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.script4ChkBox.TabIndex = 67;
            this.script4ChkBox.ThreeState = false;
            this.script4ChkBox.ToolTipText = null;
            // 
            // script3ChkBox
            // 
            this.script3ChkBox.AllowBindingControlAnimation = true;
            this.script3ChkBox.AllowBindingControlColorChanges = false;
            this.script3ChkBox.AllowBindingControlLocation = true;
            this.script3ChkBox.AllowCheckBoxAnimation = false;
            this.script3ChkBox.AllowCheckmarkAnimation = true;
            this.script3ChkBox.AllowOnHoverStates = true;
            this.script3ChkBox.AutoCheck = true;
            this.script3ChkBox.BackColor = System.Drawing.Color.Transparent;
            this.script3ChkBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("script3ChkBox.BackgroundImage")));
            this.script3ChkBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.script3ChkBox.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.script3ChkBox.BorderRadius = 12;
            this.script3ChkBox.Checked = false;
            this.script3ChkBox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.script3ChkBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.script3ChkBox.CustomCheckmarkImage = null;
            this.script3ChkBox.Location = new System.Drawing.Point(608, 163);
            this.script3ChkBox.MinimumSize = new System.Drawing.Size(17, 17);
            this.script3ChkBox.Name = "script3ChkBox";
            this.script3ChkBox.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.script3ChkBox.OnCheck.BorderRadius = 12;
            this.script3ChkBox.OnCheck.BorderThickness = 2;
            this.script3ChkBox.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.script3ChkBox.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.script3ChkBox.OnCheck.CheckmarkThickness = 2;
            this.script3ChkBox.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.script3ChkBox.OnDisable.BorderRadius = 12;
            this.script3ChkBox.OnDisable.BorderThickness = 2;
            this.script3ChkBox.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.script3ChkBox.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.script3ChkBox.OnDisable.CheckmarkThickness = 2;
            this.script3ChkBox.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.script3ChkBox.OnHoverChecked.BorderRadius = 12;
            this.script3ChkBox.OnHoverChecked.BorderThickness = 2;
            this.script3ChkBox.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.script3ChkBox.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.script3ChkBox.OnHoverChecked.CheckmarkThickness = 2;
            this.script3ChkBox.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.script3ChkBox.OnHoverUnchecked.BorderRadius = 12;
            this.script3ChkBox.OnHoverUnchecked.BorderThickness = 1;
            this.script3ChkBox.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.script3ChkBox.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.script3ChkBox.OnUncheck.BorderRadius = 12;
            this.script3ChkBox.OnUncheck.BorderThickness = 1;
            this.script3ChkBox.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.script3ChkBox.Size = new System.Drawing.Size(21, 21);
            this.script3ChkBox.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.script3ChkBox.TabIndex = 67;
            this.script3ChkBox.ThreeState = false;
            this.script3ChkBox.ToolTipText = null;
            // 
            // script2ChkBox
            // 
            this.script2ChkBox.AllowBindingControlAnimation = true;
            this.script2ChkBox.AllowBindingControlColorChanges = false;
            this.script2ChkBox.AllowBindingControlLocation = true;
            this.script2ChkBox.AllowCheckBoxAnimation = false;
            this.script2ChkBox.AllowCheckmarkAnimation = true;
            this.script2ChkBox.AllowOnHoverStates = true;
            this.script2ChkBox.AutoCheck = true;
            this.script2ChkBox.BackColor = System.Drawing.Color.Transparent;
            this.script2ChkBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("script2ChkBox.BackgroundImage")));
            this.script2ChkBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.script2ChkBox.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.script2ChkBox.BorderRadius = 12;
            this.script2ChkBox.Checked = false;
            this.script2ChkBox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.script2ChkBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.script2ChkBox.CustomCheckmarkImage = null;
            this.script2ChkBox.Location = new System.Drawing.Point(608, 130);
            this.script2ChkBox.MinimumSize = new System.Drawing.Size(17, 17);
            this.script2ChkBox.Name = "script2ChkBox";
            this.script2ChkBox.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.script2ChkBox.OnCheck.BorderRadius = 12;
            this.script2ChkBox.OnCheck.BorderThickness = 2;
            this.script2ChkBox.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.script2ChkBox.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.script2ChkBox.OnCheck.CheckmarkThickness = 2;
            this.script2ChkBox.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.script2ChkBox.OnDisable.BorderRadius = 12;
            this.script2ChkBox.OnDisable.BorderThickness = 2;
            this.script2ChkBox.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.script2ChkBox.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.script2ChkBox.OnDisable.CheckmarkThickness = 2;
            this.script2ChkBox.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.script2ChkBox.OnHoverChecked.BorderRadius = 12;
            this.script2ChkBox.OnHoverChecked.BorderThickness = 2;
            this.script2ChkBox.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.script2ChkBox.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.script2ChkBox.OnHoverChecked.CheckmarkThickness = 2;
            this.script2ChkBox.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.script2ChkBox.OnHoverUnchecked.BorderRadius = 12;
            this.script2ChkBox.OnHoverUnchecked.BorderThickness = 1;
            this.script2ChkBox.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.script2ChkBox.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.script2ChkBox.OnUncheck.BorderRadius = 12;
            this.script2ChkBox.OnUncheck.BorderThickness = 1;
            this.script2ChkBox.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.script2ChkBox.Size = new System.Drawing.Size(21, 21);
            this.script2ChkBox.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.script2ChkBox.TabIndex = 67;
            this.script2ChkBox.ThreeState = false;
            this.script2ChkBox.ToolTipText = null;
            // 
            // script1ChkBox
            // 
            this.script1ChkBox.AllowBindingControlAnimation = true;
            this.script1ChkBox.AllowBindingControlColorChanges = false;
            this.script1ChkBox.AllowBindingControlLocation = true;
            this.script1ChkBox.AllowCheckBoxAnimation = false;
            this.script1ChkBox.AllowCheckmarkAnimation = true;
            this.script1ChkBox.AllowOnHoverStates = true;
            this.script1ChkBox.AutoCheck = true;
            this.script1ChkBox.BackColor = System.Drawing.Color.Transparent;
            this.script1ChkBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("script1ChkBox.BackgroundImage")));
            this.script1ChkBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.script1ChkBox.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.script1ChkBox.BorderRadius = 12;
            this.script1ChkBox.Checked = false;
            this.script1ChkBox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.script1ChkBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.script1ChkBox.CustomCheckmarkImage = null;
            this.script1ChkBox.Location = new System.Drawing.Point(608, 67);
            this.script1ChkBox.MinimumSize = new System.Drawing.Size(17, 17);
            this.script1ChkBox.Name = "script1ChkBox";
            this.script1ChkBox.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.script1ChkBox.OnCheck.BorderRadius = 12;
            this.script1ChkBox.OnCheck.BorderThickness = 2;
            this.script1ChkBox.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.script1ChkBox.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.script1ChkBox.OnCheck.CheckmarkThickness = 2;
            this.script1ChkBox.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.script1ChkBox.OnDisable.BorderRadius = 12;
            this.script1ChkBox.OnDisable.BorderThickness = 2;
            this.script1ChkBox.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.script1ChkBox.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.script1ChkBox.OnDisable.CheckmarkThickness = 2;
            this.script1ChkBox.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.script1ChkBox.OnHoverChecked.BorderRadius = 12;
            this.script1ChkBox.OnHoverChecked.BorderThickness = 2;
            this.script1ChkBox.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.script1ChkBox.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.script1ChkBox.OnHoverChecked.CheckmarkThickness = 2;
            this.script1ChkBox.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.script1ChkBox.OnHoverUnchecked.BorderRadius = 12;
            this.script1ChkBox.OnHoverUnchecked.BorderThickness = 1;
            this.script1ChkBox.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.script1ChkBox.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.script1ChkBox.OnUncheck.BorderRadius = 12;
            this.script1ChkBox.OnUncheck.BorderThickness = 1;
            this.script1ChkBox.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.script1ChkBox.Size = new System.Drawing.Size(21, 21);
            this.script1ChkBox.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.script1ChkBox.TabIndex = 67;
            this.script1ChkBox.ThreeState = false;
            this.script1ChkBox.ToolTipText = null;
            // 
            // extDatChkBox
            // 
            this.extDatChkBox.AllowBindingControlAnimation = true;
            this.extDatChkBox.AllowBindingControlColorChanges = false;
            this.extDatChkBox.AllowBindingControlLocation = true;
            this.extDatChkBox.AllowCheckBoxAnimation = false;
            this.extDatChkBox.AllowCheckmarkAnimation = true;
            this.extDatChkBox.AllowOnHoverStates = true;
            this.extDatChkBox.AutoCheck = true;
            this.extDatChkBox.BackColor = System.Drawing.Color.Transparent;
            this.extDatChkBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("extDatChkBox.BackgroundImage")));
            this.extDatChkBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.extDatChkBox.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.extDatChkBox.BorderRadius = 12;
            this.extDatChkBox.Checked = false;
            this.extDatChkBox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.extDatChkBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.extDatChkBox.CustomCheckmarkImage = null;
            this.extDatChkBox.Location = new System.Drawing.Point(289, 237);
            this.extDatChkBox.MinimumSize = new System.Drawing.Size(17, 17);
            this.extDatChkBox.Name = "extDatChkBox";
            this.extDatChkBox.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.extDatChkBox.OnCheck.BorderRadius = 12;
            this.extDatChkBox.OnCheck.BorderThickness = 2;
            this.extDatChkBox.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.extDatChkBox.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.extDatChkBox.OnCheck.CheckmarkThickness = 2;
            this.extDatChkBox.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.extDatChkBox.OnDisable.BorderRadius = 12;
            this.extDatChkBox.OnDisable.BorderThickness = 2;
            this.extDatChkBox.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.extDatChkBox.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.extDatChkBox.OnDisable.CheckmarkThickness = 2;
            this.extDatChkBox.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.extDatChkBox.OnHoverChecked.BorderRadius = 12;
            this.extDatChkBox.OnHoverChecked.BorderThickness = 2;
            this.extDatChkBox.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.extDatChkBox.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.extDatChkBox.OnHoverChecked.CheckmarkThickness = 2;
            this.extDatChkBox.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.extDatChkBox.OnHoverUnchecked.BorderRadius = 12;
            this.extDatChkBox.OnHoverUnchecked.BorderThickness = 1;
            this.extDatChkBox.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.extDatChkBox.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.extDatChkBox.OnUncheck.BorderRadius = 12;
            this.extDatChkBox.OnUncheck.BorderThickness = 1;
            this.extDatChkBox.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.extDatChkBox.Size = new System.Drawing.Size(21, 21);
            this.extDatChkBox.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.extDatChkBox.TabIndex = 67;
            this.extDatChkBox.ThreeState = false;
            this.extDatChkBox.ToolTipText = null;
            // 
            // extBinaryChkBox
            // 
            this.extBinaryChkBox.AllowBindingControlAnimation = true;
            this.extBinaryChkBox.AllowBindingControlColorChanges = false;
            this.extBinaryChkBox.AllowBindingControlLocation = true;
            this.extBinaryChkBox.AllowCheckBoxAnimation = false;
            this.extBinaryChkBox.AllowCheckmarkAnimation = true;
            this.extBinaryChkBox.AllowOnHoverStates = true;
            this.extBinaryChkBox.AutoCheck = true;
            this.extBinaryChkBox.BackColor = System.Drawing.Color.Transparent;
            this.extBinaryChkBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("extBinaryChkBox.BackgroundImage")));
            this.extBinaryChkBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.extBinaryChkBox.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.extBinaryChkBox.BorderRadius = 12;
            this.extBinaryChkBox.Checked = false;
            this.extBinaryChkBox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.extBinaryChkBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.extBinaryChkBox.CustomCheckmarkImage = null;
            this.extBinaryChkBox.Location = new System.Drawing.Point(289, 203);
            this.extBinaryChkBox.MinimumSize = new System.Drawing.Size(17, 17);
            this.extBinaryChkBox.Name = "extBinaryChkBox";
            this.extBinaryChkBox.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.extBinaryChkBox.OnCheck.BorderRadius = 12;
            this.extBinaryChkBox.OnCheck.BorderThickness = 2;
            this.extBinaryChkBox.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.extBinaryChkBox.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.extBinaryChkBox.OnCheck.CheckmarkThickness = 2;
            this.extBinaryChkBox.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.extBinaryChkBox.OnDisable.BorderRadius = 12;
            this.extBinaryChkBox.OnDisable.BorderThickness = 2;
            this.extBinaryChkBox.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.extBinaryChkBox.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.extBinaryChkBox.OnDisable.CheckmarkThickness = 2;
            this.extBinaryChkBox.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.extBinaryChkBox.OnHoverChecked.BorderRadius = 12;
            this.extBinaryChkBox.OnHoverChecked.BorderThickness = 2;
            this.extBinaryChkBox.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.extBinaryChkBox.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.extBinaryChkBox.OnHoverChecked.CheckmarkThickness = 2;
            this.extBinaryChkBox.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.extBinaryChkBox.OnHoverUnchecked.BorderRadius = 12;
            this.extBinaryChkBox.OnHoverUnchecked.BorderThickness = 1;
            this.extBinaryChkBox.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.extBinaryChkBox.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.extBinaryChkBox.OnUncheck.BorderRadius = 12;
            this.extBinaryChkBox.OnUncheck.BorderThickness = 1;
            this.extBinaryChkBox.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.extBinaryChkBox.Size = new System.Drawing.Size(21, 21);
            this.extBinaryChkBox.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.extBinaryChkBox.TabIndex = 67;
            this.extBinaryChkBox.ThreeState = false;
            this.extBinaryChkBox.ToolTipText = null;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(337, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 17);
            this.label14.TabIndex = 64;
            this.label14.Text = "ghidra_wasm.py";
            // 
            // scriptGhiWasmChkBox
            // 
            this.scriptGhiWasmChkBox.AllowBindingControlAnimation = true;
            this.scriptGhiWasmChkBox.AllowBindingControlColorChanges = false;
            this.scriptGhiWasmChkBox.AllowBindingControlLocation = true;
            this.scriptGhiWasmChkBox.AllowCheckBoxAnimation = false;
            this.scriptGhiWasmChkBox.AllowCheckmarkAnimation = true;
            this.scriptGhiWasmChkBox.AllowOnHoverStates = true;
            this.scriptGhiWasmChkBox.AutoCheck = true;
            this.scriptGhiWasmChkBox.BackColor = System.Drawing.Color.Transparent;
            this.scriptGhiWasmChkBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("scriptGhiWasmChkBox.BackgroundImage")));
            this.scriptGhiWasmChkBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.scriptGhiWasmChkBox.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.scriptGhiWasmChkBox.BorderRadius = 12;
            this.scriptGhiWasmChkBox.Checked = false;
            this.scriptGhiWasmChkBox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.scriptGhiWasmChkBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.scriptGhiWasmChkBox.CustomCheckmarkImage = null;
            this.scriptGhiWasmChkBox.Location = new System.Drawing.Point(608, 98);
            this.scriptGhiWasmChkBox.MinimumSize = new System.Drawing.Size(17, 17);
            this.scriptGhiWasmChkBox.Name = "scriptGhiWasmChkBox";
            this.scriptGhiWasmChkBox.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.scriptGhiWasmChkBox.OnCheck.BorderRadius = 12;
            this.scriptGhiWasmChkBox.OnCheck.BorderThickness = 2;
            this.scriptGhiWasmChkBox.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.scriptGhiWasmChkBox.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.scriptGhiWasmChkBox.OnCheck.CheckmarkThickness = 2;
            this.scriptGhiWasmChkBox.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.scriptGhiWasmChkBox.OnDisable.BorderRadius = 12;
            this.scriptGhiWasmChkBox.OnDisable.BorderThickness = 2;
            this.scriptGhiWasmChkBox.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.scriptGhiWasmChkBox.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.scriptGhiWasmChkBox.OnDisable.CheckmarkThickness = 2;
            this.scriptGhiWasmChkBox.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.scriptGhiWasmChkBox.OnHoverChecked.BorderRadius = 12;
            this.scriptGhiWasmChkBox.OnHoverChecked.BorderThickness = 2;
            this.scriptGhiWasmChkBox.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.scriptGhiWasmChkBox.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.scriptGhiWasmChkBox.OnHoverChecked.CheckmarkThickness = 2;
            this.scriptGhiWasmChkBox.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.scriptGhiWasmChkBox.OnHoverUnchecked.BorderRadius = 12;
            this.scriptGhiWasmChkBox.OnHoverUnchecked.BorderThickness = 1;
            this.scriptGhiWasmChkBox.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.scriptGhiWasmChkBox.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.scriptGhiWasmChkBox.OnUncheck.BorderRadius = 12;
            this.scriptGhiWasmChkBox.OnUncheck.BorderThickness = 1;
            this.scriptGhiWasmChkBox.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.scriptGhiWasmChkBox.Size = new System.Drawing.Size(21, 21);
            this.scriptGhiWasmChkBox.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.scriptGhiWasmChkBox.TabIndex = 67;
            this.scriptGhiWasmChkBox.ThreeState = false;
            this.scriptGhiWasmChkBox.ToolTipText = null;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(337, 307);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(189, 17);
            this.label16.TabIndex = 64;
            this.label16.Text = "il2cpp_header_to_ghidra.py";
            // 
            // scriptHeader2GhidraChkBox
            // 
            this.scriptHeader2GhidraChkBox.AllowBindingControlAnimation = true;
            this.scriptHeader2GhidraChkBox.AllowBindingControlColorChanges = false;
            this.scriptHeader2GhidraChkBox.AllowBindingControlLocation = true;
            this.scriptHeader2GhidraChkBox.AllowCheckBoxAnimation = false;
            this.scriptHeader2GhidraChkBox.AllowCheckmarkAnimation = true;
            this.scriptHeader2GhidraChkBox.AllowOnHoverStates = true;
            this.scriptHeader2GhidraChkBox.AutoCheck = true;
            this.scriptHeader2GhidraChkBox.BackColor = System.Drawing.Color.Transparent;
            this.scriptHeader2GhidraChkBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("scriptHeader2GhidraChkBox.BackgroundImage")));
            this.scriptHeader2GhidraChkBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.scriptHeader2GhidraChkBox.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.scriptHeader2GhidraChkBox.BorderRadius = 12;
            this.scriptHeader2GhidraChkBox.Checked = true;
            this.scriptHeader2GhidraChkBox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.scriptHeader2GhidraChkBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.scriptHeader2GhidraChkBox.CustomCheckmarkImage = null;
            this.scriptHeader2GhidraChkBox.Location = new System.Drawing.Point(608, 304);
            this.scriptHeader2GhidraChkBox.MinimumSize = new System.Drawing.Size(17, 17);
            this.scriptHeader2GhidraChkBox.Name = "scriptHeader2GhidraChkBox";
            this.scriptHeader2GhidraChkBox.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.scriptHeader2GhidraChkBox.OnCheck.BorderRadius = 12;
            this.scriptHeader2GhidraChkBox.OnCheck.BorderThickness = 2;
            this.scriptHeader2GhidraChkBox.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.scriptHeader2GhidraChkBox.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.scriptHeader2GhidraChkBox.OnCheck.CheckmarkThickness = 2;
            this.scriptHeader2GhidraChkBox.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.scriptHeader2GhidraChkBox.OnDisable.BorderRadius = 12;
            this.scriptHeader2GhidraChkBox.OnDisable.BorderThickness = 2;
            this.scriptHeader2GhidraChkBox.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.scriptHeader2GhidraChkBox.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.scriptHeader2GhidraChkBox.OnDisable.CheckmarkThickness = 2;
            this.scriptHeader2GhidraChkBox.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.scriptHeader2GhidraChkBox.OnHoverChecked.BorderRadius = 12;
            this.scriptHeader2GhidraChkBox.OnHoverChecked.BorderThickness = 2;
            this.scriptHeader2GhidraChkBox.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.scriptHeader2GhidraChkBox.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.scriptHeader2GhidraChkBox.OnHoverChecked.CheckmarkThickness = 2;
            this.scriptHeader2GhidraChkBox.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.scriptHeader2GhidraChkBox.OnHoverUnchecked.BorderRadius = 12;
            this.scriptHeader2GhidraChkBox.OnHoverUnchecked.BorderThickness = 1;
            this.scriptHeader2GhidraChkBox.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.scriptHeader2GhidraChkBox.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.scriptHeader2GhidraChkBox.OnUncheck.BorderRadius = 12;
            this.scriptHeader2GhidraChkBox.OnUncheck.BorderThickness = 1;
            this.scriptHeader2GhidraChkBox.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.scriptHeader2GhidraChkBox.Size = new System.Drawing.Size(21, 21);
            this.scriptHeader2GhidraChkBox.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.scriptHeader2GhidraChkBox.TabIndex = 67;
            this.scriptHeader2GhidraChkBox.ThreeState = false;
            this.scriptHeader2GhidraChkBox.ToolTipText = null;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(652, 421);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updateChkBox);
            this.Controls.Add(this.winPosCheckBox);
            this.Controls.Add(this.autoSetDirCheck);
            this.Controls.Add(this.scriptHeader2GhidraChkBox);
            this.Controls.Add(this.script6ChkBox);
            this.Controls.Add(this.script5ChkBox);
            this.Controls.Add(this.script4ChkBox);
            this.Controls.Add(this.script3ChkBox);
            this.Controls.Add(this.scriptGhiWasmChkBox);
            this.Controls.Add(this.script2ChkBox);
            this.Controls.Add(this.script1ChkBox);
            this.Controls.Add(this.extDatChkBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.extBinaryChkBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSettings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Ok;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuCheckBox extBinaryChkBox;
        private Bunifu.UI.WinForms.BunifuCheckBox autoSetDirCheck;
        private Bunifu.UI.WinForms.BunifuCheckBox winPosCheckBox;
        private Bunifu.UI.WinForms.BunifuCheckBox updateChkBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Bunifu.UI.WinForms.BunifuCheckBox script1ChkBox;
        private System.Windows.Forms.Label label6;
        private Bunifu.UI.WinForms.BunifuCheckBox script2ChkBox;
        private System.Windows.Forms.Label label8;
        private Bunifu.UI.WinForms.BunifuCheckBox script3ChkBox;
        private System.Windows.Forms.Label label9;
        private Bunifu.UI.WinForms.BunifuCheckBox script4ChkBox;
        private System.Windows.Forms.Label label11;
        private Bunifu.UI.WinForms.BunifuCheckBox script5ChkBox;
        private System.Windows.Forms.Label label12;
        private Bunifu.UI.WinForms.BunifuCheckBox script6ChkBox;
        private System.Windows.Forms.Label label13;
        private Bunifu.UI.WinForms.BunifuCheckBox extDatChkBox;
        private System.Windows.Forms.Label label14;
        private Bunifu.UI.WinForms.BunifuCheckBox scriptGhiWasmChkBox;
        private System.Windows.Forms.Label label16;
        private Bunifu.UI.WinForms.BunifuCheckBox scriptHeader2GhidraChkBox;
    }
}