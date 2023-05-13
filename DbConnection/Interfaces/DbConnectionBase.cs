using DbConnection.Herramientas;
using DbConnection.Interfaces;
using Npgsql;
using System.Data;

namespace DbConnection
{
    internal abstract class DbConnectionBase : IDbConnectionProvider
    {
        private readonly IDbConnection _connection;
        private readonly string _connectionString;

        public DbConnectionBase(IDbConnection providerConnection, string nameConnectionStrings = "")
        {
            if (string.IsNullOrEmpty(nameConnectionStrings))
            {
                nameConnectionStrings = "Produccion";
            }
            _connectionString = Tools.GetConnectionStrings(nameConnectionStrings);
            _connection = providerConnection;
            _connection.ConnectionString = _connectionString;
        }

        public virtual bool ValidateConnection(out string errorMsg)
        {
            try
            {
                _connection.Open();
                errorMsg = string.Empty;
                return true;
            }
            catch (NpgsqlException ex)
            {

                errorMsg = ex.Message;
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public virtual IDbConnection GetConnection()
        {
            if (_connection.State != ConnectionState.Open)
                _connection.Open();

            return _connection;
        }

        public virtual void Dispose()
        {
            _connection.Dispose();
        }

        public override string ToString()
        {
            return _connectionString;
        }
    }
}