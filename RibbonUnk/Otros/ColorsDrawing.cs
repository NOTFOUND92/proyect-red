using System.Drawing;
using System.Drawing.Drawing2D;

namespace System.Windows.Forms
{
    public static class ColorsDrawing
    {
        static Rectangle Recta;
        static Rectangle Rectb;
        static int HeightColor;

        public static void DrawStatusStripGradient(PaintEventArgs e, Control sender, Color[] Colores)
        {
            Recta = new Rectangle(0, 0, sender.Width, (sender.Height / 2) - 2);
            Rectb = new Rectangle(0, (sender.Height / 2) - 3, sender.Width, (sender.Height / 2) + 2);

            using (LinearGradientBrush linGrBrush = new LinearGradientBrush(Recta, Colores[0], Colores[1], LinearGradientMode.Vertical))
                e.Graphics.FillRectangle(linGrBrush, Recta);

            using (LinearGradientBrush linGrBrush = new LinearGradientBrush(Rectb, Colores[2], Colores[3], LinearGradientMode.Vertical))
                e.Graphics.FillRectangle(linGrBrush, Rectb.X, Rectb.Y, Rectb.Width, Rectb.Height + 1);

            ControlPaint.DrawBorder(e.Graphics, sender.ClientRectangle, Colores[4], ButtonBorderStyle.Solid);
        }

        public static void GradientDrawing(PaintEventArgs e, Control sender, Color[] Colores, int heightColor = 0, bool DrawBorder = false, int Curvate = 1)
        {
            HeightColor = (heightColor > 0) ? heightColor : (sender.Height / 2);

            Recta = new Rectangle(1, 1, sender.Width, HeightColor);
            Rectb = new Rectangle(1, Recta.Y + Recta.Height, sender.Width, sender.Height - Recta.Height - 1);

            using (var Brusha = new LinearGradientBrush(Recta, Colores[0], Colores[1], LinearGradientMode.Vertical)) // Pintar los 2 Primeros colores Degradados
                e.Graphics.FillRectangle(Brusha, Recta);

            using (var Brushb = new LinearGradientBrush(Rectb, Colores[2], Colores[3], LinearGradientMode.Vertical)) //Pintar los segundos colores Degradados
                e.Graphics.FillRectangle(Brushb, Rectb);

            if (DrawBorder) //Dibujar el Borde con Curva si a sido asignado
            {
                using (var path = Funciones.GetRoundRectagle(sender.ClientRectangle, Curvate))
                {
                    using (var pen = new Pen(Colores[4]))
                        e.Graphics.DrawPath(pen, path);
                }
            }
        }

        public static void DrawGroupBox(PaintEventArgs e, Control sender, string Title, Color[] Colores, HatchStyle hatchStyle, Position position = Position.Down, int Curvate = 1)
        {
            GroupBoxRenderer.DrawParentBackground(e.Graphics, sender.ClientRectangle, sender);
            var rect = sender.ClientRectangle;

            using (var path = Funciones.GetRoundRectagle(sender.ClientRectangle, Curvate))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                if (position == Position.Up)
                    rect = new Rectangle(0, 0, rect.Width, (sender as RibbonGroupBox).TitleFont.Height + sender.Padding.Bottom + sender.Padding.Top);
                else
                    rect = new Rectangle(0, sender.Height - ((sender as RibbonGroupBox).TitleFont.Height + sender.Padding.Bottom + sender.Padding.Top), rect.Width, (sender as RibbonGroupBox).TitleFont.Height + sender.Padding.Bottom + sender.Padding.Top);

                if (sender.BackColor != Color.Transparent)
                    using (var brush = new SolidBrush(sender.BackColor))
                        e.Graphics.FillPath(brush, path);

                var clip = e.Graphics.ClipBounds;
                e.Graphics.SetClip(rect);

                using (var brush = new HatchBrush(hatchStyle, Colores[2], ControlPaint.Light(Colores[2])))
                    e.Graphics.FillPath(brush, path);
                using (var pen = new Pen(Colores[2], 1))
                    e.Graphics.DrawPath(pen, path);

                TextRenderer.DrawText(e.Graphics, Title, (sender as RibbonGroupBox).TitleFont, rect, Colores[3]);
                e.Graphics.SetClip(clip);

                using (var pen = new Pen(Colores[1], 1))
                    e.Graphics.DrawPath(pen, path);
            }
        }

