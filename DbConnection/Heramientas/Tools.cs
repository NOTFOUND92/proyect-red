using System.Configuration;

namespace DbConnection.Herramientas
{
    internal static class Tools
    {
        //Función para obtener el Connection String del App.Config pasando el Nombre
        public static string GetConnectionStrings(string key)
        {
            var valor = ConfigurationManager.ConnectionStrings[key].ConnectionString;
            if (valor == null)
            {
                throw new Exception($"La llave '{key}' no existe en el archivo de configuración.");
            }
            return valor;
        }
    }
}