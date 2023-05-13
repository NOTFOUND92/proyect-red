using EnterpriseUpdater.Controles;
using EnterpriseUpdater.ControlInformation;
using EnterpriseUpdater.Forms.Login;

namespace EnterpriseUpdater.Forms
{
    public partial class FrmLogin : Form
    {
        private CreateAcount _createAcount;
        private LoginControl _loginControl;
        private InformationControl _informationControl;

        UserControl pa = new UserControl() { BackColor = Color.Yellow, Name = "ja" };
        UserControl pi = new UserControl() { BackColor = Color.Green, Name = "jaasd" };
        UserControl pi2 = new UserControl() { BackColor = Color.Blue, Name = "jaaaaasd" };

        public FrmLogin()
        {
            InitializeComponent();
            AddControls();
            AddInformationControl();
        }

        private void AddControls()
        {
            _createAcount = new CreateAcount();
            _loginControl = new LoginControl();

            _createAcount.Visible = false;
            _loginControl.Visible = false;

            this.Contenedor.Panel2.Controls.Add(_createAcount);
            this.Contenedor.Panel2.Controls.Add(_loginControl);

            _loginControl.Location = new Point(19, 38);
            _createAcount.Location = _loginControl.Location;

            _loginControl.Dock = DockStyle.Fill;
            _createAcount.Size = _loginControl.Size;

            _loginControl.Visible = true;
        }

        private void AddInformationControl()
        {
            _informationControl = new InformationControl();
            _informationControl.BackColor = Color.Transparent;
            _informationControl.Dock = DockStyle.Fill;

            _informationControl.NotificationAdd(new MainInformation());
            //_informationControl.NotificationAdd(pi);
            //_informationControl.NotificationAdd(pi2);

            this.Contenedor.Panel1.Controls.Add(_informationControl);
        }

        private void lbl_sign_up_Click(object sender, EventArgs e)
        {
            signUpClick();
        }

        private void lbl_login_Click(object sender, EventArgs e)
        {
            loginClick();
        }

        private void signUpClick()
        {
            _loginControl.Visible = false;
            _createAcount.Visible = true;

            this.pnl_deslis_sign_up.Visible = true;
            this.pnl_deslis_login.Visible = false;
        }

        private void loginClick()
        {
            _loginControl.Visible = true;
            _createAcount.Visible = false;

            this.pnl_deslis_login.Visible = true;
            this.pnl_deslis_sign_up.Visible = false;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            loginClick();
        }
    }
}