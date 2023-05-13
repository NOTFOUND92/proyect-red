using ArquitecturaCapa.Domain;
using EnterpriseUpdater.Forms;

namespace EnterpriseUpdater
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            string errorMsg = string.Empty;

            var dataAcces = new DataAccesDLL();
            if (!dataAcces.ValidateConnection(out errorMsg))
            {
                MessageBox.Show(errorMsg, "Error de Conexión con el Servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmLogin frmLogin = new FrmLogin();

            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmMain());
            }
        }
    }
}