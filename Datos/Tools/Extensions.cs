using System.Data;

namespace ArquitecturaCapa.DataBase
{
    public static class Extensions
    {
        public static IDbDataParameter GetWithValue<T>(this IDbCommand command, string parameterName, T value)
        {
            IDbDataParameter Parameter = command.CreateParameter();
            Parameter.ParameterName = parameterName;
            Parameter.Value = value;
            return Parameter;
        }
    }
}