using System.ComponentModel;
using System.Drawing;

namespace System.Windows.Forms
{
    public class RibbonStatusStrip : StatusStrip, IRibbonDesign
    {
        RibbonStatusStripDesigner GetRibbonStatusStripDesigner;

        [Category("Ribbon Design")]
        public bool ChangeSkin { get; set; }
        [Category("Ribbon Design")]
        public Color ColorTop1 { get; set; }
        [Category("Ribbon Design")]
        public Color ColorTop2 { get; set; }
        [Category("Ribbon Design")]
        public Color ColorBottom1 { get; set; }
        [Category("Ribbon Design")]
        public Color ColorBottom2 { get; set; }
        [Category("Ribbon Design")]
        public Color BorderColor { get; set; }

        public RibbonStatusStrip()
        {
            GetRibbonStatusStripDesigner = new RibbonStatusStripDesigner(this);
            DoubleBuffered = true;
        }

        public void UpdateDesign(ColorTable Colores)
        {
            GetRibbonStatusStripDesigner.UpdateDesign(Colores);
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            GetRibbonStatusStripDesigner.OnPaint(e);
            base.OnPaint(e);
        }
    }
}