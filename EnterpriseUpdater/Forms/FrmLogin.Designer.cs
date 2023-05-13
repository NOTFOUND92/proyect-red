namespace EnterpriseUpdater.Forms
{
    partial class FrmLogin
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
            this.Contenedor = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnl_clik_Acount = new System.Windows.Forms.Panel();
            this.pnl_deslis_sign_up = new System.Windows.Forms.Panel();
            this.lbl_sign_up = new System.Windows.Forms.Label();
            this.pnl_click_login = new System.Windows.Forms.Panel();
            this.pnl_deslis_login = new System.Windows.Forms.Panel();
            this.lbl_login = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Contenedor)).BeginInit();
            this.Contenedor.Panel2.SuspendLayout();
            this.Contenedor.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnl_clik_Acount.SuspendLayout();
            this.pnl_click_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(148)))), ((int)(((byte)(245)))));
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.IsSplitterFixed = true;
            this.Contenedor.Location = new System.Drawing.Point(0, 0);
            this.Contenedor.Name = "Contenedor";
            // 
            // Contenedor.Panel1
            // 
            this.Contenedor.Panel1.BackColor = System.Drawing.Color.Transparent;
            // 
            // Contenedor.Panel2
            // 
            this.Contenedor.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(148)))), ((int)(((byte)(245)))));
            this.Contenedor.Panel2.Controls.Add(this.panel3);
            this.Contenedor.Size = new System.Drawing.Size(1096, 627);
            this.Contenedor.SplitterDistance = 727;
            this.Contenedor.SplitterWidth = 1;
            this.Contenedor.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(148)))), ((int)(((byte)(245)))));
            this.panel3.Controls.Add(this.pnl_clik_Acount);
            this.panel3.Controls.Add(this.pnl_click_login);
            this.panel3.Location = new System.Drawing.Point(80, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 42);
            this.panel3.TabIndex = 12;
            // 
            // pnl_clik_Acount
            // 
            this.pnl_clik_Acount.BackColor = System.Drawing.Color.Transparent;
            this.pnl_clik_Acount.Controls.Add(this.pnl_deslis_sign_up);
            this.pnl_clik_Acount.Controls.Add(this.lbl_sign_up);
            this.pnl_clik_Acount.Location = new System.Drawing.Point(85, 0);
            this.pnl_clik_Acount.Name = "pnl_clik_Acount";
            this.pnl_clik_Acount.Size = new System.Drawing.Size(125, 41);
            this.pnl_clik_Acount.TabIndex = 14;
            this.pnl_clik_Acount.Click += new System.EventHandler(this.lbl_sign_up_Click);
            // 
            // pnl_deslis_sign_up
            // 
            this.pnl_deslis_sign_up.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.pnl_deslis_sign_up.Location = new System.Drawing.Point(12, 29);
            this.pnl_deslis_sign_up.Name = "pnl_deslis_sign_up";
            this.pnl_deslis_sign_up.Size = new System.Drawing.Size(102, 8);
            this.pnl_deslis_sign_up.TabIndex = 12;
            this.pnl_deslis_sign_up.Visible = false;
            // 
            // lbl_sign_up
            // 
            this.lbl_sign_up.AutoSize = true;
            this.lbl_sign_up.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sign_up.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_sign_up.ForeColor = System.Drawing.Color.White;
            this.lbl_sign_up.Location = new System.Drawing.Point(15, 5);
            this.lbl_sign_up.Name = "lbl_sign_up";
            this.lbl_sign_up.Size = new System.Drawing.Size(99, 20);
            this.lbl_sign_up.TabIndex = 10;
            this.lbl_sign_up.Text = "Crear Cuenta";
            this.lbl_sign_up.Click += new System.EventHandler(this.lbl_sign_up_Click);
            // 
            // pnl_click_login
            // 
            this.pnl_click_login.BackColor = System.Drawing.Color.Transparent;
            this.pnl_click_login.Controls.Add(this.pnl_deslis_login);
            this.pnl_click_login.Controls.Add(this.lbl_login);
            this.pnl_click_login.Location = new System.Drawing.Point(1, 0);
            this.pnl_click_login.Name = "pnl_click_login";
            this.pnl_click_login.Size = new System.Drawing.Size(85, 41);
            this.pnl_click_login.TabIndex = 13;
            this.pnl_click_login.Click += new System.EventHandler(this.lbl_login_Click);
            // 
            // pnl_deslis_login
            // 
            this.pnl_deslis_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(251)))));
            this.pnl_deslis_login.Location = new System.Drawing.Point(11, 29);
            this.pnl_deslis_login.Name = "pnl_deslis_login";
            this.pnl_deslis_login.Size = new System.Drawing.Size(67, 8);
            this.pnl_deslis_login.TabIndex = 12;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.BackColor = System.Drawing.Color.Transparent;
            this.lbl_login.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_login.ForeColor = System.Drawing.Color.White;
            this.lbl_login.Location = new System.Drawing.Point(21, 5);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(48, 20);
            this.lbl_login.TabIndex = 9;
            this.lbl_login.Text = "Login";
            this.lbl_login.Click += new System.EventHandler(this.lbl_login_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 627);
            this.Controls.Add(this.Contenedor);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.Contenedor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Contenedor)).EndInit();
            this.Contenedor.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnl_clik_Acount.ResumeLayout(false);
            this.pnl_clik_Acount.PerformLayout();
            this.pnl_click_login.ResumeLayout(false);
            this.pnl_click_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private SplitContainer Contenedor;
        private Label lbl_sign_up;
        private Label lbl_login;
        private Panel panel3;
        private Panel pnl_deslis_sign_up;
        private Panel pnl_deslis_login;
        private Panel pnl_clik_Acount;
        private Panel pnl_click_login;
    }
}