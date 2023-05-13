using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace System.Windows.Forms
{
    public class RibbonPanelEffect : Panel, IRibbonDesign
    {
        RibbonPanelEffectDesigner GetRibbonPanelEffectDesigner;

        [Category("Ribbon Design")]
        public bool ChangeSkin { get; set; }
        [Category("Ribbon Design")]
        public string Title { get; set; }
        [Category("Ribbon Design")]
        public int Curvate { get; set; }
        [Category("Ribbon Design")]
        public Font TitleFont { get; set; }
        [Category("Ribbon Design")]
        public Color BorderColor { get; set; }
        [Category("Ribbon Design")]
        public Color TitleForeColor { get; set; }
        [Category("Ribbon Design")]
        public Color TitleBackColor { get; set; }
        [Category("Ribbon Design")]
        public Color BackColorFocus { get; set; }
        [Category("Ribbon Design")]
        public Color BackColorClick { get; set; }
        Color backColor;
        [Category("Ribbon Design")]
        public Color BackGroundColor { get { return backColor; } set { backColor = value; BackColor = value; } }
        [Category("Ribbon Design")]
        public Position Position { get; set; }
        [Category("Ribbon Design")]
        public HatchStyle TitleHatchStyle { get; set; }

        public RibbonPanelEffect()
        {
            GetRibbonPanelEffectDesigner = new RibbonPanelEffectDesigner(this);
            DoubleBuffered = true;
        }

        public void UpdateDesign(ColorTable Colores)
        {
            GetRibbonPanelEffectDesigner.UpdateDesign(Colores);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GetRibbonPanelEffectDesigner.OnPaint(e);
        }
    }
}