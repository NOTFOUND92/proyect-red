using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace System.Windows.Forms
{
    public partial class RibbonMainMenu : UserControl, IRibbonDesign
    {
        bool cHide;
        string sKey1;
        string sKey2;
        string sKeyName;
        string sImagen;
        string sFuncion;
        Int32 ICont2 = 0;
        string[,] ArrayMenu;
        ColorTable ColorTable;

        [Category("Ribbon Design")]
        public bool ChangeSkin { get; set; }
        [Category("Ribbon Design")]
        private Color BackColorMenu { get; set; }
        [Category("Ribbon Design")]
        private Color BorderColor { get; set; }
        [Category("Ribbon Design")]
        private Color ForeColors { get; set; }
        [Category("Ribbon Design")]
        public Bitmap ImageOcultar { get; set; }
        [Category("Ribbon Design")]
        public Bitmap ImageOcultarClick { get; set; }
        [Category("Ribbon Design")]
        public RibbonPanelMdi Contenedor { get; set; }
        [Category("Ribbon Design")]
        public RibbonClassMenu[] Menu { get; set; }
        [Category("Ribbon Design")]
        public string CodigoIniciarMenu { get; set; }
        [Category("Ribbon Design")]
        public Botones[] Botones { get; set; }

        public RibbonMainMenu()
        {
            InitializeComponent();
            ChangeSkin = false;
            DoubleBuffered = true;
        }

        private void CargarConfBotones()
        {
            if (Botones == null)
                return;

            foreach (var objbtnn in main_menu.Items)
            {
                if (objbtnn is ToolStripButton)
                {
                    ((ToolStripButton)objbtnn).Text = string.Empty;
                    ((ToolStripButton)objbtnn).Tag = string.Empty;
                    ((ToolStripButton)objbtnn).Image = null;
                }
            }

            try
            {
                if (Botones.Length >= 1)
                {
                    btn_archivo.Tag = Botones[0].Codigo;
                    btn_archivo.Text = Botones[0].Nombre;
                    btn_archivo.Image = Botones[0].Imagen;
                }

                if (Botones.Length >= 2)
                {
                    btn_transacciones.Tag = Botones[1].Codigo;
                    btn_transacciones.Text = Botones[1].Nombre;
                    btn_transacciones.Image = Botones[1].Imagen;
                }

                if (Botones.Length >= 3)
                {
                    btn_reportes.Tag = Botones[2].Codigo;
                    btn_reportes.Text = Botones[2].Nombre;
                    btn_reportes.Image = Botones[2].Imagen;
                }

                if (Botones.Length >= 4)
                {
                    btn_info_gerencial.Tag = Botones[3].Codigo;
                    btn_info_gerencial.Text = Botones[3].Nombre;
                    btn_info_gerencial.Image = Botones[3].Imagen;
                }

                if (Botones.Length >= 5)
                {
                    btn_administrador_sistema.Tag = Botones[4].Codigo;
                    btn_administrador_sistema.Text = Botones[4].Nombre;
                    btn_administrador_sistema.Image = Botones[4].Imagen;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CargarBotonInicial()
        {
            if (string.IsNullOrEmpty(CodigoIniciarMenu))
                return;

            foreach (var objbtn in main_menu.Items)
            {
                if (objbtn is ToolStripButton)
                {
                    if (((ToolStripButton)objbtn).Tag.Equals(CodigoIniciarMenu))
                    {
                        lblTitulo.Text = ((ToolStripButton)objbtn).Text;
                        ((ToolStripButton)objbtn).CheckState = CheckState.Checked;

                        if (main_menu.Renderer is IToolStripRenderer)
                            ((ToolStripButton)objbtn).ForeColor = (main_menu.Renderer as IToolStripRenderer).ButtonForeColorSelect;

                        foreach (var objbtnn in main_menu.Items)
                        {
                            if (objbtnn is ToolStripButton)
                            {
                                if (((ToolStripButton)objbtnn).Name != ((ToolStripButton)objbtn).Name)
                                {
                                    ((ToolStripButton)objbtnn).CheckState = CheckState.Unchecked;
                                    ((ToolStripButton)objbtnn).ForeColor = ForeColors;
                                }
                            }
                        }
                    }
                }
            }
        }

        public void UpdateDesign(ColorTable Colores)
        {
            ColorTable = Colores;

            if (ChangeSkin && ColorTable != null)
            {
                BtnHideMainMenu.BackgroundImage = null;
                main_menu.Renderer = Colores.MainMenuColor.Renderer;
                ImageOcultar = Colores.MainMenuColor.ImageOcultar;
                ImageOcultarClick = Colores.MainMenuColor.ImageOcultarClick;

                if (main_menu.Renderer is IToolStripRenderer)
                {
                    BorderColor = (main_menu.Renderer as IToolStripRenderer).BordeColor;
                    ForeColors = (main_menu.Renderer as IToolStripRenderer).ButtonForeColor;
                    lblTitulo.ForeColor = (main_menu.Renderer as IToolStripRenderer).TitleForeColor;
                }
            }

            PaintControl();
        }

        private void PaintBorder(object sender, PaintEventArgs e)
        {
            if (ChangeSkin)
                UpdateDesign(ColorTable);

            ControlPaint.DrawBorder(e.Graphics, (sender as Panel).DisplayRectangle, BorderColor, ButtonBorderStyle.Solid);
        }

        private void BtHideMainMenu_Click(object sender, EventArgs e)
        {
            cHide = (!cHide) ? true : false;

            if (cHide)
            {
                Width = 30;
                lblTitulo.Visible = false;
                PanelOculto.Visible = true;
                PanelOculto.BringToFront();
            }
            else
            {
                Width = 300;
                lblTitulo.Visible = true;
                PanelOculto.Visible = false;
            }

            foreach (var objbtn in main_menu.Items)
            {
                if (objbtn is ToolStripButton)
                {
                    ((ToolStripButton)objbtn).ImageAlign = cHide ? Drawing.ContentAlignment.MiddleCenter : Drawing.ContentAlignment.MiddleLeft;
                    ((ToolStripButton)objbtn).DisplayStyle = cHide ? ToolStripItemDisplayStyle.Image : ToolStripItemDisplayStyle.ImageAndText;
                    ((ToolStripButton)objbtn).TextImageRelation = cHide ? TextImageRelation.ImageAboveText : TextImageRelation.ImageBeforeText;
                }
            }
        }

        private void BtnMainMenu_click(object sender, EventArgs e)
        {
            lblTitulo.Text = ((ToolStripButton)sender).Text;
            ((ToolStripButton)sender).CheckState = CheckState.Checked;

            if (main_menu.Renderer is IToolStripRenderer)
                ((ToolStripButton)sender).ForeColor = (main_menu.Renderer as IToolStripRenderer).ButtonForeColorSelect;

            foreach (var objbtn in main_menu.Items)
            {
                if (objbtn is ToolStripButton)
                {
                    if (((ToolStripButton)objbtn).Name != ((ToolStripButton)sender).Name)
                    {
                        ((ToolStripButton)objbtn).CheckState = CheckState.Unchecked;
                        ((ToolStripButton)objbtn).ForeColor = ForeColors;
                    }
                }
            }

            if (Contenedor == null)
            {
                MessageBox.Show("No se Asigno Ningun Contenedor", "Error : Container Forms", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //CARGAR LOS ITEMS
            CargarNodos(((ToolStripButton)sender).Tag.ToString());
        }

        private void PaintControl()
        {
            rbordermenu.BackColor = BorderColor;
            borderTop.BackColor = BorderColor;
            borderBottom.BackColor = BorderColor;
            bordeRight.BackColor = BorderColor;
            borderLeft.BackColor = BorderColor;
            separador1.BackColor = BorderColor;
            BtnHideMainMenu.Imagen = ImageOcultar;
            BtnHideMainMenu.ImagenOnClick = ImageOcultarClick;

            if (main_menu.Renderer is IToolStripRenderer)
            {
                PanelOculto.CreateGraphics().FillRectangle((main_menu.Renderer as IToolStripRenderer).BrushBar, PanelOculto.ClientRectangle);
                PanelHeader.CreateGraphics().FillRectangle((main_menu.Renderer as IToolStripRenderer).BrushHeaderTitle, PanelHeader.ClientRectangle);
            }

            foreach (var objbtn in main_menu.Items)
            {
                if (objbtn is ToolStripButton)
                    ((ToolStripButton)objbtn).ForeColor = ForeColors;
            }

            if (cHide)
                BtnHideMainMenu.BackgroundImage = ImageOcultarClick;

            main_menu.BackColor = BackColorMenu;
            Refresh();
        }

        private void RibbonMainMenu_Load(object sender, EventArgs e)
        {
            if (Botones != null)
                CargarConfBotones();

            if (CodigoIniciarMenu != null)
                CargarBotonInicial();

            if (Menu != null)
                CargarNodos(CodigoIniciarMenu);
        }

        public void CargarNodos(string as_key)
        {
            if (Menu == null)
                return;

            var RetMenu = from valor in Menu
                          where valor.CodMen.Substring(0, 2) == as_key
                          orderby valor.Orden
                          select valor;

            ArrayMenu = new string[RetMenu.Count(), 5];

            TreeviewMenu.Nodes.Clear();
            ICont2 = 0;

            foreach (RibbonClassMenu element in RetMenu)
            {

                sKey1 = element.Key;
                sKey2 = element.CodMen;
                sKeyName = element.NomMen;
                sImagen = element.ImgMen;
                sFuncion = element.FunEje;

                ArrayMenu[ICont2, 0] = sKey1;
                ArrayMenu[ICont2, 1] = sKey2;
                ArrayMenu[ICont2, 2] = sKeyName;
                ArrayMenu[ICont2, 3] = sImagen;
                ArrayMenu[ICont2, 4] = sFuncion;

                ICont2++;

                if (sKey1 == as_key)
                    continue;

                if (sKey2.Length == 2)
                    TreeviewMenu.Nodes.Add(sKey1, sKeyName + " ", Convert.ToInt16(sImagen)).Tag = sFuncion;
            }

            if (TreeviewMenu.Nodes.Count <= 0)
                return;

            for (int i = 0; i < TreeviewMenu.Nodes.Count; i++)
            {
                CargaNodosSecundarios(TreeviewMenu.Nodes[i], ICont2);
                TreeviewMenu.Nodes[i].ExpandAll();

                if (TreeviewMenu.Nodes[i].Nodes.Count > 0)
                {
                    if (TreeviewMenu.Nodes[i].Nodes.Count > 0)
                        TreeviewMenu.Nodes[i].NodeFont = new Drawing.Font("Segoe UI", 10, Drawing.FontStyle.Bold);

                    for (int l = 0; l < TreeviewMenu.Nodes[i].Nodes.Count; l++)
                    {
                        CargaNodosSecundarios(TreeviewMenu.Nodes[i].Nodes[l], ICont2);

                        for (int p = 0; p < TreeviewMenu.Nodes[i].Nodes[l].Nodes.Count; p++)
                        {
                            CargaNodosSecundarios(TreeviewMenu.Nodes[i].Nodes[l].Nodes[p], ICont2);

                            for (int q = 0; q < TreeviewMenu.Nodes[i].Nodes[l].Nodes[p].Nodes.Count; q++)
                            {
                                CargaNodosSecundarios(TreeviewMenu.Nodes[i].Nodes[l].Nodes[p].Nodes[q], ICont2);

                                for (int T = 0; T < TreeviewMenu.Nodes[i].Nodes[l].Nodes[p].Nodes[T].Nodes.Count; T++)
                                {
                                    CargaNodosSecundarios(TreeviewMenu.Nodes[i].Nodes[l].Nodes[p].Nodes[q].Nodes[T], ICont2);
                                }
                            }
                        }
                    }
                }
            }
            TreeviewMenu.SelectedNode = TreeviewMenu.Nodes[0];
        }

        private void CargaNodosSecundarios(TreeNode as_node, Int32 as_dimension)
        {
            for (int i = 0; i < as_dimension; i++)
            {
                if (as_node.Name == ArrayMenu[i, 1])
                {
                    sKey1 = ArrayMenu[i, 0];
                    sKey2 = ArrayMenu[i, 1];
                    sKeyName = ArrayMenu[i, 2];
                    sImagen = ArrayMenu[i, 3];
                    sFuncion = ArrayMenu[i, 4];

                    as_node.Nodes.Add(sKey1, sKeyName, Convert.ToInt16(sImagen)).Tag = sFuncion;
                }
            }
        }

        private void TreeviewMenu_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show(TreeviewMenu.SelectedNode.Tag.ToString());
            //RibbonForm frm = new RibbonForm();
            //Contenedor.Showform(frm);        
        }

        private void TreeviewMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            e.Node.SelectedImageIndex = e.Node.ImageIndex;
        }

        private void PanelHeaderPaint(object sender, PaintEventArgs e)
        {
            if (main_menu.Renderer is IToolStripRenderer)
                e.Graphics.FillRectangle((main_menu.Renderer as IToolStripRenderer).BrushHeaderTitle, PanelHeader.ClientRectangle);
        }

        private void PanelOcultoPaint(object sender, PaintEventArgs e)
        {
            if (main_menu.Renderer is IToolStripRenderer)
                e.Graphics.FillRectangle((main_menu.Renderer as IToolStripRenderer).BrushBar, PanelOculto.ClientRectangle);
        }
    }
}