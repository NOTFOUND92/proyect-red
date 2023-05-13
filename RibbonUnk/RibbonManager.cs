using System;

namespace System.Windows.Forms
{
	public class RibbonManager
	{
        Control getForm   = new Control();
        Control getObject = new Control();
		
        public ColorTable ColorTable
        {
            get;
            set;
        }

		public Skin Skin
        {
            get;
            set;
        }

		public RibbonManager(Form form, Skin skin = Skin.Null)
		{
            getForm = form;
			Skin = skin;            
        }

        public void UpdateSkin()
        {
            GetColorTable();
            LoadSkin();
        }

        void GetColorTable()
        {
            switch (Skin)
            {
                case Skin.UnkNown:
                    ColorTable = SkinUnknown.GetColorTable();
                    break;
                case Skin.Blue:
                    ColorTable = SkinBlue.GetColorTable();
                    break;
                case Skin.Silver:
                    ColorTable = SkinBlack.GetColorTable();
                    break;
                case Skin.Smile:
                    ColorTable = SkinSmile.GetColorTable();
                    break;
                default:
                    break;
            }
        }

        void LoadSkin(Control control = null)
        {
            if (getForm == null && control == null)
            {
                MessageBox.Show("Ribbon Manager : Control no a sido asignado", "Error : RibbonUnk", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ColorTable == null)
            {
                MessageBox.Show("Ribbon Manager : ColorTable se encuentra vacio", "Error : RibbonUnk", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }         

            getObject = Funciones.IIF(control == null, getForm, control);

			foreach (Control obj in getObject.Controls)
            {                
                if (obj.Name == "rControlBox") //# no cambiar el tema a  su barra de titulo de formularios ribbon
                    continue;

				if (obj is IRibbonDesign)
					if (((IRibbonDesign)obj).ChangeSkin)
						((IRibbonDesign)obj).UpdateDesign(ColorTable);
				
				if (obj is Panel || obj is GroupBox || obj is SplitContainer) //# Cuando Son Contenedores Ejecutar De Nuevo la Función LoadSkin
                    LoadSkin(obj);
			}

            if (getForm is RibbonForm)
                RibbonFormSkin((RibbonForm)getForm);
		}
        
		void RibbonFormSkin(RibbonForm rbn)
		{
            rbn.ColorRibbon = ColorTable.FormRibbonColor.ColorRibbon;
            rbn.ControlBoxImagen = ColorTable.FormRibbonColor.ControlBoxImagen;
            rbn.ForeColorControlBox = ColorTable.FormRibbonColor.ForeColorControlBox;
            rbn.ForeColortituloText = ColorTable.FormRibbonColor.ForeColortituloText;
            rbn.BackColorMaximizeFocus = ColorTable.FormRibbonColor.ColorMaximizeFocus;
            rbn.BackColorMaximizeClick = ColorTable.FormRibbonColor.ColorMaximizeClick;
            rbn.BackColorMinimizeFocus = ColorTable.FormRibbonColor.ColorMinimizeFocus;
            rbn.BackColorMinimizeClick = ColorTable.FormRibbonColor.ColorMinimizeClick;
		}	
	}
}