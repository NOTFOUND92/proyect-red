using EnterpriseUpdater.Controles.Controladores;

namespace EnterpriseUpdater.Controles
{
    public sealed partial class InformationControl : UserControl
    {
        private ControladorInformationControl _controlador;
        public int DuracionTransicion { get; set; }

        public InformationControl()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            _controlador = new ControladorInformationControl(this);
            DuracionTransicion = 7;
        }

        public void NotificationAdd(UserControl control)
        {
            _controlador.NotificationAdd(control);
        }
    }
}