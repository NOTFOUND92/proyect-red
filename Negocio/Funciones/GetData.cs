using ArquitecturaCapa.DataBase;
using ArquitecturaCapa.DataBase.Funciones;
using System.Data;

namespace ArquitecturaCapa.Domain
{
    public class GetData
    {
        private readonly GetDataDAL _getData;

        public GetData(IDbConnection dbConnection = null)
        {
            dbConnection = dbConnection ?? new DataAccesDAL().GetConnection();
            _getData = new GetDataDAL(dbConnection);
        }

        public Dictionary<string, object> Fields(string sql)
        {
            return _getData.GetData(sql, null);
        }

        public Dictionary<string, object> Fields(string sql, Dictionary<string, object> parameters)
        {
            return _getData.GetData(sql, parameters);
        }
    }
}