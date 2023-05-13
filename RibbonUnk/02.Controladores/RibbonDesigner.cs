using System.Drawing;

namespace System.Windows.Forms
{
    public class RibbonDesigner
    {
        Ribbon GetRibbon;
        ColorTable ColorTable;
        Color[] Colores = new Color[5];

        public RibbonDesigner(Ribbon ribbon)
        {
            GetRibbon = ribbon;
            PropertiesDefault();
        }

        private void PropertiesDefault()
        {
            GetRibbon.BackColor = Color.White;
            GetRibbon.TopColor1 = Color.Transparent;
            GetRibbon.TopColor2 = Color.Transparent;
            GetRibbon.BottomColor1 = Color.Transparent;
            GetRibbon.BottomColor2 = Color.Transparent;
            GetRibbon.BorderColor = Color.Black;
            GetRibbon.ColorHeight = 17;
            GetRibbon.Curvate = 4;
        }

        public void UpdateDesign(ColorTable Colores)
        {
            ColorTable = Colores;

            if (GetRibbon.ChangeSkin && ColorTable != null)
            {
                GetRibbon.Curvate = ColorTable.RibbonColor.Curvate;
                GetRibbon.BackColor = ColorTable.RibbonColor.BackColor;
                GetRibbon.TopColor1 = ColorTable.RibbonColor.TopColor1;
                GetRibbon.TopColor2 = ColorTable.RibbonColor.TopColor2;
                GetRibbon.BottomColor1 = ColorTable.RibbonColor.BottomColor1;
                GetRibbon.BottomColor2 = ColorTable.RibbonColor.BottomColor2;
                GetRibbon.BorderColor = ColorTable.RibbonColor.BorderColor;
                GetRibbon.ColorHeight = ColorTable.RibbonColor.ColorHeight;
            }
        }

        public void OnPaint(PaintEventArgs e)
        {
            if (GetRibbon.ChangeSkin)
                UpdateDesign(ColorTable);

            Colores[0] = GetRibbon.TopColor1;
            Colores[1] = GetRibbon.TopColor2;
            Colores[2] = GetRibbon.BottomColor1;
            Colores[3] = GetRibbon.BottomColor2;
            Colores[4] = GetRibbon.BorderColor;

            ColorsDrawing.GradientDrawing(e, GetRibbon, Colores, GetRibbon.ColorHeight, true, GetRibbon.Curvate);
        }
    }
}