using System.ComponentModel;
using System.Drawing;

namespace System.Windows.Forms
{
    public class RibbonPanel : Panel, IRibbonDesign
    {
        RibbonPanelDesigner GetRibbonPanelDesigner;
        internal Color cBorderColorInit;
        internal Color cBorderColorFocus;
        internal Color cBackGroundinit;
        internal Color cBackGroundFocus;
        internal Color cBackGroundClick;
        bool checkonclick;
        bool checkedvalue;

        [Category("Ribbon Design")]
        public bool CheckOnClick
        {
            get { return checkonclick; }
            set
            {
                checkonclick = value;
                ActivateChecked();
            }
        }

        [Category("Ribbon Design")]
        public bool Checked
        {
            get { return checkedvalue; }
            set
            {
                checkedvalue = value;
                ActivateChecked();
            }
        }

        void ActivateChecked()
        {
            if (checkonclick)
                if (checkedvalue)
                    BackColor = BackGroundColorClick;
                else
                    BackGroundColor = Color.Transparent;
        }

        [Category("Ribbon Design")]
        public Color BackGroundColor
        {
            get { return cBackGroundinit; }
            set
            {
                cBackGroundinit = value;
                BackColor = cBackGroundinit;
            }
        }

        Image image;
        [Category("Ribbon Design")]
        public Image Imagen
        {
            get { return image; }
            set { image = value; BackgroundImage = image; }
        }

        [Category("Ribbon Design")]
        public int EffectSizeBig { get; set; }
        [Category("Ribbon Design")]
        public bool ChangeSkin { get; set; }
        [Category("Ribbon Design")]
        public bool Border { get; set; }
        [Category("Ribbon Design")]
        public Image ImagenOnClick { get; set; }
        [Category("Ribbon Design")]
        public bool AplicateStyle { get; set; }
        [Category("Ribbon Design")]
        public Color BorderColor { get => cBorderColorInit; set => cBorderColorInit = value; }
        [Category("Ribbon Design")]
        public Color BorderColorFocus { get => cBorderColorFocus; set => cBorderColorFocus = value; }
        [Category("Ribbon Design")]
        public Color BackGroundColorFocus { get => cBackGroundFocus; set => cBackGroundFocus = value; }
        [Category("Ribbon Design")]
        public Color BackGroundColorClick { get => cBackGroundClick; set => cBackGroundClick = value; }

        public RibbonPanel()
        {
            GetRibbonPanelDesigner = new RibbonPanelDesigner(this);
            DoubleBuffered = true;
        }

        public void UpdateDesign(ColorTable Colores)
        {
            GetRibbonPanelDesigner.UpdateDesign(Colores);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GetRibbonPanelDesigner.OnPaint(e);
        }
    }
}