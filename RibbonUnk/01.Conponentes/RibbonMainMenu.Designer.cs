namespace System.Windows.Forms
{
    partial class RibbonMainMenu
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("inicio");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonMainMenu));
            this.bordeRight = new System.Windows.Forms.Panel();
            this.borderLeft = new System.Windows.Forms.Panel();
            this.borderTop = new System.Windows.Forms.Panel();
            this.borderBottom = new System.Windows.Forms.Panel();
            this.separador1 = new System.Windows.Forms.Panel();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.BtnHideMainMenu = new System.Windows.Forms.RibbonPanel();
            this.main_menu = new System.Windows.Forms.ToolStrip();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TreeviewMenu = new System.Windows.Forms.TreeView();
            this.rbordermenu = new System.Windows.Forms.Panel();
            this.PanelOculto = new System.Windows.Forms.RibbonPanel();
            this.btn_archivo = new System.Windows.Forms.ToolStripButton();
            this.btn_transacciones = new System.Windows.Forms.ToolStripButton();
            this.btn_reportes = new System.Windows.Forms.ToolStripButton();
            this.btn_info_gerencial = new System.Windows.Forms.ToolStripButton();
            this.btn_administrador_sistema = new System.Windows.Forms.ToolStripButton();
            this.PanelHeader.SuspendLayout();
            this.main_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bordeRight
            // 
            this.bordeRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(158)))), ((int)(((byte)(215)))));
            this.bordeRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.bordeRight.Location = new System.Drawing.Point(260, 1);
            this.bordeRight.Name = "bordeRight";
            this.bordeRight.Size = new System.Drawing.Size(1, 523);
            this.bordeRight.TabIndex = 10;
            // 
            // borderLeft
            // 
            this.borderLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(158)))), ((int)(((byte)(215)))));
            this.borderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.borderLeft.Location = new System.Drawing.Point(0, 1);
            this.borderLeft.Name = "borderLeft";
            this.borderLeft.Size = new System.Drawing.Size(1, 523);
            this.borderLeft.TabIndex = 11;
            // 
            // borderTop
            // 
            this.borderTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(158)))), ((int)(((byte)(215)))));
            this.borderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.borderTop.Location = new System.Drawing.Point(0, 0);
            this.borderTop.Name = "borderTop";
            this.borderTop.Size = new System.Drawing.Size(261, 1);
            this.borderTop.TabIndex = 12;
            // 
            // borderBottom
            // 
            this.borderBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(158)))), ((int)(((byte)(215)))));
            this.borderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.borderBottom.Location = new System.Drawing.Point(1, 523);
            this.borderBottom.Name = "borderBottom";
            this.borderBottom.Size = new System.Drawing.Size(259, 1);
            this.borderBottom.TabIndex = 13;
            // 
            // separador1
            // 
            this.separador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(158)))), ((int)(((byte)(215)))));
            this.separador1.Dock = System.Windows.Forms.DockStyle.Top;
            this.separador1.Location = new System.Drawing.Point(1, 27);
            this.separador1.Name = "separador1";
            this.separador1.Size = new System.Drawing.Size(259, 1);
            this.separador1.TabIndex = 14;
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.Transparent;
            this.PanelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelHeader.Controls.Add(this.lblTitulo);
            this.PanelHeader.Controls.Add(this.BtnHideMainMenu);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(1, 1);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(259, 26);
            this.PanelHeader.TabIndex = 9;
            this.PanelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelHeaderPaint);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.lblTitulo.Location = new System.Drawing.Point(4, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(106, 20);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Transacciones";
            // 
            // BtnHideMainMenu
            // 
            this.BtnHideMainMenu.AplicateStyle = false;
            this.BtnHideMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.BtnHideMainMenu.BackGroundColor = System.Drawing.Color.Transparent;
            this.BtnHideMainMenu.BackGroundColorClick = System.Drawing.Color.Transparent;
            this.BtnHideMainMenu.BackGroundColorFocus = System.Drawing.Color.Transparent;
            this.BtnHideMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnHideMainMenu.Border = false;
            this.BtnHideMainMenu.BorderColor = System.Drawing.Color.Transparent;
            this.BtnHideMainMenu.BorderColorFocus = System.Drawing.Color.Transparent;
            this.BtnHideMainMenu.ChangeSkin = false;
            this.BtnHideMainMenu.Checked = false;
            this.BtnHideMainMenu.CheckOnClick = false;
            this.BtnHideMainMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnHideMainMenu.EffectSizeBig = 0;
            this.BtnHideMainMenu.Imagen = null;
            this.BtnHideMainMenu.ImagenOnClick = null;
            this.BtnHideMainMenu.Location = new System.Drawing.Point(229, 0);
            this.BtnHideMainMenu.Name = "BtnHideMainMenu";
            this.BtnHideMainMenu.Size = new System.Drawing.Size(30, 26);
            this.BtnHideMainMenu.TabIndex = 1;
            this.BtnHideMainMenu.Click += new System.EventHandler(this.BtHideMainMenu_Click);
            // 
            // main_menu
            // 
            this.main_menu.AllowMerge = false;
            this.main_menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_menu.AutoSize = false;
            this.main_menu.BackColor = System.Drawing.Color.Transparent;
            this.main_menu.CanOverflow = false;
            this.main_menu.Dock = System.Windows.Forms.DockStyle.None;
            this.main_menu.GripMargin = new System.Windows.Forms.Padding(0);
            this.main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_archivo,
            this.btn_transacciones,
            this.btn_reportes,
            this.btn_info_gerencial,
            this.btn_administrador_sistema});
            this.main_menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.main_menu.Location = new System.Drawing.Point(1, 342);
            this.main_menu.Name = "main_menu";
            this.main_menu.Padding = new System.Windows.Forms.Padding(0);
            this.main_menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.main_menu.Size = new System.Drawing.Size(259, 183);
            this.main_menu.Stretch = true;
            this.main_menu.TabIndex = 17;
            this.main_menu.Text = "toolStrip1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1300844238_folder_horizontal.jpg");
            this.imageList1.Images.SetKeyName(1, "1279381323_chart-up.png");
            this.imageList1.Images.SetKeyName(2, "1279250159_lorry.png");
            this.imageList1.Images.SetKeyName(3, "1279384290_wooden-box.png");
            this.imageList1.Images.SetKeyName(4, "REp.jpg");
            this.imageList1.Images.SetKeyName(5, "despacho.jpg");
            this.imageList1.Images.SetKeyName(6, "1279381323_chart-up.png");
            this.imageList1.Images.SetKeyName(7, "money.jpg");
            this.imageList1.Images.SetKeyName(8, "1279379705_chart_bar.png");
            this.imageList1.Images.SetKeyName(9, "1279380764_report--pencil.png");
            this.imageList1.Images.SetKeyName(10, "descargar.jpg");
            this.imageList1.Images.SetKeyName(11, "1279381269_box-share.png");
            this.imageList1.Images.SetKeyName(12, "1279381368_navigation-270-button.png");
            this.imageList1.Images.SetKeyName(13, "1279381901_user_business_boss.png");
            this.imageList1.Images.SetKeyName(14, "1279382542_layer-resize-actual.png");
            this.imageList1.Images.SetKeyName(15, "1279382893_reports-stack.png");
            this.imageList1.Images.SetKeyName(16, "1279383905_credit-card.png");
            this.imageList1.Images.SetKeyName(17, "edificio.jpg");
            this.imageList1.Images.SetKeyName(18, "1279384168_node-select-child.png");
            this.imageList1.Images.SetKeyName(19, "concepto.jpg");
            this.imageList1.Images.SetKeyName(20, "1279384290_wooden-box.png");
            this.imageList1.Images.SetKeyName(21, "1279384494_users.png");
            this.imageList1.Images.SetKeyName(22, "user.jpg");
            this.imageList1.Images.SetKeyName(23, "Key.png");
            this.imageList1.Images.SetKeyName(24, "1279384831_application_view_detail.png");
            this.imageList1.Images.SetKeyName(25, "1279382711_calendar-task.png");
            this.imageList1.Images.SetKeyName(26, "turno2.png");
            this.imageList1.Images.SetKeyName(27, "1300841066_download.jpg");
            this.imageList1.Images.SetKeyName(28, "1300841050_upload.png");
            this.imageList1.Images.SetKeyName(29, "1300841433_calendar-edit.gif");
            this.imageList1.Images.SetKeyName(30, "1300841727_arrow_skip.jpg");
            this.imageList1.Images.SetKeyName(31, "1300841356_025.png");
            this.imageList1.Images.SetKeyName(32, "1300841768_arrow-move.jpg");
            this.imageList1.Images.SetKeyName(33, "1300839906_arrow_circle_double.jpg");
            this.imageList1.Images.SetKeyName(34, "1300842266_arrow-return-180-left.jpg");
            this.imageList1.Images.SetKeyName(35, "1300842738_195.png");
            this.imageList1.Images.SetKeyName(36, "1300842741_124.jpg");
            this.imageList1.Images.SetKeyName(37, "1300842798_152.jpg");
            this.imageList1.Images.SetKeyName(38, "1300843597_money_dollar.jpg");
            this.imageList1.Images.SetKeyName(39, "1300891255_051.jpg");
            this.imageList1.Images.SetKeyName(40, "1300843283_group.jpg");
            this.imageList1.Images.SetKeyName(41, "1312417948_cart-empty.png");
            this.imageList1.Images.SetKeyName(42, "ventas.bmp");
            this.imageList1.Images.SetKeyName(43, "1279380710_card__pencil.png");
            this.imageList1.Images.SetKeyName(44, "planta.png");
            this.imageList1.Images.SetKeyName(45, "descargar.jpg");
            this.imageList1.Images.SetKeyName(46, "excavator.jpg");
            this.imageList1.Images.SetKeyName(47, "Permisos.png");
            this.imageList1.Images.SetKeyName(48, "ventas4.jpg");
            this.imageList1.Images.SetKeyName(49, "house.jpg");
            this.imageList1.Images.SetKeyName(50, "venta3.jpg");
            this.imageList1.Images.SetKeyName(51, "REporte1.png");
            this.imageList1.Images.SetKeyName(52, "1300842733_069.png");
            // 
            // TreeviewMenu
            // 
            this.TreeviewMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TreeviewMenu.BackColor = System.Drawing.Color.White;
            this.TreeviewMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TreeviewMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeviewMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.TreeviewMenu.ImageIndex = 0;
            this.TreeviewMenu.ImageList = this.imageList1;
            this.TreeviewMenu.Location = new System.Drawing.Point(1, 29);
            this.TreeviewMenu.Margin = new System.Windows.Forms.Padding(6);
            this.TreeviewMenu.Name = "TreeviewMenu";
            treeNode1.Name = "Nodo0";
            treeNode1.Text = "inicio";
            this.TreeviewMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.TreeviewMenu.SelectedImageIndex = 0;
            this.TreeviewMenu.Size = new System.Drawing.Size(300, 311);
            this.TreeviewMenu.TabIndex = 19;
            this.TreeviewMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeviewMenu_AfterSelect);
            this.TreeviewMenu.DoubleClick += new System.EventHandler(this.TreeviewMenu_DoubleClick);
            // 
            // rbordermenu
            // 
            this.rbordermenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbordermenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(158)))), ((int)(((byte)(215)))));
            this.rbordermenu.Location = new System.Drawing.Point(1, 341);
            this.rbordermenu.Name = "rbordermenu";
            this.rbordermenu.Size = new System.Drawing.Size(259, 1);
            this.rbordermenu.TabIndex = 20;
            // 
            // PanelOculto
            // 
            this.PanelOculto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelOculto.AplicateStyle = false;
            this.PanelOculto.BackColor = System.Drawing.Color.Transparent;
            this.PanelOculto.BackGroundColor = System.Drawing.Color.Transparent;
            this.PanelOculto.BackGroundColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(228)))), ((int)(((byte)(251)))));
            this.PanelOculto.BackGroundColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.PanelOculto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelOculto.Border = false;
            this.PanelOculto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(220)))));
            this.PanelOculto.BorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(206)))), ((int)(((byte)(249)))));
            this.PanelOculto.ChangeSkin = false;
            this.PanelOculto.Checked = false;
            this.PanelOculto.CheckOnClick = false;
            this.PanelOculto.EffectSizeBig = 0;
            this.PanelOculto.Imagen = null;
            this.PanelOculto.ImagenOnClick = null;
            this.PanelOculto.Location = new System.Drawing.Point(1, 28);
            this.PanelOculto.Margin = new System.Windows.Forms.Padding(2);
            this.PanelOculto.Name = "PanelOculto";
            this.PanelOculto.Size = new System.Drawing.Size(28, 313);
            this.PanelOculto.TabIndex = 15;
            this.PanelOculto.Visible = false;
            this.PanelOculto.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelOcultoPaint);
            // 
            // btn_archivo
            // 
            this.btn_archivo.AccessibleDescription = "01";
            this.btn_archivo.AutoSize = false;
            this.btn_archivo.BackColor = System.Drawing.Color.White;
            this.btn_archivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_archivo.CheckOnClick = true;
            this.btn_archivo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_archivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btn_archivo.Image = ((System.Drawing.Image)(resources.GetObject("btn_archivo.Image")));
            this.btn_archivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_archivo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_archivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_archivo.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btn_archivo.Name = "btn_archivo";
            this.btn_archivo.Size = new System.Drawing.Size(302, 35);
            this.btn_archivo.Tag = "01";
            this.btn_archivo.Text = "Archivo";
            this.btn_archivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_archivo.Click += new System.EventHandler(this.BtnMainMenu_click);
            // 
            // btn_transacciones
            // 
            this.btn_transacciones.AccessibleDescription = "02";
            this.btn_transacciones.AutoSize = false;
            this.btn_transacciones.BackColor = System.Drawing.Color.White;
            this.btn_transacciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_transacciones.Checked = true;
            this.btn_transacciones.CheckOnClick = true;
            this.btn_transacciones.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btn_transacciones.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transacciones.ForeColor = System.Drawing.Color.Black;
            this.btn_transacciones.Image = ((System.Drawing.Image)(resources.GetObject("btn_transacciones.Image")));
            this.btn_transacciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_transacciones.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_transacciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_transacciones.Margin = new System.Windows.Forms.Padding(0);
            this.btn_transacciones.Name = "btn_transacciones";
            this.btn_transacciones.Size = new System.Drawing.Size(302, 35);
            this.btn_transacciones.Tag = "02";
            this.btn_transacciones.Text = "Transacciones";
            this.btn_transacciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_transacciones.Click += new System.EventHandler(this.BtnMainMenu_click);
            // 
            // btn_reportes
            // 
            this.btn_reportes.AccessibleDescription = "03";
            this.btn_reportes.AutoSize = false;
            this.btn_reportes.BackColor = System.Drawing.Color.White;
            this.btn_reportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_reportes.CheckOnClick = true;
            this.btn_reportes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btn_reportes.Image = ((System.Drawing.Image)(resources.GetObject("btn_reportes.Image")));
            this.btn_reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_reportes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_reportes.Margin = new System.Windows.Forms.Padding(0);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Size = new System.Drawing.Size(302, 35);
            this.btn_reportes.Tag = "03";
            this.btn_reportes.Text = "Reportes";
            this.btn_reportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reportes.Click += new System.EventHandler(this.BtnMainMenu_click);
            // 
            // btn_info_gerencial
            // 
            this.btn_info_gerencial.AccessibleDescription = "04";
            this.btn_info_gerencial.AutoSize = false;
            this.btn_info_gerencial.BackColor = System.Drawing.Color.White;
            this.btn_info_gerencial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_info_gerencial.CheckOnClick = true;
            this.btn_info_gerencial.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_info_gerencial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.btn_info_gerencial.Image = ((System.Drawing.Image)(resources.GetObject("btn_info_gerencial.Image")));
            this.btn_info_gerencial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_info_gerencial.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_info_gerencial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_info_gerencial.Margin = new System.Windows.Forms.Padding(0);
            this.btn_info_gerencial.Name = "btn_info_gerencial";
            this.btn_info_gerencial.Size = new System.Drawing.Size(302, 35);
            this.btn_info_gerencial.Tag = "04";
            this.btn_info_gerencial.Text = "Informacion Gerencial";
            this.btn_info_gerencial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_info_gerencial.Click += new System.EventHandler(this.BtnMainMenu_click);
            // 
            // btn_administrador_sistema
            // 
            this.btn_administrador_sistema.AccessibleDescription = "05";
            this.btn_administrador_sistema.AutoSize = false;
            this.btn_administrador_sistema.BackColor = System.Drawing.Color.White;
            this.btn_administrador_sistema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_administrador_sistema.CheckOnClick = true;
            this.btn_administrador_sistema.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_administrador_sistema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.btn_administrador_sistema.Image = ((System.Drawing.Image)(resources.GetObject("btn_administrador_sistema.Image")));
            this.btn_administrador_sistema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_administrador_sistema.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_administrador_sistema.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_administrador_sistema.Margin = new System.Windows.Forms.Padding(0);
            this.btn_administrador_sistema.Name = "btn_administrador_sistema";
            this.btn_administrador_sistema.Size = new System.Drawing.Size(302, 35);
            this.btn_administrador_sistema.Tag = "05";
            this.btn_administrador_sistema.Text = "Administración del Sitema";
            this.btn_administrador_sistema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_administrador_sistema.Click += new System.EventHandler(this.BtnMainMenu_click);
            // 
            // RibbonMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.main_menu);
            this.Controls.Add(this.rbordermenu);
            this.Controls.Add(this.separador1);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.borderBottom);
            this.Controls.Add(this.borderLeft);
            this.Controls.Add(this.bordeRight);
            this.Controls.Add(this.borderTop);
            this.Controls.Add(this.TreeviewMenu);
            this.Controls.Add(this.PanelOculto);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(300, 1500);
            this.Name = "RibbonMainMenu";
            this.Size = new System.Drawing.Size(261, 524);
            this.Load += new System.EventHandler(this.RibbonMainMenu_Load);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.main_menu.ResumeLayout(false);
            this.main_menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel PanelHeader;
        public System.Windows.Forms.RibbonPanel BtnHideMainMenu;
        private Panel bordeRight;
        private Panel borderLeft;
        private Panel borderTop;
        private Panel borderBottom;
        private Panel separador1;
        private RibbonPanel PanelOculto;
        internal ToolStrip main_menu;
        public ToolStripButton btn_archivo;
        public ToolStripButton btn_transacciones;
        public ToolStripButton btn_reportes;
        public ToolStripButton btn_info_gerencial;
        public ToolStripButton btn_administrador_sistema;
        private ImageList imageList1;
        private Label lblTitulo;
        public TreeView TreeviewMenu;
        private Panel rbordermenu;
    }
}
