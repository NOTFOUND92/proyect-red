using System.ComponentModel;
using System.Drawing;

namespace System.Windows.Forms
{
    public class RibbonMenuStrip : MenuStrip, IRibbonDesign
    {
        RibbonMenuStripDesigner GetRibbonMenuStripDesigner;

        [Category("Ribbon Design")]
        public bool ChangeSkin { get; set; }
        [Category("Ribbon Design")]
        public Color ItemsColor { get; set; }
        [Category("Ribbon Design")]
        public Color ItemsColorClick { get; set; }

        public RibbonMenuStrip()
        {
            GetRibbonMenuStripDesigner = new RibbonMenuStripDesigner(this);
            DoubleBuffered = true;
        }

        public void UpdateDesign(ColorTable Colores)
        {
            GetRibbonMenuStripDesigner.UpdateDesign(Colores);
        }

        public void MenuClickMenuStrip(object sender, EventArgs e)
        {
            GetRibbonMenuStripDesigner.ClickMenuStrip(sender, e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GetRibbonMenuStripDesigner.OnPaint(e);
        }
    }
}