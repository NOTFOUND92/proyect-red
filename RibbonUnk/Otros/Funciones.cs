using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;

namespace System.Windows.Forms
{
	public static class Funciones
	{
		public static T IIF<T>(bool Condition, T True, T False)
		{
			if (Condition)
				return True;
			else
				return False;
		}

		public static void mb(string Description)
		{
			MessageBox.Show(Description, "Ayuda :");
		}

		public static GraphicsPath GetRoundRectagle(Rectangle b, int r)
		{
			GraphicsPath path = new GraphicsPath();
			path.AddArc(b.X, b.Y, r, r, 180, 90);
			path.AddArc(b.X + b.Width - r - 1, b.Y, r, r, 270, 90);
			path.AddArc(b.X + b.Width - r - 1, b.Y + b.Height - r - 1, r, r, 0, 90);
			path.AddArc(b.X, b.Y + b.Height - r - 1, r, r, 90, 90);
			path.CloseAllFigures();
			return path;
		}

		public static string SerializeFromBase64()
		{
			OpenFileDialog Opf = new OpenFileDialog();
			Opf.ShowDialog();

			if (string.IsNullOrEmpty(Opf.FileName))
				return "";

			byte[] imageArray = File.ReadAllBytes(Opf.FileName);
			string base64ImageRepresentation = Convert.ToBase64String(imageArray);
			return base64ImageRepresentation;
		}

		public static Bitmap DeserializeFromBase64(string data)
		{
			MemoryStream stream = new MemoryStream(Convert.FromBase64String(data));
			Bitmap b = new Bitmap(stream);
			return b;
		}

		public static void ShowNotification(Form Frm, Control Contenedor)
		{
			//#VERIFICAR TENGAS UN STATUS STRIP EL CONTENEDOR PARENT
			Int32 Cont = 0;
			foreach (Control item in Contenedor.Controls)
			{
				if (item is StatusStrip)
					if (((StatusStrip)item).Dock == DockStyle.Bottom)
					{
						Cont = ((StatusStrip)item).Height;
						break;
					}
			}

			//#obtener LA UBICACION
			Int32 lx, ly;
			lx = Contenedor.Width - Frm.Width - 17;
			ly = Contenedor.Height;

			//#ASIGNAR LA UBICACION
			Frm.TopLevel = false;
			Frm.Parent = Contenedor;
			Frm.FormBorderStyle = FormBorderStyle.FixedSingle;
			Frm.Location = new Point(lx, ly);
			Frm.LocationChanged += delegate
			{
				Frm.Refresh();
			};
			Frm.Show();

			Frm.BringToFront();

			//#MOVIMIETO DEL FORMULARIO
			for (int i = 1; i < Frm.Height + Cont + 42; i++)
				Frm.Location = new Point(lx, ly--);

			Frm.BringToFront();
		}

        public static void ShowNotification(String Descripcion, Control Contenedor, Image Imagen = null, string TextLink = null, EventHandler e = null)
        {
            RibbonNotification FrmNotifi = new RibbonNotification();
            FrmNotifi.Text = "Notificación";

            if (Memory.ColorTable.FormRibbonColor.ControlBoxImagen is null)
            {
                FrmNotifi.ColorRibbon = Memory.ColorTable.FormRibbonColor.ColorRibbon;
            }
            else
            {
                FrmNotifi.ControlBoxImagen = Memory.ColorTable.FormRibbonColor.ControlBoxImagen;
            }
            FrmNotifi.Descripcion = Descripcion;
            FrmNotifi.Imagen = Imagen;
            FrmNotifi.TextLink = TextLink;


            if (e != null)
                FrmNotifi.Manejador += new EventHandler(e);


            ShowNotification(FrmNotifi, Contenedor);
        }

        public static Bitmap PaintControlBox(Color ColorBegin1, Color ColorEnd1, Color ColorBegin2, Color ColorEnd2, Color ColorBorde)
		{
			LinearGradientBrush linGrBrush;
            //Bitmap Bitmp = new Bitmap(8000, 26);
            Bitmap Bitmp = new Bitmap(8000, 25);
            Graphics Grafico = Graphics.FromImage(Bitmp);
			RectangleF RecF = new RectangleF(new Point(0, 0), new Size(8000, 12));

			linGrBrush = new LinearGradientBrush(new Rectangle(0, 0, 8000, (26 / 2) - 3), ColorBegin1, ColorEnd1, LinearGradientMode.Vertical);
			Grafico.FillRectangle(linGrBrush, new Rectangle(0, 0, 8000, (26 / 2) - 3));

			linGrBrush = new LinearGradientBrush(new Rectangle(0, (26 / 2) - 3, 8000, (26 / 2) + 3), ColorBegin2, ColorEnd1, LinearGradientMode.Vertical);
			Grafico.FillRectangle(linGrBrush, new Rectangle(0, (26 / 2) - 3, 8000, (26 / 2) + 4));

			Grafico.DrawRectangle(new Pen(ColorBorde), new Rectangle(0, 25, 8000, 1));

			linGrBrush.Dispose();
			Grafico.Dispose();
			return Bitmp;
		}
	}
}