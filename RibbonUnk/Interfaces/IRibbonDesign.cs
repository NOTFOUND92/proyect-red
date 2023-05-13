namespace System.Windows.Forms
{
    interface IRibbonDesign
    {
        bool ChangeSkin { get; set; }
        void UpdateDesign(ColorTable ColorSkin);
    }
}
