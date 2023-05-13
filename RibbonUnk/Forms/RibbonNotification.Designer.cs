namespace System.Windows.Forms
{
    partial class RibbonNotification
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.PbxImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuButtosRight
            // 
            this.MenuButtosRight.Location = new System.Drawing.Point(134, 0);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(151, 193);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(68, 16);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_descripcion.Location = new System.Drawing.Point(157, 48);
            this.lbl_descripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(213, 134);
            this.lbl_descripcion.TabIndex = 13;
            this.lbl_descripcion.Text = "Error!\r\n\r\n\r\n";
            this.lbl_descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PbxImagen
            // 
            this.PbxImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PbxImagen.Location = new System.Drawing.Point(11, 48);
            this.PbxImagen.Margin = new System.Windows.Forms.Padding(4);
            this.PbxImagen.Name = "PbxImagen";
            this.PbxImagen.Size = new System.Drawing.Size(128, 134);
            this.PbxImagen.TabIndex = 12;
            this.PbxImagen.TabStop = false;
            // 
            // RibbonNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColorMaximize = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(121)))), ((int)(((byte)(202)))));
            this.BackColorMaximizeClick = System.Drawing.Color.White;
            this.BackColorMinimize = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(121)))), ((int)(((byte)(202)))));
            this.ButtonsOption = false;
            this.ClientSize = new System.Drawing.Size(381, 217);
            this.ColorRibbon = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(121)))), ((int)(((byte)(202)))));
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.PbxImagen);
            this.ForeColorControlBox = System.Drawing.Color.White;
            this.ForeColortituloText = System.Drawing.Color.White;
            this.Name = "RibbonNotification";
            this.Text = "RibbonNotification";
            this.Controls.SetChildIndex(this.PbxImagen, 0);
            this.Controls.SetChildIndex(this.lbl_descripcion, 0);
            this.Controls.SetChildIndex(this.linkLabel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel linkLabel1;
        private Label lbl_descripcion;
        private PictureBox PbxImagen;
    }
}