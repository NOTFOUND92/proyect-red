using Npgsql;

namespace DbConnection.ConnectionProvider
{
    internal class PostgresDbConnection : DbConnectionBase
    {
        public PostgresDbConnection(string nameConnectionStrings = "") : base(new NpgsqlConnection(), nameConnectionStrings)
        {
        }
    }
}