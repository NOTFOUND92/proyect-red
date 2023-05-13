namespace System.Windows.Forms
{
    partial class RibbonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonForm));
            this.rBorderLeft = new System.Windows.Forms.Panel();
            this.rBorderBottom = new System.Windows.Forms.Panel();
            this.rBorderRight = new System.Windows.Forms.Panel();
            this.rTitulo = new System.Windows.Forms.Label();
            this.rControlBox = new System.Windows.Forms.RibbonPanel();
            this.MenuButtonsLeft = new System.Windows.Forms.Panel();
            this.rSeparator = new System.Windows.Forms.Panel();
            this.rPictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.MenuButtosRight = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.RibbonPanel();
            this.lbl_minimize = new System.Windows.Forms.Label();
            this.btnMaximize = new System.Windows.Forms.RibbonPanel();
            this.lbl_maximize = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.RibbonPanel();
            this.lblclose = new System.Windows.Forms.Label();
            this.rBorderTop = new System.Windows.Forms.Panel();
            this.rControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rPictureBoxIcon)).BeginInit();
            this.btnMinimize.SuspendLayout();
            this.btnMaximize.SuspendLayout();
            this.btnClose.SuspendLayout();
            this.SuspendLayout();
            // 
            // rBorderLeft
            // 
            this.rBorderLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(112)))), ((int)(((byte)(181)))));
            this.rBorderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.rBorderLeft.Location = new System.Drawing.Point(0, 0);
            this.rBorderLeft.Margin = new System.Windows.Forms.Padding(4);
            this.rBorderLeft.Name = "rBorderLeft";
            this.rBorderLeft.Size = new System.Drawing.Size(1, 604);
            this.rBorderLeft.TabIndex = 4;
            // 
            // rBorderBottom
            // 
            this.rBorderBottom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rBorderBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(112)))), ((int)(((byte)(181)))));
            this.rBorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rBorderBottom.Location = new System.Drawing.Point(1, 603);
            this.rBorderBottom.Margin = new System.Windows.Forms.Padding(4);
            this.rBorderBottom.Name = "rBorderBottom";
            this.rBorderBottom.Size = new System.Drawing.Size(778, 1);
            this.rBorderBottom.TabIndex = 5;
            // 
            // rBorderRight
            // 
            this.rBorderRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(112)))), ((int)(((byte)(181)))));
            this.rBorderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.rBorderRight.Location = new System.Drawing.Point(778, 0);
            this.rBorderRight.Margin = new System.Windows.Forms.Padding(4);
            this.rBorderRight.Name = "rBorderRight";
            this.rBorderRight.Size = new System.Drawing.Size(1, 603);
            this.rBorderRight.TabIndex = 6;
            // 
            // rTitulo
            // 
            this.rTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rTitulo.BackColor = System.Drawing.Color.Transparent;
            this.rTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.rTitulo.Location = new System.Drawing.Point(115, 5);
            this.rTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rTitulo.Name = "rTitulo";
            this.rTitulo.Size = new System.Drawing.Size(386, 21);
            this.rTitulo.TabIndex = 6;
            this.rTitulo.Text = "Ribbonform";
            this.rTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rTitulo.DoubleClick += new System.EventHandler(this.BtnmaximizeClick);
            this.rTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelControlBoxMouseMove);
            // 
            // rControlBox
            // 
            this.rControlBox.AplicateStyle = true;
            this.rControlBox.BackGroundColor = System.Drawing.Color.Empty;
            this.rControlBox.BackGroundColorClick = System.Drawing.Color.Empty;
            this.rControlBox.BackGroundColorFocus = System.Drawing.Color.Empty;
            this.rControlBox.Border = false;
            this.rControlBox.BorderColor = System.Drawing.Color.Empty;
            this.rControlBox.BorderColorFocus = System.Drawing.Color.Empty;
            this.rControlBox.ChangeSkin = true;
            this.rControlBox.Checked = false;
            this.rControlBox.CheckOnClick = false;
            this.rControlBox.Controls.Add(this.MenuButtonsLeft);
            this.rControlBox.Controls.Add(this.rSeparator);
            this.rControlBox.Controls.Add(this.rPictureBoxIcon);
            this.rControlBox.Controls.Add(this.MenuButtosRight);
            this.rControlBox.Controls.Add(this.rTitulo);
            this.rControlBox.Controls.Add(this.btnMinimize);
            this.rControlBox.Controls.Add(this.btnMaximize);
            this.rControlBox.Controls.Add(this.btnClose);
            this.rControlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.rControlBox.EffectSizeBig = 0;
            this.rControlBox.Imagen = null;
            this.rControlBox.ImagenOnClick = null;
            this.rControlBox.Location = new System.Drawing.Point(1, 1);
            this.rControlBox.Name = "rControlBox";
            this.rControlBox.Size = new System.Drawing.Size(777, 32);
            this.rControlBox.TabIndex = 9;
            this.rControlBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelControlBoxMouseMove);
            // 
            // MenuButtonsLeft
            // 
            this.MenuButtonsLeft.BackColor = System.Drawing.Color.Transparent;
            this.MenuButtonsLeft.Location = new System.Drawing.Point(40, 0);
            this.MenuButtonsLeft.Margin = new System.Windows.Forms.Padding(4);
            this.MenuButtonsLeft.Name = "MenuButtonsLeft";
            this.MenuButtonsLeft.Size = new System.Drawing.Size(67, 32);
            this.MenuButtonsLeft.TabIndex = 15;
            this.MenuButtonsLeft.Visible = false;
            this.MenuButtonsLeft.DoubleClick += new System.EventHandler(this.BtnmaximizeClick);
            this.MenuButtonsLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelControlBoxMouseMove);
            // 
            // rSeparator
            // 
            this.rSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.rSeparator.Location = new System.Drawing.Point(31, 7);
            this.rSeparator.Margin = new System.Windows.Forms.Padding(4);
            this.rSeparator.Name = "rSeparator";
            this.rSeparator.Size = new System.Drawing.Size(1, 18);
            this.rSeparator.TabIndex = 13;
            // 
            // rPictureBoxIcon
            // 
            this.rPictureBoxIcon.BackColor = System.Drawing.Color.Transparent;
            this.rPictureBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("rPictureBoxIcon.Image")));
            this.rPictureBoxIcon.Location = new System.Drawing.Point(4, 6);
            this.rPictureBoxIcon.Margin = new System.Windows.Forms.Padding(4);
            this.rPictureBoxIcon.Name = "rPictureBoxIcon";
            this.rPictureBoxIcon.Size = new System.Drawing.Size(21, 20);
            this.rPictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rPictureBoxIcon.TabIndex = 14;
            this.rPictureBoxIcon.TabStop = false;
            // 
            // MenuButtosRight
            // 
            this.MenuButtosRight.BackColor = System.Drawing.Color.Transparent;
            this.MenuButtosRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.MenuButtosRight.Location = new System.Drawing.Point(532, 0);
            this.MenuButtosRight.Margin = new System.Windows.Forms.Padding(4);
            this.MenuButtosRight.Name = "MenuButtosRight";
            this.MenuButtosRight.Size = new System.Drawing.Size(67, 32);
            this.MenuButtosRight.TabIndex = 9;
            this.MenuButtosRight.Visible = false;
            this.MenuButtosRight.DoubleClick += new System.EventHandler(this.BtnmaximizeClick);
            this.MenuButtosRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelControlBoxMouseMove);
            // 
            // btnMinimize
            // 
            this.btnMinimize.AplicateStyle = true;
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackGroundColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackGroundColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(203)))));
            this.btnMinimize.BackGroundColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimize.Border = false;
            this.btnMinimize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnMinimize.BorderColorFocus = System.Drawing.Color.Transparent;
            this.btnMinimize.ChangeSkin = false;
            this.btnMinimize.Checked = false;
            this.btnMinimize.CheckOnClick = false;
            this.btnMinimize.Controls.Add(this.lbl_minimize);
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.EffectSizeBig = 0;
            this.btnMinimize.ForeColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.Imagen = null;
            this.btnMinimize.ImagenOnClick = null;
            this.btnMinimize.Location = new System.Drawing.Point(599, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(59, 32);
            this.btnMinimize.TabIndex = 12;
            this.btnMinimize.Click += new System.EventHandler(this.BtnminimizeClick);
            this.btnMinimize.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnControlBoxPaint);
            // 
            // lbl_minimize
            // 
            this.lbl_minimize.AutoSize = true;
            this.lbl_minimize.BackColor = System.Drawing.Color.Transparent;
            this.lbl_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_minimize.ForeColor = System.Drawing.Color.Black;
            this.lbl_minimize.Location = new System.Drawing.Point(18, 4);
            this.lbl_minimize.Name = "lbl_minimize";
            this.lbl_minimize.Size = new System.Drawing.Size(26, 25);
            this.lbl_minimize.TabIndex = 10;
            this.lbl_minimize.Text = "─";
            this.lbl_minimize.Click += new System.EventHandler(this.BtnminimizeClick);
            // 
            // btnMaximize
            // 
            this.btnMaximize.AplicateStyle = true;
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.BackGroundColor = System.Drawing.Color.Transparent;
            this.btnMaximize.BackGroundColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(203)))));
            this.btnMaximize.BackGroundColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaximize.Border = false;
            this.btnMaximize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnMaximize.BorderColorFocus = System.Drawing.Color.Transparent;
            this.btnMaximize.ChangeSkin = false;
            this.btnMaximize.Checked = false;
            this.btnMaximize.CheckOnClick = false;
            this.btnMaximize.Controls.Add(this.lbl_maximize);
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.EffectSizeBig = 0;
            this.btnMaximize.Imagen = null;
            this.btnMaximize.ImagenOnClick = null;
            this.btnMaximize.Location = new System.Drawing.Point(658, 0);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(59, 32);
            this.btnMaximize.TabIndex = 11;
            this.btnMaximize.Click += new System.EventHandler(this.BtnmaximizeClick);
            // 
            // lbl_maximize
            // 
            this.lbl_maximize.AutoSize = true;
            this.lbl_maximize.BackColor = System.Drawing.Color.Transparent;
            this.lbl_maximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lbl_maximize.ForeColor = System.Drawing.Color.Black;
            this.lbl_maximize.Location = new System.Drawing.Point(13, -4);
            this.lbl_maximize.Name = "lbl_maximize";
            this.lbl_maximize.Size = new System.Drawing.Size(33, 33);
            this.lbl_maximize.TabIndex = 11;
            this.lbl_maximize.Text = "□";
            this.lbl_maximize.Click += new System.EventHandler(this.BtnmaximizeClick);
            // 
            // btnClose
            // 
            this.btnClose.AplicateStyle = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackGroundColor = System.Drawing.Color.Transparent;
            this.btnClose.BackGroundColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(112)))), ((int)(((byte)(122)))));
            this.btnClose.BackGroundColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Border = false;
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnClose.BorderColorFocus = System.Drawing.Color.Transparent;
            this.btnClose.ChangeSkin = false;
            this.btnClose.Checked = false;
            this.btnClose.CheckOnClick = false;
            this.btnClose.Controls.Add(this.lblclose);
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.EffectSizeBig = 0;
            this.btnClose.Imagen = null;
            this.btnClose.ImagenOnClick = null;
            this.btnClose.Location = new System.Drawing.Point(717, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 32);
            this.btnClose.TabIndex = 10;
            this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
            // 
            // lblclose
            // 
            this.lblclose.AutoSize = true;
            this.lblclose.BackColor = System.Drawing.Color.Transparent;
            this.lblclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblclose.ForeColor = System.Drawing.Color.Black;
            this.lblclose.Location = new System.Drawing.Point(20, 6);
            this.lblclose.Name = "lblclose";
            this.lblclose.Size = new System.Drawing.Size(20, 20);
            this.lblclose.TabIndex = 6;
            this.lblclose.Text = "X";
            this.lblclose.Click += new System.EventHandler(this.BtnCloseClick);
            this.lblclose.MouseLeave += new System.EventHandler(this.LblcloseMouseLeave);
            this.lblclose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelControlBoxMouseMove);
            // 
            // rBorderTop
            // 
            this.rBorderTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rBorderTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(112)))), ((int)(((byte)(181)))));
            this.rBorderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.rBorderTop.Location = new System.Drawing.Point(1, 0);
            this.rBorderTop.Margin = new System.Windows.Forms.Padding(4);
            this.rBorderTop.Name = "rBorderTop";
            this.rBorderTop.Size = new System.Drawing.Size(777, 1);
            this.rBorderTop.TabIndex = 7;
            // 
            // RibbonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 604);
            this.Controls.Add(this.rControlBox);
            this.Controls.Add(this.rBorderTop);
            this.Controls.Add(this.rBorderRight);
            this.Controls.Add(this.rBorderBottom);
            this.Controls.Add(this.rBorderLeft);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RibbonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RibbonForm";
            this.Load += new System.EventHandler(this.RibbonFormLoad);
            this.Click += new System.EventHandler(this.RibbonFormClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RibbonForm_KeyDown);
            this.rControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rPictureBoxIcon)).EndInit();
            this.btnMinimize.ResumeLayout(false);
            this.btnMinimize.PerformLayout();
            this.btnMaximize.ResumeLayout(false);
            this.btnMaximize.PerformLayout();
            this.btnClose.ResumeLayout(false);
            this.btnClose.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel rBorderLeft;
        private System.Windows.Forms.Panel rBorderBottom;
        private System.Windows.Forms.Panel rBorderRight;
        private Label rTitulo;
        private RibbonPanel rControlBox;
        public Panel MenuButtonsLeft;
        private Panel rSeparator;
        private PictureBox rPictureBoxIcon;
        public Panel MenuButtosRight;
        private RibbonPanel btnMinimize;
        private RibbonPanel btnMaximize;
        private RibbonPanel btnClose;
        private Label lblclose;
        private Panel rBorderTop;
        private Label lbl_minimize;
        private Label lbl_maximize;
    }
}