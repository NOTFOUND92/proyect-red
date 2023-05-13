using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace System.Windows.Forms
{
	public class ToolStripRendererBlue:ToolStripRenderer,IToolStripRenderer
	{
		#region Variables
		static Bitmap titleBarGripBmp;
		static Color  titlebarColor1 = Color.FromArgb(255, 255, 255);
		static Color  titlebarColor2 = Color.FromArgb(227, 239, 255);
		static Color  titlebarColor3 = Color.FromArgb(218, 234, 255);
		static Color  titlebarColor4 = Color.FromArgb(209, 229, 255);
		static Color  titlebarColor5 = Color.FromArgb(200, 224, 255);
		static Color  titlebarColor6 = Color.FromArgb(191, 219, 255);
		static Color  titlebarColor7 = Color.FromArgb(182, 214, 255);
		static Color  borderColors   = Color.FromArgb(138, 177, 219); // Color.FromArgb(101,147,207);
		static LinearGradientBrush brush;
		
		Color colorBegin1;
		Color colorEnd1;
		Color colorBegin2;
		Color colorEnd2;
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
		public ToolStripRendererBlue()
		{		
			titleBarGripBmp = Funciones.DeserializeFromBase64(ImageBase64.titleBarGripBlu);
			BordeColor 	 	= borderColors;
            TitleForeColor  = Color.FromArgb(59, 66, 139);
            ButtonForeColor = Color.FromArgb(66, 77, 137);
            ButtonForeColorSelect = Color.FromArgb(0,0,0);
			BrushHeaderTitle = new LinearGradientBrush(new Rectangle(0, 0, 259, 28), Color.FromArgb(224,237,255), Color.FromArgb(185,216,255), LinearGradientMode.Vertical);
			BrushBar = new LinearGradientBrush(new Rectangle(0, 0, 40, 1500), Color.FromArgb(220, 235, 255), Color.FromArgb(181, 213, 255), LinearGradientMode.Horizontal);
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
					
			colorBegin1 = Color.FromArgb(224, 237, 255);
			colorEnd1 	= Color.FromArgb(199, 223, 255);
			colorBegin2 = Color.FromArgb(176, 210, 255);
			colorEnd2	= Color.FromArgb(190, 218, 255);
		
			ToolStripButton button = e.Item as ToolStripButton;
			if (button.Pressed || button.Checked) {
				colorBegin1 = Color.FromArgb(255, 214, 164);
				colorEnd1 	= Color.FromArgb(255, 192, 121);
				colorBegin2 = Color.FromArgb(254, 177, 69);
				colorEnd2 	= Color.FromArgb(254, 216, 112);
			} else if (button.Selected) {
				colorBegin1 = Color.FromArgb(255, 250, 217);
				colorEnd1 	= Color.FromArgb(255, 236, 178);
				colorBegin2 = Color.FromArgb(255, 217, 112);
				colorEnd2 	= Color.FromArgb(255, 227, 149);
			}
			
			if (button.Pressed || button.Checked) 
				button.ForeColor=ButtonForeColorSelect;
			else
				button.ForeColor=ButtonForeColor;
					
			DrawTitleBar2(g, button);		
			
			e.Graphics.DrawRectangle(new Pen(borderColors), bounds);
			
			ToolStrip toolStrip = button.Owner;
			ToolStripButton nextItem = button.Owner.GetItemAt(button.Bounds.X, button.Bounds.Bottom + 1) as ToolStripButton;
			
			if (nextItem == null) {g.DrawLine(new Pen(borderColors),bounds.X,bounds.Height - 1,bounds.X + bounds.Width - 1,bounds.Height - 1);
			}
		}
		#endregion
	}
}
