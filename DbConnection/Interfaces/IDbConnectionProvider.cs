using System.Data;

namespace DbConnection.Interfaces
{
    public interface IDbConnectionProvider : IDisposable
    {
        IDbConnection GetConnection();
        bool ValidateConnection(out string errorMsg);
    }
}