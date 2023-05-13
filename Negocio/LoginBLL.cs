using ArquitecturaCapa.DataBase;
using Entidades;

namespace ArquitecturaCapa.Domain
{
    public class LoginBLL
    {
        private readonly string _nameConnectionStrings;

        public LoginBLL(string nameConnectionStrings = "")
        {
            _nameConnectionStrings = nameConnectionStrings;
        }

        public bool Login(Usuario usuario, out string errorMsg)
        {
            if (!usuario.ValidateData(out errorMsg))
            {
                return false;
            }

            return new LoginDAL(usuario, _nameConnectionStrings).Login(out errorMsg);
        }
    }
}