        public static void DrawPanelEffect(PaintEventArgs e, Control sender, string Title, Color[] Colores, HatchStyle hatchStyle, Position position = Position.Down, int Curvate = 1)
        {
            GroupBoxRenderer.DrawParentBackground(e.Graphics, sender.ClientRectangle, sender);
            var rect = sender.ClientRectangle;

            using (var path = Funciones.GetRoundRectagle(sender.ClientRectangle, Curvate))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                if (position == Position.Up)
                    rect = new Rectangle(0, 0, rect.Width, (sender as RibbonPanelEffect).TitleFont.Height + sender.Padding.Bottom + sender.Padding.Top + 6);
                if (position == Position.Down)
                    rect = new Rectangle(0, sender.Height - ((sender as RibbonPanelEffect).TitleFont.Height + sender.Padding.Bottom + sender.Padding.Top) - 6, rect.Width, (sender as RibbonPanelEffect).TitleFont.Height + sender.Padding.Bottom + sender.Padding.Top + 6);
                if (position == Position.Left)
                    rect = new Rectangle(0, 0, 27, sender.Height);
                if (position == Position.Right)
                    rect = new Rectangle(sender.Width - (20 + sender.Padding.Left + sender.Padding.Right) - 6, 0, 27, sender.Height);

                if (sender.BackColor != Color.Transparent)
                    using (var brush = new SolidBrush(sender.BackColor))
                        e.Graphics.FillPath(brush, path);

                var clip = e.Graphics.ClipBounds;
                e.Graphics.SetClip(rect);

                e.Graphics.FillPath(new SolidBrush(Colores[2]), path);
                using (var pen = new Pen(Colores[2], 1))
                    e.Graphics.DrawPath(pen, path);

                if (position == Position.Up || position == Position.Down)
                    TextRenderer.DrawText(e.Graphics, Title, (sender as RibbonPanelEffect).TitleFont, rect, Colores[1]);

                e.Graphics.SetClip(clip);

                using (var pen = new Pen(Colores[0], 1))
                    e.Graphics.DrawPath(pen, path);

                PointF pointF = new PointF();
                if (position == Position.Left)
                    pointF = new PointF(0 + 5, sender.Height / 2 / 2);
                if (position == Position.Right)
                    pointF = new PointF(sender.Width - 20, sender.Height / 2 / 2);

                StringFormat stringformat = new StringFormat();
                SolidBrush solidbrush = new SolidBrush(Colores[1]);
                stringformat.FormatFlags = StringFormatFlags.DirectionVertical;

                if (position == Position.Left || position == Position.Right)
                    e.Graphics.DrawString(Title, (sender as RibbonPanelEffect).TitleFont, solidbrush, pointF, stringformat);
            }
        }

        public static void DrawLinearGradient(PaintEventArgs e, Control sender, Color ColorTop, Color ColorBottom, Color BorderColor, LinearGradientMode linearGradientMode)
        {
            if (ColorTop != null && ColorBottom != null)
            {
                using (LinearGradientBrush linGrBrush = new LinearGradientBrush(sender.ClientRectangle, ColorTop, ColorBottom, linearGradientMode))
                {
                    e.Graphics.FillRectangle(linGrBrush, 0, 0, 5000, 1000);
                }
            }
            ControlPaint.DrawBorder(e.Graphics, sender.DisplayRectangle, BorderColor, ButtonBorderStyle.Solid);
        }
    }
}