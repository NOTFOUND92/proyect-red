using System.ComponentModel;
using System.Drawing;

namespace System.Windows.Forms
{
	public class Ribbon : Panel, IRibbonDesign
	{
		RibbonDesigner GetRibbonDesigner;

		[Category("Ribbon Design")]
		public Color TopColor1 { get; set; }
		[Category("Ribbon Design")]
		public Color TopColor2 { get; set; }
		[Category("Ribbon Design")]
		public Color BottomColor1 { get; set; }
		[Category("Ribbon Design")]
		public Color BottomColor2 { get; set; }
		[Category("Ribbon Design")]
		public Color BorderColor { get; set; }
		[Category("Ribbon Design")]
		public bool ChangeSkin { get; set; }
		[Category("Ribbon Design")]
		public int Curvate { get; set; }
		[Category("Ribbon Design")]
		public int ColorHeight { get; set; }

		public Ribbon()
		{
			GetRibbonDesigner = new RibbonDesigner(this);
			DoubleBuffered = true;
		}

		public void UpdateDesign(ColorTable Colores)
		{
			GetRibbonDesigner.UpdateDesign(Colores);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			GetRibbonDesigner.OnPaint(e);
		}
	}
}