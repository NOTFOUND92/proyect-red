using System.Data;

namespace ArquitecturaCapa.DataBase.Funciones
{
    public class GetDataDAL : IGetData
    {
        private readonly IDbConnection _dbconnection;

        public GetDataDAL(IDbConnection dbConnection)
        {
            _dbconnection = dbConnection;
        }

        public Dictionary<string, object> GetData(string sql, Dictionary<string, object> parameters = null)
        {
            if (string.IsNullOrEmpty(sql))
            {
                throw new ArgumentException("Consulta SQL se encuentra vacia");
            }

            if (_dbconnection == null)
            {
                throw new ArgumentNullException("No se envio la Conexió de Base de Datos");
            }

            using (IDbConnection connection = _dbconnection)
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = sql;

                    if (parameters != null)
                    {
                        foreach (KeyValuePair<string, object> parameter in parameters)
                        {
                            IDbDataParameter dbParameter = command.CreateParameter();
                            dbParameter.ParameterName = parameter.Key;
                            dbParameter.Value = parameter.Value;
                            command.Parameters.Add(dbParameter);
                        }
                    }

                    using (IDataReader dataReader = command.ExecuteReader())
                    {
                        return GetValues(dataReader);
                    }
                }
            }
        }

        private Dictionary<string, object> GetValues(IDataReader dataReader)
        {
            Dictionary<string, object> fieldValues = new Dictionary<string, object>();

            while (dataReader.Read())
            {
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    string fieldName = dataReader.GetName(i);
                    object fieldValue = dataReader.GetValue(i);
                    fieldValues.Add(fieldName, fieldValue);
                }
            }

            dataReader.Close();
            return fieldValues;
        }
    }
}