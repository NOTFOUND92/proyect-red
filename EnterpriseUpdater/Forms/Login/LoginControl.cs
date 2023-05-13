using ArquitecturaCapa.Domain;
using Entidades;

namespace EnterpriseUpdater.Forms.Login
{
    public partial class LoginControl : UserControl
    {
        private Usuario _user = new Usuario();

        public LoginControl()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            var errorMsg = "";

            _user.Login = this.txt_usuario_login.Text.Trim();
            _user.Password = this.txt_contraseña_login.Text.Trim();

            if (new LoginBLL().Login(_user, out errorMsg))
            {
                this.FindForm().DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(errorMsg, "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}