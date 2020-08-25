namespace Il2CppDumper
{
    partial class FormDump
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDump));
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dumpNoteLbl = new System.Windows.Forms.Label();
            this.dumpAdrTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Ok = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.ImageActive = null;
            this.closeBtn.Location = new System.Drawing.Point(446, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(29, 33);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 20;
            this.closeBtn.TabStop = false;
            this.closeBtn.Zoom = 10;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.White;
            this.TitleLbl.Location = new System.Drawing.Point(9, 9);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(102, 16);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "Il2CppDumper";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.TitleLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 33);
            this.panel1.TabIndex = 17;
            // 
            // dumpNoteLbl
            // 
            this.dumpNoteLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dumpNoteLbl.ForeColor = System.Drawing.Color.White;
            this.dumpNoteLbl.Location = new System.Drawing.Point(36, 48);
            this.dumpNoteLbl.Name = "dumpNoteLbl";
            this.dumpNoteLbl.Size = new System.Drawing.Size(411, 51);
            this.dumpNoteLbl.TabIndex = 25;
            this.dumpNoteLbl.Text = "Detected this may be a dump file. If not, it must be protected.\r\n\r\nInput dump add" +
    "ress or input 0 to force continue:";
            this.dumpNoteLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dumpAdrTxtBox
            // 
            this.dumpAdrTxtBox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            this.dumpAdrTxtBox.BorderColorIdle = System.Drawing.Color.DodgerBlue;
            this.dumpAdrTxtBox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            this.dumpAdrTxtBox.BorderThickness = 1;
            this.dumpAdrTxtBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.dumpAdrTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dumpAdrTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dumpAdrTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            this.dumpAdrTxtBox.isPassword = false;
            this.dumpAdrTxtBox.Location = new System.Drawing.Point(91, 107);
            this.dumpAdrTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.dumpAdrTxtBox.MaxLength = 32767;
            this.dumpAdrTxtBox.Name = "dumpAdrTxtBox";
            this.dumpAdrTxtBox.Size = new System.Drawing.Size(298, 35);
            this.dumpAdrTxtBox.TabIndex = 26;
            this.dumpAdrTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Ok
            // 
            this.Ok.Active = false;
            this.Ok.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(143)))), ((int)(((byte)(205)))));
            this.Ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(143)))), ((int)(((byte)(205)))));
            this.Ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ok.BorderRadius = 0;
            this.Ok.ButtonText = "OK";
            this.Ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ok.DisabledColor = System.Drawing.Color.Gray;
            this.Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Ok.Iconcolor = System.Drawing.Color.Transparent;
            this.Ok.Iconimage = null;
            this.Ok.Iconimage_right = null;
            this.Ok.Iconimage_right_Selected = null;
            this.Ok.Iconimage_Selected = null;
            this.Ok.IconMarginLeft = 0;
            this.Ok.IconMarginRight = 0;
            this.Ok.IconRightVisible = true;
            this.Ok.IconRightZoom = 0D;
            this.Ok.IconVisible = false;
            this.Ok.IconZoom = 90D;
            this.Ok.IsTab = false;
            this.Ok.Location = new System.Drawing.Point(202, 162);
            this.Ok.Name = "Ok";
            this.Ok.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(143)))), ((int)(((byte)(205)))));
            this.Ok.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            this.Ok.OnHoverTextColor = System.Drawing.Color.White;
            this.Ok.selected = false;
            this.Ok.Size = new System.Drawing.Size(70, 35);
            this.Ok.TabIndex = 27;
            this.Ok.Text = "OK";
            this.Ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Ok.Textcolor = System.Drawing.Color.White;
            this.Ok.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 186);
            this.panel2.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(474, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 186);
            this.panel3.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(1, 218);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(473, 1);
            this.panel4.TabIndex = 30;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // FormDump
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(475, 219);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.dumpAdrTxtBox);
            this.Controls.Add(this.dumpNoteLbl);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDump";
            this.Text = "FormDump";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox dumpAdrTxtBox;
        private Bunifu.Framework.UI.BunifuFlatButton Ok;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        internal System.Windows.Forms.Label dumpNoteLbl;
    }
}