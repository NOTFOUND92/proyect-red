using System.Drawing.Drawing2D;

namespace System.Windows.Forms
{
	public class RibbonPanelMdiDesigner
	{
		RibbonPanelMdi GetRibbon;
		ColorTable ColorTable;

		public RibbonPanelMdiDesigner(RibbonPanelMdi ribbon)
		{
			GetRibbon = ribbon;
			PropertiesDefault();
		}

		private void PropertiesDefault()
		{
			GetRibbon.ChangeSkin = false;
			GetRibbon.AjustarForms = false;
			GetRibbon.GradientMode = LinearGradientMode.Vertical;
			GetRibbon.Paint += RibbonPaint;
			GetRibbon.SizeChanged += RibbonSizeChanged;
		}

		public void UpdateDesign(ColorTable Colores)
		{
			ColorTable = Colores;

			if (GetRibbon.ChangeSkin && ColorTable != null)
			{
				GetRibbon.BorderColor = ColorTable.PanelMdiColor.BorderColor;
				GetRibbon.ColorInicial = ColorTable.PanelMdiColor.TopColor;
				GetRibbon.ColorFinal = ColorTable.PanelMdiColor.BottomColor;
			}
		}

		public void Showform(Form frm)
		{
			frm.StartPosition = FormStartPosition.CenterParent;
			frm.TopLevel = false;
			frm.Parent = GetRibbon;
			frm.Show();
			frm.BringToFront();
		}

		private void RibbonPaint(object sender, PaintEventArgs e)
		{
			if (GetRibbon.ChangeSkin)
				UpdateDesign(ColorTable);
		}

		public void OnPaint(PaintEventArgs e)
		{
			ColorsDrawing.DrawLinearGradient(e, GetRibbon, GetRibbon.ColorInicial, GetRibbon.ColorFinal, GetRibbon.BorderColor, GetRibbon.GradientMode);
		}

		public void RibbonSizeChanged(object sender, EventArgs e)
		{
			GetRibbon.Refresh();

			if (GetRibbon.AjustarForms)
			{
				foreach (Control frm in GetRibbon.Controls)
				{
					if (frm is Form)
					{
						if (((Form)frm).WindowState == FormWindowState.Maximized)
						{
							((Form)frm).WindowState = FormWindowState.Normal;
							((Form)frm).WindowState = FormWindowState.Maximized;
						}
						if (((Form)frm).WindowState == FormWindowState.Minimized)
						{
							((Form)frm).WindowState = FormWindowState.Normal;
							((Form)frm).WindowState = FormWindowState.Minimized;
						}
					}
				}
			}
		}
	}
}