namespace Il2CppDumper
{
    partial class FormOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOptions));
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
            this.extBinaryChkBox = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.autoSetDirCheck = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.winPosCheckBox = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.updateChkBox = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.closeBtn.Location = new System.Drawing.Point(303, 0);
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
            this.Panel.Size = new System.Drawing.Size(332, 33);
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
            this.label10.Location = new System.Drawing.Point(18, 145);
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
            this.label7.Location = new System.Drawing.Point(18, 107);
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
            this.panel4.Size = new System.Drawing.Size(1, 292);
            this.panel4.TabIndex = 59;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 292);
            this.panel5.TabIndex = 29;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(1, 324);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(331, 1);
            this.panel7.TabIndex = 61;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(330, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 1);
            this.panel6.TabIndex = 60;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(331, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 291);
            this.panel2.TabIndex = 62;
            // 
            // Ok
            // 
            this.Ok.AllowToggling = false;
            this.Ok.AnimationSpeed = 200;
            this.Ok.AutoGenerateColors = false;
            this.Ok.AutoSizeLeftIcon = true;
            this.Ok.AutoSizeRightIcon = true;
            this.Ok.BackColor = System.Drawing.Color.Transparent;
            this.Ok.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(143)))), ((int)(((byte)(205)))));
            this.Ok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ok.BackgroundImage")));
            this.Ok.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Ok.ButtonText = "OK";
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
            this.Ok.Location = new System.Drawing.Point(126, 268);
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
            this.Ok.Size = new System.Drawing.Size(87, 39);
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
            this.label1.Location = new System.Drawing.Point(18, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 64;
            this.label1.Text = "Extract binary file:";
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
            this.extBinaryChkBox.Checked = true;
            this.extBinaryChkBox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.extBinaryChkBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.extBinaryChkBox.CustomCheckmarkImage = null;
            this.extBinaryChkBox.Location = new System.Drawing.Point(289, 212);
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
            this.autoSetDirCheck.Location = new System.Drawing.Point(289, 141);
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
            this.winPosCheckBox.Checked = true;
            this.winPosCheckBox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.winPosCheckBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.winPosCheckBox.CustomCheckmarkImage = null;
            this.winPosCheckBox.Location = new System.Drawing.Point(289, 103);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 71;
            this.label3.Text = "File auto dumping:";
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
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(332, 325);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updateChkBox);
            this.Controls.Add(this.winPosCheckBox);
            this.Controls.Add(this.autoSetDirCheck);
            this.Controls.Add(this.extBinaryChkBox);
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
            this.Name = "FormOptions";
            this.Text = "FormOptions";
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
    }
}