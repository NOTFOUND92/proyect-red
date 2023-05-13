using System.Drawing;

namespace System.Windows.Forms
{
    public static class SkinSmile
    {
        public static ColorTable GetColorTable()
        {
            //# Ribbon     
            Memory.RibbonColor.TopColor1 = Color.FromArgb(245, 246, 247);
            Memory.RibbonColor.TopColor2 = Color.FromArgb(245, 246, 247);
            Memory.RibbonColor.BottomColor1 = Color.FromArgb(245, 246, 247);
            Memory.RibbonColor.BottomColor2 = Color.FromArgb(241, 241, 241);
            Memory.RibbonColor.BorderColor = Color.FromArgb(245, 246, 247);// Color.FromArgb(218,219,220);
            Memory.RibbonColor.BackColor = Color.Transparent;
            Memory.RibbonColor.ColorHeight = 17;
            Memory.RibbonColor.Curvate = 1;

            //# GroupBox 
            Memory.GroupBoxColor.Curvate = 5;
            Memory.GroupBoxColor.BackColor = Color.FromArgb(229, 229, 230);
            Memory.GroupBoxColor.TitleColor = Color.FromArgb(60, 60, 60);
            Memory.GroupBoxColor.TitleBackColor = Color.FromArgb(245, 246, 247);
            Memory.GroupBoxColor.BorderColor = Color.FromArgb(229, 229, 230);

            //# MainMenu
            Memory.MainMenuColor.ImageOcultar = null;
            Memory.MainMenuColor.ImageOcultarClick = null;
            Memory.MainMenuColor.Renderer = new ToolStripRendererSmile();

            //# MenuStrip 
            Memory.MenuStripColor.BackColor = Color.FromArgb(1, 115, 199);
            Memory.MenuStripColor.ItemsColor = Color.FromArgb(255, 255, 255);
            Memory.MenuStripColor.ItemsColorClick = Color.FromArgb(43, 87, 154);

            //# RibbonPanel
            Memory.PanelColor.BorderColorInit = Color.FromArgb(218, 219, 220);
            Memory.PanelColor.BorderColorFocus = Color.FromArgb(164, 206, 249);
            Memory.PanelColor.BackGroundInit = Color.Transparent;
            Memory.PanelColor.BackGroundFocus = Color.FromArgb(229, 243, 255);
            Memory.PanelColor.BackGroundClick = Color.FromArgb(201, 228, 251);

            //# RibbonPanelEffects
            Memory.PanelEffectColor.Curvate = 5;
            Memory.PanelEffectColor.BackColor = Color.FromArgb(229, 229, 230);
            Memory.PanelEffectColor.TitleColor = Color.FromArgb(60, 60, 60);
            Memory.PanelEffectColor.TitleBackColor = Color.FromArgb(245, 246, 247);
            Memory.PanelEffectColor.BorderColor = Color.FromArgb(229, 229, 230);
            Memory.PanelEffectColor.BackColorFocus = Color.FromArgb(250, 253, 255);
            Memory.PanelEffectColor.BackColorClick = Color.FromArgb(250, 253, 255);

            //# PanelMDI
            Memory.PanelMdiColor.TopColor = Color.FromArgb(250, 250, 250);
            Memory.PanelMdiColor.BottomColor = Color.FromArgb(250, 250, 250);
            Memory.PanelMdiColor.BorderColor = Color.FromArgb(165, 167, 169);// Color.FromArgb(130,130,130); 

            //# Separator 
            Memory.SeparatorColor.BackColor = Color.FromArgb(229, 229, 230);

            //# StatuStrip 
            Memory.StatusStripColor.TopColor1 = Color.FromArgb(241, 241, 241);// Color.FromArgb(1, 115, 199);
            Memory.StatusStripColor.TopColor2 = Color.FromArgb(241, 241, 241);  //Color.FromArgb(1, 115, 199);
            Memory.StatusStripColor.BottomColor1 = Color.FromArgb(241, 241, 241);// Color.FromArgb(1, 115, 199);
            Memory.StatusStripColor.BottomColor2 = Color.FromArgb(241, 241, 241); //Color.FromArgb(1, 115, 199);
            Memory.StatusStripColor.BorderColor = Color.Empty;

            //# HomeRibbon
            Memory.HomeRibbonColor.BackColor = Color.FromArgb(1, 115, 199);
            Memory.HomeRibbonColor.BackColorFocs = Color.FromArgb(60, 101, 164);
            Memory.HomeRibbonColor.BackColorClick = Color.FromArgb(18, 64, 120);
            Memory.HomeRibbonColor.ForeColor = Color.White;
            Memory.HomeRibbonColor.BackColor2 = Color.FromArgb(245, 246, 247);

            //# Form Ribbon
            Memory.FormRibbonColor.ColorRibbon = Color.FromArgb(1, 115, 199);
            Memory.FormRibbonColor.ForeColorControlBox = Color.White;
            Memory.FormRibbonColor.ForeColortituloText = Color.White;
            Memory.FormRibbonColor.ControlBoxImagen = null;
            Memory.FormRibbonColor.ColorMaximizeFocus = Color.FromArgb(5, 146, 250);
            Memory.FormRibbonColor.ColorMaximizeClick = Color.FromArgb(7, 88, 149);
            Memory.FormRibbonColor.ColorMinimizeFocus = Color.FromArgb(5, 146, 250);
            Memory.FormRibbonColor.ColorMinimizeClick = Color.FromArgb(7, 88, 149);

            Memory.ColorTable.GroupBoxColor = Memory.GroupBoxColor;
            Memory.ColorTable.MainMenuColor = Memory.MainMenuColor;
            Memory.ColorTable.MenuStripColor = Memory.MenuStripColor;
            Memory.ColorTable.PanelColor = Memory.PanelColor;
            Memory.ColorTable.PanelEffectColor = Memory.PanelEffectColor;
            Memory.ColorTable.PanelMdiColor = Memory.PanelMdiColor;
            Memory.ColorTable.SeparatorColor = Memory.SeparatorColor;
            Memory.ColorTable.StatusStripColor = Memory.StatusStripColor;
            Memory.ColorTable.HomeRibbonColor = Memory.HomeRibbonColor;
            Memory.ColorTable.FormRibbonColor = Memory.FormRibbonColor;
            Memory.ColorTable.RibbonColor = Memory.RibbonColor;

            return Memory.ColorTable;
        }
    }
}