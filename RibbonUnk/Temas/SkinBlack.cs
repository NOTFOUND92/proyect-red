using System.Drawing;

namespace System.Windows.Forms
{
    public static class SkinBlack
    {
        public static ColorTable GetColorTable()
        {
            //# Ribbon              
            Memory.RibbonColor.TopColor1 = Color.FromArgb(243, 244, 245);
            Memory.RibbonColor.TopColor2 = Color.FromArgb(215, 221, 231);
            Memory.RibbonColor.BottomColor1 = Color.FromArgb(215, 221, 231);
            Memory.RibbonColor.BottomColor2 = Color.FromArgb(243, 244, 245);
            Memory.RibbonColor.BorderColor = Color.FromArgb(140, 140, 140);  //Color.FromArgb(190, 190, 190);
            Memory.RibbonColor.BackColor = Color.Transparent;
            Memory.RibbonColor.ColorHeight = 17;
            Memory.RibbonColor.Curvate = 1;

            //# GroupBox             
            Memory.GroupBoxColor.BackColor = Color.FromArgb(229, 235, 239);
            Memory.GroupBoxColor.BorderColor = Color.FromArgb(188, 190, 192);
            Memory.GroupBoxColor.TitleColor = Color.FromArgb(51, 51, 51);
            Memory.GroupBoxColor.TitleBackColor = Color.FromArgb(213, 217, 228);
            Memory.GroupBoxColor.Curvate = 5;

            //# MainMenu            
            Memory.MainMenuColor.Renderer = new ToolStripRendererBlack();
            Memory.MainMenuColor.ImageOcultar = Funciones.DeserializeFromBase64(ImageBase64.BtnImageFlechaBlack1);
            Memory.MainMenuColor.ImageOcultarClick = Funciones.DeserializeFromBase64(ImageBase64.BtnImageFlechaBlack2);

            //# MenuStrip            
            Memory.MenuStripColor.BackColor = Color.FromArgb(208, 212, 221);
            Memory.MenuStripColor.ItemsColor = Color.FromArgb(60, 60, 60);
            Memory.MenuStripColor.ItemsColorClick = Color.FromArgb(143, 144, 145);

            //# RibbonPanel           
            Memory.PanelColor.BorderColorInit = Color.Transparent;
            Memory.PanelColor.BorderColorFocus = Color.FromArgb(194, 169, 120);
            Memory.PanelColor.BackGroundInit = Color.Transparent;
            Memory.PanelColor.BackGroundFocus = Color.FromArgb(255, 238, 176);
            Memory.PanelColor.BackGroundClick = Color.FromArgb(255, 220, 104);

            //# RibbonPanelEffects            
            Memory.PanelEffectColor.BackColor = Color.FromArgb(229, 235, 239);
            Memory.PanelEffectColor.BorderColor = Color.FromArgb(188, 190, 192);
            Memory.PanelEffectColor.TitleColor = Color.FromArgb(51, 51, 51);
            Memory.PanelEffectColor.TitleBackColor = Color.FromArgb(213, 217, 228);
            Memory.PanelEffectColor.BackColorFocus = Color.FromArgb(244, 246, 248);
            Memory.PanelEffectColor.BackColorClick = Color.FromArgb(244, 246, 248);
            Memory.PanelEffectColor.Curvate = 5;

            //# PanelMDI           
            Memory.PanelMdiColor.TopColor = Color.FromArgb(83, 83, 83);
            Memory.PanelMdiColor.BottomColor = Color.FromArgb(28, 28, 28);
            Memory.PanelMdiColor.BorderColor = Color.FromArgb(140, 140, 140); //Color.FromArgb(76,83,92);

            //# Separator             
            Memory.SeparatorColor.BackColor = Color.FromArgb(190, 190, 190);

            //# StatuStrip             
            Memory.StatusStripColor.TopColor1 = Color.FromArgb(245, 245, 246);
            Memory.StatusStripColor.TopColor2 = Color.FromArgb(225, 228, 230);
            Memory.StatusStripColor.BottomColor1 = Color.FromArgb(204, 208, 213);
            Memory.StatusStripColor.BottomColor2 = Color.FromArgb(217, 220, 224);
            Memory.StatusStripColor.BorderColor = Color.Empty;

            //# HomeRibbon            
            Memory.HomeRibbonColor.BackColor = Color.FromArgb(143, 144, 145);
            Memory.HomeRibbonColor.BackColorFocs = Color.FromArgb(173, 173, 173);
            Memory.HomeRibbonColor.BackColorClick = Color.FromArgb(127, 128, 129);
            Memory.HomeRibbonColor.ForeColor = Color.White;
            Memory.HomeRibbonColor.BackColor2 = Color.Silver; ;

            //# Form Ribbon            
            Memory.FormRibbonColor.ColorRibbon = Color.Transparent;
            Memory.FormRibbonColor.ForeColorControlBox = Color.Black;
            Memory.FormRibbonColor.ForeColortituloText = Color.Black;
            Memory.FormRibbonColor.ControlBoxImagen = Funciones.PaintControlBox(Color.FromArgb(231, 232, 235), Color.FromArgb(204, 206, 210), Color.FromArgb(190, 197, 206), Color.FromArgb(230, 235, 244), Color.FromArgb(172, 175, 183));
            Memory.FormRibbonColor.ColorMaximizeFocus = Color.FromArgb(238, 238, 239);
            Memory.FormRibbonColor.ColorMaximizeClick = Color.FromArgb(238, 238, 239);
            Memory.FormRibbonColor.ColorMinimizeFocus = Color.FromArgb(238, 238, 239);
            Memory.FormRibbonColor.ColorMinimizeClick = Color.FromArgb(238, 238, 239);

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