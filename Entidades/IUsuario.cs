namespace Entidades
{
    public interface IUsuario
    {
        string Codigo { get; set; }
        string Login { get; set; }
        string Password { get; set; }
        bool ValidateData(out string errorMsg);
    }
}