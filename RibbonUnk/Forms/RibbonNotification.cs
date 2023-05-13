using System.Drawing;

namespace System.Windows.Forms
{
    public partial class RibbonNotification : RibbonForm
    {
        public string Descripcion { get; set; }
        public Image Imagen { get; set; }
        public string TextLink { get; set; }
        public EventHandler Manejador { get; set; }

        public RibbonNotification()
        {
            InitializeComponent();
            this.ColorRibbon = Color.Transparent;
            this.ForeColortituloText = Color.Black;
            this.BackColor = Color.FromArgb(229, 229, 230);
        }

        private void RibbonNotification_LocationChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void RibbonNotification_Load(object sender, EventArgs e)
        {
            this.lbl_descripcion.Text = Descripcion;

            if (Imagen != null)
                this.PbxImagen.BackgroundImage = Imagen;

            if (Manejador == null)
                this.linkLabel1.Visible = false;
            else
            {
                this.linkLabel1.Visible = true;
                this.linkLabel1.Click += new EventHandler(Manejador);
            }

            this.linkLabel1.Text = TextLink;
        }
    }
}
