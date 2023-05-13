namespace Entidades
{
    public class Usuario : IUsuario
    {
        public string Codigo { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public bool ValidateData(out string errorMsg)
        {
            errorMsg = String.Empty;

            if (string.IsNullOrEmpty(Login))
            {
                errorMsg = "Ingrese Correctamente su Login";
                return false;   
            }

            if (string.IsNullOrEmpty(Password))
            {
                errorMsg = "Ingrese Correctamente su Contraseña";
                return false;
            }

            return true;
        }
    }
}
