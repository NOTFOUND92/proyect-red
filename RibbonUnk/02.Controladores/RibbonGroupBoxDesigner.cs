using System.Drawing;
using System.Drawing.Drawing2D;

namespace System.Windows.Forms
{
    public class RibbonGroupBoxDesigner
    {
        RibbonGroupBox GetRibbon;
        ColorTable ColorTable;
        Color[] Colores = new Color[4];

        public RibbonGroupBoxDesigner(RibbonGroupBox ribbonGroupBox)
        {
            GetRibbon = ribbonGroupBox;
            PropertiesDefault();
        }

        private void PropertiesDefault()
        {
            GetRibbon.Curvate = 4;
            GetRibbon.BorderColor = Color.Black;
            GetRibbon.TitleForeColor = Color.Black;
            GetRibbon.TitleBackColor = Color.White;
            GetRibbon.TitleFont = new Font(GetRibbon.Font.FontFamily, 8, FontStyle.Regular);
            GetRibbon.Position = Position.Down;
            GetRibbon.HatchStyle = HatchStyle.Percent90;
        }

        public void UpdateDesign(ColorTable Colores)
        {
            ColorTable = Colores;

            if (GetRibbon.ChangeSkin && ColorTable != null)
            {
                GetRibbon.Curvate = ColorTable.GroupBoxColor.Curvate;
                GetRibbon.BackColor = ColorTable.GroupBoxColor.BackColor;
                GetRibbon.BorderColor = ColorTable.GroupBoxColor.BorderColor;
                GetRibbon.TitleBackColor = ColorTable.GroupBoxColor.TitleBackColor;
                GetRibbon.TitleForeColor = ColorTable.GroupBoxColor.TitleColor;
            }
        }

        public void OnPaint(PaintEventArgs e)
        {
            if (GetRibbon.ChangeSkin)
                UpdateDesign(ColorTable);

            Colores[0] = GetRibbon.BackColor;
            Colores[1] = GetRibbon.BorderColor;
            Colores[2] = GetRibbon.TitleBackColor;
            Colores[3] = GetRibbon.TitleForeColor;

            ColorsDrawing.DrawGroupBox(e, GetRibbon, GetRibbon.Text, Colores, GetRibbon.HatchStyle, GetRibbon.Position, GetRibbon.Curvate);
        }
    }
}