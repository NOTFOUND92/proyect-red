using Microsoft.Data.SqlClient;

namespace DbConnection.ConnectionProvider
{
    internal class SQlServerDbConnection : DbConnectionBase
    {
        public SQlServerDbConnection(string nameConnectionStrings = "") : base(new SqlConnection(), nameConnectionStrings)
        {
        }
    }
}