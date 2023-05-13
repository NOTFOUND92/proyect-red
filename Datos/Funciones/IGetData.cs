namespace ArquitecturaCapa.DataBase.Funciones
{
    public interface IGetData
    {
        Dictionary<string, object> GetData(string sql, Dictionary<string, object> parameters = null);
    }
}