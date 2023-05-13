namespace System.Windows.Forms
{
    public class RibbonPanelDesigner
    {
        Drawing.Point DfPoint;
        Drawing.Size DfSize;
        RibbonPanel GetRibbon;
        ColorTable ColorTable;
        bool GoFocus;

        public RibbonPanelDesigner(RibbonPanel ribbon)
        {
            GetRibbon = ribbon;
            PropertiesDefault();
        }

        private void PropertiesDefault()
        {
            GetRibbon.Checked = false;
            GetRibbon.Border = false;
            GetRibbon.ChangeSkin = false;
            GetRibbon.CheckOnClick = false;
            GetRibbon.AplicateStyle = false;
            GetRibbon.EffectSizeBig = 0;

            GetRibbon.Paint += RibbonPaint;
            GetRibbon.Click += RibbonClick;
            GetRibbon.MouseDown += RibbonMouseDown;
            GetRibbon.MouseMove += RibbonMouseMove;
            GetRibbon.MouseLeave += RibbonMouseLeave;
            GetRibbon.MouseHover += RibbonMouseHover;
        }

        public void UpdateDesign(ColorTable Colores)
        {
            ColorTable = Colores;

            if (GetRibbon.ChangeSkin && ColorTable != null)
            {
                GetRibbon.cBorderColorInit = ColorTable.PanelColor.BorderColorInit;
                GetRibbon.cBorderColorFocus = ColorTable.PanelColor.BorderColorFocus;
                GetRibbon.cBackGroundinit = ColorTable.PanelColor.BackGroundInit;
                GetRibbon.cBackGroundFocus = ColorTable.PanelColor.BackGroundFocus;
                GetRibbon.cBackGroundClick = ColorTable.PanelColor.BackGroundClick;
            }
        }

        private void RibbonClick(object sender, EventArgs e)
        {
            if (GetRibbon.Imagen != null && GetRibbon.ImagenOnClick != null)
            {
                if (GetRibbon.BackgroundImage == GetRibbon.Imagen)
                    GetRibbon.BackgroundImage = GetRibbon.ImagenOnClick;
                else
                    GetRibbon.BackgroundImage = GetRibbon.Imagen;
            }
        }

        private void RibbonMouseMove(object sender, MouseEventArgs e)
        {
            GoFocus = true;
            GetRibbon.BackColor = GetRibbon.cBackGroundFocus;
        }

        private void RibbonMouseLeave(object sender, EventArgs e)
        {
            GoFocus = false;
            if (GetRibbon.CheckOnClick)
                if (GetRibbon.Checked)
                    GetRibbon.BackColor = GetRibbon.cBackGroundClick;
                else
                    GetRibbon.BackColor = Drawing.Color.Transparent;
            else
                GetRibbon.BackColor = GetRibbon.cBackGroundinit;

            if (GetRibbon.EffectSizeBig > 0)
            {
                GetRibbon.Location = DfPoint;
                GetRibbon.Size = DfSize;
            }
        }

        private void RibbonMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                GetRibbon.BackColor = GetRibbon.cBackGroundClick;

                if (GetRibbon.CheckOnClick)
                {
                    GetRibbon.Checked = Funciones.IIF(GetRibbon.Checked, false, true);

                    if (GetRibbon.Checked)
                    {
                        foreach (Control element in GetRibbon.Parent.Controls)
                        {
                            if (element is RibbonPanel)
                            {
                                if ((element as RibbonPanel).CheckOnClick)
                                {
                                    if (element.Name != GetRibbon.Name)
                                    {
                                        (element as RibbonPanel).Checked = false;
                                        (element as RibbonPanel).BackColor = Drawing.Color.Transparent;
                                        (element as RibbonPanel).BorderColor = (element as RibbonPanel).BorderColor;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void RibbonMouseHover(object sender, EventArgs e)
        {
            DfPoint = GetRibbon.Location;
            DfSize = GetRibbon.Size;

            if (GetRibbon.EffectSizeBig > 0)
            {
                for (int i = 0; i < GetRibbon.EffectSizeBig; i++)
                {
                    GetRibbon.Location = new System.Drawing.Point(GetRibbon.Location.X - 1, GetRibbon.Location.Y - 1);
                    GetRibbon.Height += 2;
                    GetRibbon.Width += 2;
                    GetRibbon.Update();
                }
            }
        }

        public void OnPaint(PaintEventArgs e)
        {
            if (GetRibbon.AplicateStyle)
            {
                foreach (Control item in GetRibbon.Controls)
                {
                    item.MouseMove += RibbonMouseMove;
                    item.MouseLeave += RibbonMouseLeave;
                    item.MouseDown += RibbonMouseDown;
                }
            }
        }

        private void RibbonPaint(object sender, PaintEventArgs e)
        {
            if (GetRibbon.ChangeSkin)
                UpdateDesign(ColorTable);

            if (GoFocus)
                ControlPaint.DrawBorder(e.Graphics, GetRibbon.DisplayRectangle, GetRibbon.cBorderColorFocus, ButtonBorderStyle.Solid);
            else if (GetRibbon.Border)
                ControlPaint.DrawBorder(e.Graphics, GetRibbon.DisplayRectangle, GetRibbon.cBorderColorInit, ButtonBorderStyle.Solid);
            else
            {
                ControlPaint.DrawBorder(e.Graphics, GetRibbon.DisplayRectangle, GetRibbon.cBorderColorInit, ButtonBorderStyle.None);
                if (GetRibbon.CheckOnClick)
                {
                    if (GetRibbon.Checked)
                        ControlPaint.DrawBorder(e.Graphics, GetRibbon.DisplayRectangle, GetRibbon.cBorderColorFocus, ButtonBorderStyle.Solid);
                    else
                        ControlPaint.DrawBorder(e.Graphics, GetRibbon.DisplayRectangle, GetRibbon.cBorderColorFocus, ButtonBorderStyle.None);
                }
            }
        }
    }
}