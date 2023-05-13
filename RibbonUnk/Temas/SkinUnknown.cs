using System.Drawing;

namespace System.Windows.Forms
{
    public static class SkinUnknown
    {
        public static ColorTable GetColorTable()
        {
            //# Ribbon 
            Memory.RibbonColor.TopColor1 = Color.FromArgb(208, 232, 253);
            Memory.RibbonColor.TopColor2 = Color.FromArgb(181, 210, 239);
            Memory.RibbonColor.BottomColor1 = Color.FromArgb(172, 205, 237);
            Memory.RibbonColor.BottomColor2 = Color.FromArgb(208, 232, 253);
            Memory.RibbonColor.BorderColor = Color.FromArgb(119, 159, 255);// 132, 184, 240);
            Memory.RibbonColor.BackColor = Color.Transparent;
            Memory.RibbonColor.ColorHeight = 17;
            Memory.RibbonColor.Curvate = 1;

            //# GroupBox 
            Memory.GroupBoxColor.Curvate = 5;
            Memory.GroupBoxColor.TitleBackColor = Color.FromArgb(157, 202, 239);
            Memory.GroupBoxColor.TitleColor = Color.FromArgb(62, 106, 170);
            Memory.GroupBoxColor.BackColor = Color.FromArgb(185, 218, 242);
            Memory.GroupBoxColor.BorderColor = Color.FromArgb(151, 191, 222);

            //# MainMenu
            Memory.MainMenuColor.ImageOcultar = Funciones.DeserializeFromBase64(ImageBase64.BtnImageFlechaBlue1);
            Memory.MainMenuColor.ImageOcultarClick = Funciones.DeserializeFromBase64(ImageBase64.BtnImageFlechaBlue2);
            Memory.MainMenuColor.Renderer = new ToolStripRendererUnknow();

            //# MenuStrip
            Memory.MenuStripColor.BackColor = Color.FromArgb(194, 219, 243);
            Memory.MenuStripColor.ItemsColor = Color.FromArgb(60, 60, 60);
            Memory.MenuStripColor.ItemsColorClick = Color.FromArgb(43, 87, 154);

            //# RibbonPanel
            Memory.PanelColor.BorderColorInit = Color.FromArgb(218, 219, 220);
            Memory.PanelColor.BorderColorFocus = Color.FromArgb(164, 206, 249);
            Memory.PanelColor.BackGroundInit = Color.Transparent;
            Memory.PanelColor.BackGroundFocus = Color.FromArgb(229, 243, 255);
            Memory.PanelColor.BackGroundClick = Color.FromArgb(201, 228, 251);

            //# RibbonPanelEffects
            Memory.PanelEffectColor.Curvate = 5;
            Memory.PanelEffectColor.TitleBackColor = Color.FromArgb(157, 202, 239);
            Memory.PanelEffectColor.TitleColor = Color.FromArgb(62, 106, 170);
            Memory.PanelEffectColor.BackColor = Color.FromArgb(185, 218, 242);
            Memory.PanelEffectColor.BorderColor = Color.FromArgb(151, 191, 222);
            Memory.PanelEffectColor.BackColorFocus = Color.FromArgb(197, 225, 249);
            Memory.PanelEffectColor.BackColorClick = Color.FromArgb(197, 225, 249);

            //# PanelMDI
            Memory.PanelMdiColor.TopColor = Color.FromArgb(83, 83, 83);
            Memory.PanelMdiColor.BottomColor = Color.FromArgb(28, 28, 28);
            Memory.PanelMdiColor.BorderColor = Color.FromArgb(0, 45, 150);

            //# Separator 
            Memory.SeparatorColor.BackColor = Color.FromArgb(151, 191, 222);

            //# StatuStrip 
            Memory.StatusStripColor.TopColor1 = Color.FromArgb(169, 199, 240);
            Memory.StatusStripColor.TopColor2 = Color.FromArgb(169, 199, 240);
            Memory.StatusStripColor.BottomColor1 = Color.FromArgb(154, 188, 235);
            Memory.StatusStripColor.BottomColor2 = Color.FromArgb(154, 188, 235);
            Memory.StatusStripColor.BorderColor = Color.Empty;

            //# HomeRibbon
            Memory.HomeRibbonColor.BackColor = Color.FromArgb(43, 87, 154);
            Memory.HomeRibbonColor.BackColorFocs = Color.FromArgb(60, 101, 164);
            Memory.HomeRibbonColor.BackColorClick = Color.FromArgb(18, 64, 120);
            Memory.HomeRibbonColor.ForeColor = Color.White;
            Memory.HomeRibbonColor.BackColor2 = Color.FromArgb(1, 115, 199);

            //# Form Ribbon
            Memory.FormRibbonColor.ColorRibbon = Color.Transparent;
            Memory.FormRibbonColor.ForeColorControlBox = Color.Black;
            Memory.FormRibbonColor.ForeColortituloText = Color.Black;
            Memory.FormRibbonColor.ControlBoxImagen = Funciones.PaintControlBox(Color.FromArgb(194, 219, 243), Color.FromArgb(181, 210, 239), Color.FromArgb(172, 205, 237), Color.FromArgb(208, 232, 253), Color.FromArgb(132, 184, 240)); ;
            Memory.FormRibbonColor.ColorMaximizeFocus = Color.FromArgb(108, 184, 248);
            Memory.FormRibbonColor.ColorMaximizeClick = Color.FromArgb(108, 184, 248);
            Memory.FormRibbonColor.ColorMinimizeFocus = Color.FromArgb(108, 184, 248);
            Memory.FormRibbonColor.ColorMinimizeClick = Color.FromArgb(108, 184, 248);

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