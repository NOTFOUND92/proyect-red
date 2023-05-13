using DbConnection;
using DbConnection.Interfaces;
using System.Data;

namespace ArquitecturaCapa.DataBase
{
    public class DataAccesDAL
    {
        private readonly IDbConnectionProvider dbConnectionProvider;

        public DataAccesDAL(string nameConnectionStrings = "")
        {
            dbConnectionProvider = DefaultConnection.Connection(nameConnectionStrings);
        }

        public bool ValidateConnection(out string errorMsg)
        {
            return dbConnectionProvider.ValidateConnection(out errorMsg);
        }

        public IDbConnection GetConnection()
        {
            return dbConnectionProvider.GetConnection();
        }
    }
}