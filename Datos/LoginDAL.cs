using ArquitecturaCapa.DataBase.Funciones;
using Entidades;

namespace ArquitecturaCapa.DataBase
{
    public class LoginDAL
    {
        private readonly IUsuario _usuario;
        private readonly DataAccesDAL _dataAccesDAL;

        public LoginDAL(IUsuario usuario, string nameConnectionStrings = "")
        {
            _usuario = usuario;
            _dataAccesDAL = new DataAccesDAL(nameConnectionStrings);
        }

        public bool Login(out string errorMsg)
        {
            errorMsg = string.Empty;

            try
            {
                using (var connection = _dataAccesDAL.GetConnection())
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT COUNT(*) FROM Usuarios WHERE login = @Login AND Password = @Password";
                        command.Parameters.Add(command.GetWithValue("@Login", _usuario.Login));
                        command.Parameters.Add(command.GetWithValue("@Password", _usuario.Password));

                        var count = (long)command.ExecuteScalar();

                        if (count > 0)
                        {
                            GetDataDAL data = new GetDataDAL(connection);

                            var response = data.GetData("SELECT * FROM Usuarios WHERE login = @Login AND Password = @Password", new Dictionary<string, object>() { { "@Login", _usuario.Login }, { "@Password", _usuario.Password } });

                            if (response["estado"].ToString() != "A")
                            {
                                errorMsg = "Usuario se Encuentra Inactivo";
                                return false;
                            }

                            return true;
                        }
                        else
                        {
                            errorMsg = "Usuario ó Contraseña incorrectos";
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;
                return false;
            }
        }
    }
}