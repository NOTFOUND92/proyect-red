using System.Drawing;
using System.Drawing.Drawing2D;

namespace System.Windows.Forms
{
	public interface IToolStripRenderer
	{
		Color BordeColor { get; set; }
		Color TitleForeColor { get; set; }
		Color ButtonForeColor { get; set; }
		Color ButtonForeColorSelect { get; set; }
		LinearGradientBrush BrushBar { get; set; }
		LinearGradientBrush BrushHeaderTitle { get; set; }
	}
}