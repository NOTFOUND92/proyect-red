using System.Drawing;

namespace System.Windows.Forms
{
    public class RibbonClassMenu
    {
        public string Key { get; set; }
        public string CodMen { get; set; }
        public string NomMen { get; set; }
        public string ImgMen { get; set; }
        public string FunEje { get; set; }
        public string Estado { get; set; }
        public int Orden { get; set; }
        public int Dias { get; set; }
    }

    public class Botones
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public Image Imagen { get; set; }
    }

    public class ButtonHomeRibbon
    {
        public string Titulo { get; set; }
        public Image Imagen { get; set; }
        public UserControl UserControl { get; set; }
    }
}