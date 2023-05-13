namespace EnterpriseUpdater.Forms.Login
{
    partial class LoginControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_contraseña_login = new EnterpriseUpdater.Controles.DbTextBox();
            this.txt_usuario_login = new EnterpriseUpdater.Controles.DbTextBox();
            this.chk_reocrdar_contraseña = new System.Windows.Forms.CheckBox();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::EnterpriseUpdater.Properties.Resources.imgLoginMain1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txt_contraseña_login);
            this.panel1.Controls.Add(this.txt_usuario_login);
            this.panel1.Controls.Add(this.chk_reocrdar_contraseña);
            this.panel1.Controls.Add(this.btn_ingresar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 627);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(148)))), ((int)(((byte)(245)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 592);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 35);
            this.panel2.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(78, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Copyright 2023 ® sistema.com";
            // 
            // txt_contraseña_login
            // 
            this.txt_contraseña_login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contraseña_login.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_contraseña_login.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_contraseña_login.Location = new System.Drawing.Point(101, 398);
            this.txt_contraseña_login.Name = "txt_contraseña_login";
            this.txt_contraseña_login.PasswordChar = '*';
            this.txt_contraseña_login.Size = new System.Drawing.Size(202, 20);
            this.txt_contraseña_login.TabIndex = 1;
            // 
            // txt_usuario_login
            // 
            this.txt_usuario_login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usuario_login.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_usuario_login.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_usuario_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_usuario_login.Location = new System.Drawing.Point(101, 325);
            this.txt_usuario_login.Name = "txt_usuario_login";
            this.txt_usuario_login.Size = new System.Drawing.Size(202, 20);
            this.txt_usuario_login.TabIndex = 0;
            // 
            // chk_reocrdar_contraseña
            // 
            this.chk_reocrdar_contraseña.AutoSize = true;
            this.chk_reocrdar_contraseña.BackColor = System.Drawing.Color.Transparent;
            this.chk_reocrdar_contraseña.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chk_reocrdar_contraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chk_reocrdar_contraseña.Location = new System.Drawing.Point(67, 434);
            this.chk_reocrdar_contraseña.Name = "chk_reocrdar_contraseña";
            this.chk_reocrdar_contraseña.Size = new System.Drawing.Size(225, 24);
            this.chk_reocrdar_contraseña.TabIndex = 6;
            this.chk_reocrdar_contraseña.Text = "Recordar mi inicio de sesión?";
            this.chk_reocrdar_contraseña.UseVisualStyleBackColor = false;
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(148)))), ((int)(((byte)(245)))));
            this.btn_ingresar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ingresar.ForeColor = System.Drawing.Color.White;
            this.btn_ingresar.Location = new System.Drawing.Point(91, 479);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(200, 43);
            this.btn_ingresar.TabIndex = 2;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = false;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(62, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(62, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(368, 627);
            this.MinimumSize = new System.Drawing.Size(368, 627);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(368, 627);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Controles.DbTextBox txt_contraseña_login;
        private CheckBox chk_reocrdar_contraseña;
        private Button btn_ingresar;
        private Label label1;
        private Label label2;
        public Controles.DbTextBox txt_usuario_login;
        private Panel panel2;
        private Label label4;
    }
}
