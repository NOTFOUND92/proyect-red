using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace System.Windows.Forms
{
	public class ToolStripRendererUnknow:ToolStripRenderer,IToolStripRenderer
	{
		#region Variables
		static Bitmap titleBarGripBmp;
		static Color  titlebarColor1 = Color.FromArgb(89, 135, 214);
		static Color  titlebarColor2 = Color.FromArgb(76, 123, 204);
		static Color  titlebarColor3 = Color.FromArgb(63, 111, 194);
		static Color  titlebarColor4 = Color.FromArgb(50, 99, 184);
		static Color  titlebarColor5 = Color.FromArgb(38, 88, 174);
		static Color  titlebarColor6 = Color.FromArgb(25, 76, 164);
		static Color  titlebarColor7 = Color.FromArgb(12, 64, 154);
		static Color  borderColors   = Color.FromArgb(0, 45, 150);
		#endregion
		
		#region Propiedades
		public Color BordeColor      
		{ get; set; }
		
		public Color TitleForeColor  
		{ get; set; }
		
		public Color ButtonForeColor 
		{ get; set; }
		
		public Color ButtonForeColorSelect
		{ get; set; }
		
		public LinearGradientBrush BrushHeaderTitle 
		{ get; set; }
		
		public LinearGradientBrush BrushBar 
		{ get; set; }
		#endregion
		
		#region Constructor
		public ToolStripRendererUnknow()
		{
			titleBarGripBmp = Funciones.DeserializeFromBase64(ImageBase64.titleBarGripEnc);
			BordeColor 		= borderColors;
			TitleForeColor	= Color.FromArgb(255, 255, 255);
			ButtonForeColor = Color.FromArgb(0, 0, 0);
			ButtonForeColorSelect = Color.FromArgb(0,0,0);
			BrushHeaderTitle = new LinearGradientBrush(new Rectangle(0, 0, 259, 28), Color.FromArgb(85, 131, 211), Color.FromArgb(11, 63, 153), LinearGradientMode.Vertical);
			BrushBar = new LinearGradientBrush(new Rectangle(0, 0, 40, 1500), Color.FromArgb(79, 126, 206), Color.FromArgb(85, 131, 211), LinearGradientMode.Horizontal);
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
		
			g.DrawImage(titlebarGrip,new Point(rect.X + ((rect.Width / 2) - (titlebarGrip.Width / 2)),rect.Y + 1));
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
		
			Color gradientBegin = Color.FromArgb(190, 215, 247);
			Color gradientEnd   = Color.FromArgb(133, 172, 228);
		
			ToolStripButton button = e.Item as ToolStripButton;
			if (button.Pressed || button.Checked) {
				gradientBegin = Color.FromArgb(251, 230, 148);
				gradientEnd   = Color.FromArgb(240, 160, 38);
			} else if (button.Selected) {
				gradientBegin = Color.FromArgb(254, 251, 211);
				gradientEnd   = Color.FromArgb(248, 198, 104);
			}
		
			using (Brush b = new LinearGradientBrush(bounds,gradientBegin,gradientEnd,LinearGradientMode.Vertical)) {
				g.FillRectangle(b, bounds);
			}
			
			if (button.Pressed || button.Checked) 
				button.ForeColor=ButtonForeColorSelect;
			else 
				button.ForeColor=ButtonForeColor;
		
			e.Graphics.DrawRectangle(new Pen(borderColors),bounds);
		
			g.DrawLine(new Pen(borderColors),bounds.X,bounds.Y,bounds.Width - 1,bounds.Y);
		
			g.DrawLine(new Pen(borderColors),bounds.X,bounds.Y,bounds.X,bounds.Height - 1);
		
			ToolStrip toolStrip = button.Owner;
			ToolStripButton nextItem = button.Owner.GetItemAt(button.Bounds.X,button.Bounds.Bottom + 1) as ToolStripButton;

			if (nextItem == null) {
				g.DrawLine(new Pen(borderColors),bounds.X,bounds.Height - 1,bounds.X + bounds.Width - 1,bounds.Height - 1);
			}
		}
		#endregion
	}
}
