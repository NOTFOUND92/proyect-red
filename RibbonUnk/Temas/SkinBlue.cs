using System.Drawing;

namespace System.Windows.Forms
{
    public static class SkinBlue
    {
        public static ColorTable GetColorTable()
        {
            //# Ribbon   
            Memory.RibbonColor.TopColor1 = Color.FromArgb(227, 243, 254);
            Memory.RibbonColor.TopColor2 = Color.FromArgb(210, 230, 248);
            Memory.RibbonColor.BottomColor1 = Color.FromArgb(204, 227, 247);
            Memory.RibbonColor.BottomColor2 = Color.FromArgb(227, 243, 254);
            Memory.RibbonColor.BorderColor = Color.FromArgb(138, 177, 219);
            Memory.RibbonColor.BackColor = Color.Transparent;
            Memory.RibbonColor.ColorHeight = 17;
            Memory.RibbonColor.Curvate = 1;

            //# GroupBox
            Memory.GroupBoxColor.Curvate = 5;
            Memory.GroupBoxColor.BackColor = Color.FromArgb(194, 225, 248);
            Memory.GroupBoxColor.TitleColor = Color.FromArgb(62, 106, 170);
            Memory.GroupBoxColor.TitleBackColor = Color.FromArgb(212, 233, 249);
            Memory.GroupBoxColor.BorderColor = Color.FromArgb(193, 218, 238);

            //# MainMenu
            Memory.MainMenuColor.ImageOcultar = Funciones.DeserializeFromBase64(ImageBase64.BtnImageFlechaBlue1);
            Memory.MainMenuColor.ImageOcultarClick = Funciones.DeserializeFromBase64(ImageBase64.BtnImageFlechaBlue2);
            Memory.MainMenuColor.Renderer = new ToolStripRendererBlue();

            //# MenuStrip 
            Memory.MenuStripColor.BackColor = Color.FromArgb(191, 219, 255);
            Memory.MenuStripColor.ItemsColor = Color.FromArgb(60, 60, 60);
            Memory.MenuStripColor.ItemsColorClick = Color.FromArgb(43, 87, 154);

            //# RibbonPanel
            Memory.PanelColor.BorderColorInit = Color.FromArgb(218, 219, 220);
            Memory.PanelColor.BorderColorFocus = Color.FromArgb(164, 206, 249);
            Memory.PanelColor.BackGroundInit = Color.Transparent;
            Memory.PanelColor.BackGroundFocus = Color.FromArgb(229, 243, 255);
            Memory.PanelColor.BackGroundClick = Color.FromArgb(201, 228, 251);

            ///# RibbonPanelEffects
            Memory.PanelEffectColor.Curvate = 5;
            Memory.PanelEffectColor.BackColor = Color.FromArgb(194, 225, 248);
            Memory.PanelEffectColor.TitleColor = Color.FromArgb(62, 106, 170);
            Memory.PanelEffectColor.TitleBackColor = Color.FromArgb(212, 233, 249);
            Memory.PanelEffectColor.BorderColor = Color.FromArgb(193, 218, 238);
            Memory.PanelEffectColor.BackColorFocus = Color.FromArgb(221, 238, 253);
            Memory.PanelEffectColor.BackColorClick = Color.FromArgb(221, 238, 253);

            //# PanelMDI
            Memory.PanelMdiColor.TopColor = Color.FromArgb(188, 216, 253);
            Memory.PanelMdiColor.BottomColor = Color.FromArgb(90, 128, 179);
            Memory.PanelMdiColor.BorderColor = Color.FromArgb(138, 177, 219);// Color.FromArgb(101, 147, 207);

            //# Separator 
            Memory.SeparatorColor.BackColor = Color.FromArgb(193, 218, 238);

            //# StatuStrip 
            Memory.StatusStripColor.TopColor1 = Color.FromArgb(224, 237, 255);
            Memory.StatusStripColor.TopColor2 = Color.FromArgb(199, 223, 255);
            Memory.StatusStripColor.BottomColor1 = Color.FromArgb(176, 210, 255);
            Memory.StatusStripColor.BottomColor2 = Color.FromArgb(190, 218, 255);
            Memory.StatusStripColor.BorderColor = Color.Empty;

            //# HomeRibbon
            Memory.HomeRibbonColor.BackColor = Color.FromArgb(171, 203, 241);//Color.FromArgb(191, 219, 255);// Color.FromArgb(43, 87, 154);
            Memory.HomeRibbonColor.BackColorFocs = Color.FromArgb(229, 243, 255);
            Memory.HomeRibbonColor.BackColorClick = Color.FromArgb(201, 228, 251);
            Memory.HomeRibbonColor.ForeColor = Color.FromArgb(60, 60, 60);
            Memory.HomeRibbonColor.BackColor2 = Color.FromArgb(236, 244, 255);

            //# Form Ribbon
            Memory.FormRibbonColor.ColorRibbon = Color.Transparent;
            Memory.FormRibbonColor.ForeColorControlBox = Color.Black;
            Memory.FormRibbonColor.ForeColortituloText = Color.Black;
            Memory.FormRibbonColor.ControlBoxImagen = Funciones.PaintControlBox(Color.FromArgb(227, 235, 247), Color.FromArgb(219, 233, 252), Color.FromArgb(204, 223, 247), Color.FromArgb(225, 237, 252), Color.FromArgb(174, 202, 240));
            Memory.FormRibbonColor.ColorMaximizeFocus = Color.FromArgb(239, 245, 255);
            Memory.FormRibbonColor.ColorMaximizeClick = Color.FromArgb(239, 245, 255);
            Memory.FormRibbonColor.ColorMinimizeFocus = Color.FromArgb(239, 245, 255);
            Memory.FormRibbonColor.ColorMinimizeClick = Color.FromArgb(239, 245, 255);

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