using System.Drawing;

namespace System.Windows.Forms
{
    public class RibbonStatusStripDesigner
    {
        RibbonStatusStrip GetRibbon;
        ColorTable ColorTable;
        Color[] Colores = new Color[5];

        public RibbonStatusStripDesigner(RibbonStatusStrip ribbon)
        {
            GetRibbon = ribbon;
            PropertiesDefault();
        }

        private void PropertiesDefault()
        {
            GetRibbon.ChangeSkin = false;
            GetRibbon.RenderMode = ToolStripRenderMode.System;
        }

        public void UpdateDesign(ColorTable Colores)
        {
            ColorTable = Colores;

            if (GetRibbon.ChangeSkin && ColorTable != null)
            {
                GetRibbon.ColorTop1 = ColorTable.StatusStripColor.TopColor1;
                GetRibbon.ColorTop2 = ColorTable.StatusStripColor.TopColor2;
                GetRibbon.ColorBottom1 = ColorTable.StatusStripColor.BottomColor1;
                GetRibbon.ColorBottom2 = ColorTable.StatusStripColor.BottomColor2;
                GetRibbon.BorderColor = ColorTable.StatusStripColor.BorderColor;
            }
        }

        public void OnPaint(PaintEventArgs e)
        {
            if (GetRibbon.ChangeSkin)
                UpdateDesign(ColorTable);

            Colores[0] = GetRibbon.ColorTop1;
            Colores[1] = GetRibbon.ColorTop2;
            Colores[2] = GetRibbon.ColorBottom1;
            Colores[3] = GetRibbon.ColorBottom2;
            Colores[4] = GetRibbon.BorderColor;

            ColorsDrawing.DrawStatusStripGradient(e, GetRibbon, Colores);
        }
    }
}