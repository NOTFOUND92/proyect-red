using System.Drawing;

namespace System.Windows.Forms
{
	public class RibbonSeparatorDesigner
	{
		RibbonSeparator GetRibbon;
		ColorTable ColorTable;

		public RibbonSeparatorDesigner(RibbonSeparator ribbon)
		{
			GetRibbon = ribbon;
			PropertiesDefault();
		}

		private void PropertiesDefault()
		{
			GetRibbon.ChangeSkin = false;
			GetRibbon.Size = new Size(1, 40);
			GetRibbon.MaximumSize = new Size(1, 70);
			GetRibbon.BackColor = Color.DarkCyan;
			GetRibbon.Paint += RibbonPaint;
		}

		public void UpdateDesign(ColorTable Colores)
		{
			ColorTable = Colores;

			if (GetRibbon.ChangeSkin && ColorTable != null)
				GetRibbon.BackColor = ColorTable.SeparatorColor.BackColor;
		}

		private void RibbonPaint(object sender, PaintEventArgs e)
		{
			if (GetRibbon.ChangeSkin)
				UpdateDesign(ColorTable);
		}
	}
}