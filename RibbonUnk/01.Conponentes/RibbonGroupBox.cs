using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace System.Windows.Forms
{
    public class RibbonGroupBox : GroupBox, IRibbonDesign
    {
        RibbonGroupBoxDesigner GetRibbonGroupBoxDesigner;

        [Category("Ribbon Design")]
        public Color BorderColor { get; set; }
        [Category("Ribbon Design")]
        public Color TitleForeColor { get; set; }
        [Category("Ribbon Design")]
        public Color TitleBackColor { get; set; }
        [Category("Ribbon Design")]
        public Font TitleFont { get; set; }
        [Category("Ribbon Design")]
        public int Curvate { get; set; }
        [Category("Ribbon Design")]
        public bool ChangeSkin { get; set; }
        [Category("Ribbon Design")]
        public Position Position { get; set; }
        [Category("Ribbon Design")]
        public HatchStyle HatchStyle { get; set; }

        public RibbonGroupBox()
        {
            GetRibbonGroupBoxDesigner = new RibbonGroupBoxDesigner(this);
            DoubleBuffered = true;
        }

        public void UpdateDesign(ColorTable Colores)
        {
            GetRibbonGroupBoxDesigner.UpdateDesign(Colores);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GetRibbonGroupBoxDesigner.OnPaint(e);
        }
    }
}