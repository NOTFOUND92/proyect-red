using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace System.Windows.Forms
{
    public partial class ViewThema : UserControl
    {
        public RibbonManager SetRibbonManager { get; set; }
        public Form RibbonContainer { get; set; }

        RibbonColor    GetRibbonColor   = new RibbonColor();
        GroupBoxColor  GetGroupBoxColor = new GroupBoxColor();
        PanelMdiColor  GetPanelMdiColor = new PanelMdiColor();
        MenuStripColor GetMenuStripColor= new MenuStripColor();
        PanelColor     GetPanelColor    = new PanelColor();
        PanelEffectColor GetPanelEffectColor = new PanelEffectColor();

        ColorDialog color = new ColorDialog();

        public ViewThema()
        {
            InitializeComponent();
        }

        private void BtnRibbon_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                string cColor = string.Concat(color.Color.R.ToString(), ",", color.Color.G.ToString(), ",", color.Color.B.ToString());
                switch ((sender as Button).Name)
                {
                    case "btn1":
                        {
                            textBox1.Text = cColor;
                            GetRibbonColor.TopColor1 = Color.FromArgb(color.Color.R, color.Color.G, color.Color.B);
                            break;
                        }
                    case "btn2":
                        {
                            textBox2.Text = cColor;
                            GetRibbonColor.TopColor2 = Color.FromArgb(color.Color.R, color.Color.G, color.Color.B);
                            break;
                        }
                    case "btn3":
                        {
                            textBox3.Text = cColor;
                            GetRibbonColor.BottomColor1 = Color.FromArgb(color.Color.R, color.Color.G, color.Color.B);
                            break;
                        }
                    case "btn4":
                        {
                            textBox4.Text = cColor;
                            GetRibbonColor.BottomColor2 = Color.FromArgb(color.Color.R, color.Color.G, color.Color.B);
                            break;
                        }
                    case "btn5":
                        {
                            textBox5.Text = cColor;
                            GetRibbonColor.BorderColor = Color.FromArgb(color.Color.R, color.Color.G, color.Color.B);
                            break;
                        }
                    case "btn6":
                        {
                            textBox6.Text = cColor;
                            GetRibbonColor.BackColor = Color.FromArgb(color.Color.R, color.Color.G, color.Color.B);
                            break;
                        }
                    case "btn7":
                        {
                            textBox12.Text = cColor;
                            GetGroupBoxColor.BackColor = Color.FromArgb(color.Color.R, color.Color.G, color.Color.B);
                            break;
                        }
                    case "btn8":
                        {
                            textBox11.Text = cColor;
                            GetGroupBoxColor.BorderColor = Color.FromArgb(color.Color.R, color.Color.G, color.Color.B);
                            break;
                        }
                    case "btn9":
                        {
                            textBox10.Text = cColor;
                            GetGroupBoxColor.TitleColor = Color.FromArgb(color.Color.R, color.Color.G, color.Color.B);
                            break;
                        }
                    case "btn10":
                        {
                            textBox9.Text = cColor;
                            GetGroupBoxColor.TitleBackColor = Color.FromArgb(color.Color.R, color.Color.G, color.Color.B);
                            break;
                        }
                    case "btn11":
                        {
                            textBox14.Text = cColor;
                            GetPanelMdiColor.TopColor = Color.FromArgb(color.Color.R, color.Color.G, color.Color.B);
                            break;
                        }
                    case "btn12":
                        {
                            textBox13.Text = cColor;
                            GetPanelMdiColor.BottomColor = Color.FromArgb(color.Color.R, color.Color.G, color.Color.B);
                            break;
                        }
                    case "btn13":
                        {
                            textBox8.Text = cColor;
                            GetPanelMdiColor.BorderColor = Color.FromArgb(color.Color.R, color.Color.G, color.Color.B);
                            break;
                        }
                    case "btn14":
                        {
                            textBox16.Text = cColor;
                            GetMenuStripColor.BackColor = Color.FromArgb(color.Color.R, color.Color.G, color.Color.B);
                            break;
                        }
                    case "btn15":
                        {
                            textBox15.Text = cColor;
                            GetMenuStripColor.ItemsColor = Color.FromArgb(color.Color.R, color.Color.G, color.Color.B);
                            break;
                        }
                    case "btn16":
                        {
                            textBox7.Text = cColor;
                            GetMenuStripColor.ItemsColorClick = Color.FromArgb(color.Color.R, color.Color.G, color.Color.B);
                            break;
                        }
                    case "btn17":
                        {
                            textBox19.Text = cColor;
                            GetPanelColor.BorderColorInit = Color.FromArgb(color.Color.R, color.Color.G, color.Color.B);
                            break;
                        }
                    case "btn18":
                        {
                            textBox18.Text = cColor;
                            GetPanelColor.BorderColorFocus = Color.FromArgb(color.Color.R, color.Color.G, color.Color.B);
                            break;
                        }
                    case "btn19":
                        {
                            textBox17.Text = cColor;
                            GetPanelColor.BackGroundInit = Color.FromArgb(color.Color.R, color.Color.G, color.Color.B);
                            break;
                        }
                    case "btn20":
                        {
                            textBox21.Text = cColor;
                            GetPanelColor.BackGroundFocus = Color.FromArgb(color.Color.R, color.Color.G, color.Color.B);
                            break;
                        }
                    case "btn21":
                        {
                            textBox20.Text = cColor;
                            GetPanelColor.BackGroundClick = Color.FromArgb(color.Color.R, color.Color.G, color.Color.B);
                            break;
                        }
                    case "btn22":
                        {
                            textBox26.Text = cColor;
                            GetPanelEffectColor.BackColor = Color.Transparent ;// Color.FromArgb(color.Color.R, color.Color.G, color.Color.B);
                            break;
                        }
                    case "btn23":
                        {
                            textBox25.Text = cColor;
                            GetPanelEffectColor.BorderColor = Color.FromArgb(color.Color.R, color.Color.G, color.Color.B);
                            break;
                        }
                    case "btn24":
                        {
                            textBox24.Text = cColor;
                            GetPanelEffectColor.TitleColor = Color.FromArgb(color.Color.R, color.Color.G, color.Color.B);
                            break;
                        }
                    case "btn25":
                        {
                            textBox23.Text = cColor;
                            GetPanelEffectColor.TitleBackColor = Color.FromArgb(color.Color.R, color.Color.G, color.Color.B);
                            break;
                        }
                    case "btn26":
                        {
                            textBox22.Text = cColor;
                            GetPanelEffectColor.BackColorFocus = Color.FromArgb(color.Color.R, color.Color.G, color.Color.B);
                            break;
                        }
                    case "btn27":
                        {
                            textBox27.Text = cColor;
                            GetPanelEffectColor.BackColorClick = Color.FromArgb(color.Color.R, color.Color.G, color.Color.B);
                            break;
                        }
                    default:
                        break;
                }

                button7_Click(sender, e);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GetRibbonColor.ColorHeight= (int)numericUpDown1.Value;
            GetRibbonColor.Curvate    = (int)numericUpDown2.Value;
            GetGroupBoxColor.Curvate  = (int)numericUpDown3.Value;
            GetPanelEffectColor.Curvate = (int)numericUpDown4.Value;

            SetRibbonManager.Skin = Skin.Null;

            Memory.ColorTable.RibbonColor   = GetRibbonColor;
            Memory.ColorTable.GroupBoxColor = GetGroupBoxColor;
            Memory.ColorTable.PanelMdiColor = GetPanelMdiColor;
            Memory.ColorTable.MenuStripColor= GetMenuStripColor;
            Memory.ColorTable.PanelColor    = GetPanelColor;
            Memory.ColorTable.PanelEffectColor = GetPanelEffectColor;

            SetRibbonManager.ColorTable = Memory.ColorTable;
            SetRibbonManager.UpdateSkin();

            RibbonContainer.Refresh();
        }
    }
}
