using DbConnection.ConnectionProvider;
using DbConnection.Interfaces;

namespace DbConnection
{
    public static class DefaultConnection
    {
        //Espicificamos el Proveedor de Conexión de Bd que se usara
        //Tambien podemos pasar el nombre del Connection String Almacenado en el App.Config Con el Cual se Trabajara.
        public static IDbConnectionProvider Connection(string nameConnectionStrings = "")
        {
            return new PostgresDbConnection(nameConnectionStrings);
        }
    }
}