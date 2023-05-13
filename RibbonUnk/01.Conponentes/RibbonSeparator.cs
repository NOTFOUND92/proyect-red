using System;
using System.ComponentModel;

namespace System.Windows.Forms
{
	public class RibbonSeparator:Panel,IRibbonDesign
	{
		RibbonSeparatorDesigner GetRibbonSeparatorDesigner;

        [Category("Ribbon Design")]
        public bool ChangeSkin { get; set; }
				
		public RibbonSeparator()
		{
            GetRibbonSeparatorDesigner = new RibbonSeparatorDesigner(this);
			DoubleBuffered = true;								
		}
		
		public void UpdateDesign(ColorTable Colores)
		{
            GetRibbonSeparatorDesigner.UpdateDesign(Colores);
		}
	}
}