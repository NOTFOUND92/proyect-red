using ArquitecturaCapa.DataBase;
using System.Data;

namespace ArquitecturaCapa.Domain
{
    public class DataAccesDLL
    {
        private  DataAccesDAL _dataAccesDAL;

        public DataAccesDLL(string nameConnectionStrings = "")
        {
            _dataAccesDAL = new DataAccesDAL(nameConnectionStrings);
        }

        public bool ValidateConnection(out string errorMsg)
        {
            return _dataAccesDAL.ValidateConnection(out errorMsg);
        }

        public IDbConnection GetConnection()
        {
            return _dataAccesDAL.GetConnection();
        }
    }
}