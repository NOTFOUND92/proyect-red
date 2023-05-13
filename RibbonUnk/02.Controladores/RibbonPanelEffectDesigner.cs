using System.Drawing;
using System.Drawing.Drawing2D;

namespace System.Windows.Forms
{
    public class RibbonPanelEffectDesigner
    {
        bool GoFocus;
        RibbonPanelEffect GetRibbon;
        ColorTable ColorTable;
        Color[] color = new Color[3];

        public RibbonPanelEffectDesigner(RibbonPanelEffect ribbon)
        {
            GetRibbon = ribbon;
            PropertiesDefault();
        }

        private void PropertiesDefault()
        {
            GetRibbon.Curvate = 4;
            GetRibbon.ChangeSkin = false;
            GetRibbon.TitleFont = new Font(GetRibbon.Font.FontFamily, 8, FontStyle.Regular);
            GetRibbon.Title = "Ribbon Effects";
            GetRibbon.Position = Position.Down;
            GetRibbon.TitleHatchStyle = HatchStyle.Percent90;
            GetRibbon.Paint += RibbonPaint;
            GetRibbon.MouseDown += RibbonMouseDown;
            GetRibbon.MouseMove += RibbonMouseMove;
            GetRibbon.MouseLeave += RibbonMouseLeave;
        }

        public void UpdateDesign(ColorTable Colores)
        {
            ColorTable = Colores;

            if (GetRibbon.ChangeSkin && ColorTable != null)
            {
                GetRibbon.Curvate = ColorTable.PanelEffectColor.Curvate;
                GetRibbon.BorderColor = ColorTable.PanelEffectColor.BorderColor;
                GetRibbon.TitleBackColor = ColorTable.PanelEffectColor.TitleBackColor;
                GetRibbon.TitleForeColor = ColorTable.PanelEffectColor.TitleColor;
                GetRibbon.BackColorFocus = ColorTable.PanelEffectColor.BackColorFocus;
                GetRibbon.BackColorClick = ColorTable.PanelEffectColor.BackColorClick;
                GetRibbon.TitleHatchStyle = HatchStyle.Percent90;
            }
        }

        private void RibbonPaint(object sender, PaintEventArgs e)
        {
            if (GetRibbon.ChangeSkin)
                UpdateDesign(ColorTable);
        }

        private void RibbonMouseMove(object sender, MouseEventArgs e)
        {
            GoFocus = true;
            GetRibbon.BackColor = GetRibbon.BackColorFocus;
        }

        private void RibbonMouseLeave(object sender, EventArgs e)
        {
            GoFocus = false;
            GetRibbon.BackColor = GetRibbon.BackGroundColor;
        }

        private void RibbonMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                GetRibbon.BackColor = GetRibbon.BackColorClick;
        }

        public void OnPaint(PaintEventArgs e)
        {
            color[0] = GetRibbon.BorderColor;
            color[1] = GetRibbon.TitleForeColor;
            color[2] = GetRibbon.TitleBackColor;

            ColorsDrawing.DrawPanelEffect(e, GetRibbon, GetRibbon.Title, color, GetRibbon.TitleHatchStyle, GetRibbon.Position, GetRibbon.Curvate);
        }
    }
}