using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace System.Windows.Forms
{
    public class RibbonPanelMdi : Panel, IRibbonDesign
    {
        RibbonPanelMdiDesigner GetRibbonPanelMdiDesigner;

        [Category("Ribbon Design")]
        public bool ChangeSkin { get; set; }
        [Category("Ribbon Design")]
        public bool AjustarForms { get; set; }
        [Category("Ribbon Design")]
        public Color BorderColor { get; set; }
        [Category("Ribbon Design")]
        public Color ColorInicial { get; set; }
        [Category("Ribbon Design")]
        public Color ColorFinal { get; set; }
        [Category("Ribbon Design")]
        public LinearGradientMode GradientMode { get; set; }

        public RibbonPanelMdi()
        {
            GetRibbonPanelMdiDesigner = new RibbonPanelMdiDesigner(this);
            DoubleBuffered = true;
        }

        public void UpdateDesign(ColorTable Colores)
        {
            GetRibbonPanelMdiDesigner.UpdateDesign(Colores);
        }

        public void Showform(Form frm)
        {
            GetRibbonPanelMdiDesigner.Showform(frm);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GetRibbonPanelMdiDesigner.OnPaint(e);
        }
    }
}