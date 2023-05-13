using System.Drawing;

namespace System.Windows.Forms
{
    public class RibbonMenuStripDesigner
    {
        RibbonMenuStrip GetRibbon;
        ColorTable ColorTable;

        public RibbonMenuStripDesigner(RibbonMenuStrip ribbonMenuStrip)
        {
            GetRibbon = ribbonMenuStrip;
            PropertiesDefault();
        }

        public void PropertiesDefault()
        {
            GetRibbon.ItemsColor = Color.Black;
            GetRibbon.ItemsColorClick = Color.Black;
        }

        public void UpdateDesign(ColorTable Colores)
        {
            ColorTable = Colores;

            if (GetRibbon.ChangeSkin && ColorTable != null)
            {
                GetRibbon.Padding = new Padding(0, 0, 0, 0);
                GetRibbon.ItemsColor = ColorTable.MenuStripColor.ItemsColor;
                GetRibbon.BackColor = ColorTable.MenuStripColor.BackColor;
                GetRibbon.ItemsColorClick = ColorTable.MenuStripColor.ItemsColorClick;
            }
        }

        private void ResetMenuItem()
        {
            if (GetRibbon.Items.Count > 0)
            {
                for (int i = 0; i < GetRibbon.Items.Count; i++)
                {
                    GetRibbon.Items[i].ForeColor = GetRibbon.ItemsColor;
                    GetRibbon.Items[i].Padding = new Padding(3, 0, 3, 0);
                }
            }
        }

        public void OnPaint(PaintEventArgs e)
        {
            if (GetRibbon.ChangeSkin)
                UpdateDesign(ColorTable);

            ResetMenuItem();
        }

        public void ClickMenuStrip(object sender, EventArgs e)
        {
            (sender as ToolStripMenuItem).ForeColor = GetRibbon.ItemsColorClick;

            foreach (ToolStripMenuItem objitem in GetRibbon.Items)
            {
                objitem.ForeColor = GetRibbon.ItemsColor;
            }
        }
    }
}