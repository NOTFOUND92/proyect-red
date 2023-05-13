namespace EnterpriseUpdater.Forms.Login
{
    partial class CreateAcount
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_contraseña_registrar = new EnterpriseUpdater.Controles.DbTextBox();
            this.txt_usuario_registrar = new EnterpriseUpdater.Controles.DbTextBox();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pbx_img_registrar = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_img_registrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.panel2.Controls.Add(this.txt_contraseña_registrar);
            this.panel2.Controls.Add(this.txt_usuario_registrar);
            this.panel2.Controls.Add(this.btn_registrar);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pbx_img_registrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 547);
            this.panel2.TabIndex = 9;
            // 
            // txt_contraseña_registrar
            // 
            this.txt_contraseña_registrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_contraseña_registrar.Location = new System.Drawing.Point(44, 387);
            this.txt_contraseña_registrar.Name = "txt_contraseña_registrar";
            this.txt_contraseña_registrar.PasswordChar = '*';
            this.txt_contraseña_registrar.Size = new System.Drawing.Size(250, 27);
            this.txt_contraseña_registrar.TabIndex = 1;
            // 
            // txt_usuario_registrar
            // 
            this.txt_usuario_registrar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_usuario_registrar.Location = new System.Drawing.Point(44, 329);
            this.txt_usuario_registrar.Name = "txt_usuario_registrar";
            this.txt_usuario_registrar.Size = new System.Drawing.Size(250, 27);
            this.txt_usuario_registrar.TabIndex = 0;
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(148)))), ((int)(((byte)(245)))));
            this.btn_registrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_registrar.ForeColor = System.Drawing.Color.White;
            this.btn_registrar.Location = new System.Drawing.Point(64, 440);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(200, 43);
            this.btn_registrar.TabIndex = 2;
            this.btn_registrar.Text = "Registrarme";
            this.btn_registrar.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(41, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(40, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Contraseña";
            // 
            // pbx_img_registrar
            // 
            this.pbx_img_registrar.Image = global::EnterpriseUpdater.Properties.Resources.userMujer;
            this.pbx_img_registrar.Location = new System.Drawing.Point(18, 15);
            this.pbx_img_registrar.Name = "pbx_img_registrar";
            this.pbx_img_registrar.Size = new System.Drawing.Size(294, 286);
            this.pbx_img_registrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_img_registrar.TabIndex = 0;
            this.pbx_img_registrar.TabStop = false;
            // 
            // CreateAcount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(331, 547);
            this.MinimumSize = new System.Drawing.Size(331, 547);
            this.Name = "CreateAcount";
            this.Size = new System.Drawing.Size(331, 547);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_img_registrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Controles.DbTextBox txt_contraseña_registrar;
        private Controles.DbTextBox txt_usuario_registrar;
        private Button btn_registrar;
        private Label label5;
        private Label label6;
        private PictureBox pbx_img_registrar;
    }
}
