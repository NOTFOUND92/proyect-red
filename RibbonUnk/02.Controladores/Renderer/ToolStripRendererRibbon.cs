using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace System.Windows.Forms
{
    public class ToolStripRendererRibbon : ToolStripRenderer, IToolStripRenderer
    {
        #region Variables
        /// <summary>
        ///  titleBarGripBmp = Funciones.DeserializeFromBase64(ImageBase64.titleBarGripBlc);
        /// </summary>
        public static Bitmap titleBarGripBmp;
        public static Color titlebarColor1 { get; set; } 
        public static Color titlebarColor2 { get; set; } 
        public static Color titlebarColor3 { get; set; }
        public static Color titlebarColor4 { get; set; }
        public static Color titlebarColor5 { get; set; }
        public static Color titlebarColor6 { get; set; }
        public static Color titlebarColor7 { get; set; }

        static LinearGradientBrush brush;
        Color colorBegin1;
        Color colorEnd1;
        Color colorBegin2;
        Color colorEnd2;
        #endregion

        #region Propiedades
        [Browsable(false)]
        public LinearGradientBrush BrushBar { get; set; }
        [Browsable(false)]
        public LinearGradientBrush BrushHeaderTitle { get; set; }

        public Color BordeColor
        { get; set; }

        public Color TitleForeColor
        { get; set; }

        public Color ButtonForeColor
        { get; set; }

        public Color ButtonForeColorSelect
        { get; set; }

        public Color ButtonColorTop1
        { get; set; }

        public Color ButtonColorBottom1
        { get; set; }

        public Color ButtonColorTop2
        { get; set; }

        public Color ButtonColorBottom2
        { get; set; }

        public Color ButtonColorPressedTop1
        { get; set; }

        public Color ButtonColorPressedBottom1
        { get; set; }

        public Color ButtonColorPressedTop2
        { get; set; }

        public Color ButtonColorPressedBottom2
        { get; set; }

        public Color ButtonColorSelectedTop1
        { get; set; }

        public Color ButtonColorSelectedBottom1
        { get; set; }

        public Color ButtonColorSelectedTop2
        { get; set; }

        public Color ButtonColorSelectedBottom2
        { get; set; }

        public Color BrushHeaderTitleColor1
        { get; set; }

        public Color BrushHeaderTitleColor2
        { get; set; }

        public Color BrushBarTitleColor1
        { get; set; }

        public Color BrushBarTitleColor2
        { get; set; }
        #endregion

        #region Constructor
        public ToolStripRendererRibbon()
        {
            BrushHeaderTitle = new LinearGradientBrush(new Rectangle(0, 0, 259, 28), BrushHeaderTitleColor1, BrushHeaderTitleColor2, LinearGradientMode.Vertical);
            BrushBar = new LinearGradientBrush(new Rectangle(0, 0, 40, 1500), BrushBarTitleColor1, BrushBarTitleColor2, LinearGradientMode.Horizontal);
        }
        #endregion

        #region Metodos y Eventos
        private void DrawTitleBar(Graphics g, Rectangle rect)
        {
            Image titlebarGrip = titleBarGripBmp;

            g.DrawLine(new Pen(titlebarColor1), rect.X, rect.Y, rect.X + rect.Width, rect.Y);
            g.DrawLine(new Pen(titlebarColor2), rect.X, rect.Y + 1, rect.X + rect.Width, rect.Y + 1);
            g.DrawLine(new Pen(titlebarColor3), rect.X, rect.Y + 2, rect.X + rect.Width, rect.Y + 2);
            g.DrawLine(new Pen(titlebarColor4), rect.X, rect.Y + 3, rect.X + rect.Width, rect.Y + 3);
            g.DrawLine(new Pen(titlebarColor5), rect.X, rect.Y + 4, rect.X + rect.Width, rect.Y + 4);
            g.DrawLine(new Pen(titlebarColor6), rect.X, rect.Y + 5, rect.X + rect.Width, rect.Y + 5);
            g.DrawLine(new Pen(titlebarColor7), rect.X, rect.Y + 6, rect.X + rect.Width, rect.Y + 6);

            g.DrawImage(titlebarGrip, new Point(rect.X + ((rect.Width / 2) - (titlebarGrip.Width / 2)), rect.Y + 1));
        }

        private void DrawTitleBar2(Graphics g, ToolStripButton rect)
        {
            brush = new LinearGradientBrush(new Rectangle(0, 0, rect.Width, (rect.Height / 2) - 3), colorBegin1, colorEnd1, LinearGradientMode.Vertical);
            g.FillRectangle(brush, new Rectangle(0, 0, rect.Width, (rect.Height / 2) - 3));

            brush = new LinearGradientBrush(new Rectangle(0, (rect.Height / 2) - 3, rect.Width, (rect.Height / 2) + 3), colorBegin2, colorEnd2, LinearGradientMode.Vertical);
            g.FillRectangle(brush, new Rectangle(0, (rect.Height / 2) - 3, rect.Width, (rect.Height / 2) + 4));
        }

        protected override void OnRenderGrip(ToolStripGripRenderEventArgs e)
        {
            DrawTitleBar(e.Graphics, new Rectangle(0, 0, e.ToolStrip.Width, 7));
        }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            DrawTitleBar(e.Graphics, new Rectangle(0, 0, e.ToolStrip.Width, 7));
        }

        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle bounds = new Rectangle(Point.Empty, e.Item.Size);

            colorBegin1 = ButtonColorTop1;
            colorEnd1   = ButtonColorBottom1;
            colorBegin2 = ButtonColorTop2;
            colorEnd2   = ButtonColorBottom2;

            ToolStripButton button = e.Item as ToolStripButton;
            if (button.Pressed || button.Checked)
            {
                colorBegin1 = ButtonColorPressedTop1;
                colorEnd1   = ButtonColorPressedBottom1;
                colorBegin2 = ButtonColorPressedTop2;
                colorEnd2   = ButtonColorPressedBottom2;
            }
            else if (button.Selected)
            {
                colorBegin1 = ButtonColorSelectedTop1;
                colorEnd1   = ButtonColorSelectedBottom1;
                colorBegin2 = ButtonColorSelectedTop2;
                colorEnd2   = ButtonColorSelectedBottom2;
            }

            if (button.Pressed || button.Checked)
                button.ForeColor = ButtonForeColorSelect;
            else
                button.ForeColor = ButtonForeColor;

            DrawTitleBar2(g, button);

            e.Graphics.DrawRectangle(new Pen(BordeColor), bounds);

            ToolStrip toolStrip = button.Owner;
            ToolStripButton nextItem = button.Owner.GetItemAt(button.Bounds.X, button.Bounds.Bottom + 1) as ToolStripButton;

            if (nextItem == null)
            {
                g.DrawLine(new Pen(BordeColor), bounds.X, bounds.Height - 1, bounds.X + bounds.Width - 1, bounds.Height - 1);
            }
        }
        #endregion
    }
}

