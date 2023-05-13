using System.Collections.Generic;
using System.ComponentModel;

namespace System.Windows.Forms
{
    public partial class HomeRibbon : UserControl, IRibbonDesign
    {
        Panel[] cntPanel;
        ColorTable ColorTable;
        [Category("Ribbon Design")]
        public bool ChangeSkin { get; set; }
        [Category("Ribbon Design")]
        public List<ButtonHomeRibbon> Buttons = new List<ButtonHomeRibbon>();

        public HomeRibbon()
        {
            InitializeComponent();
            DoubleBuffered = true;

            ChangeSkin = true;
            ColorTable = Memory.ColorTable;

            if (ChangeSkin && ColorTable != null)
            {
                tableLayoutPanel1.BackColor = ColorTable.HomeRibbonColor.BackColor;

                cntPanel = new Panel[] {
				  // BtnOcultar,
				    btn1,
                    btn2,
                    btn3,
                    btn4,
                    btn5
                };
                foreach (Panel item in cntPanel)
                {
                    //item.Click += PaintButtons_Click;
                    ((RibbonPanel)item).BackGroundColorFocus = ColorTable.HomeRibbonColor.BackColorFocs;
                    ((RibbonPanel)item).BackGroundColorClick = ColorTable.HomeRibbonColor.BackColorClick;
                }

                label1.ForeColor = ColorTable.HomeRibbonColor.ForeColor;
                label2.ForeColor = ColorTable.HomeRibbonColor.ForeColor;
                label3.ForeColor = ColorTable.HomeRibbonColor.ForeColor;
                label4.ForeColor = ColorTable.HomeRibbonColor.ForeColor;
                label5.ForeColor = ColorTable.HomeRibbonColor.ForeColor;

                splitContainer1.BackColor = ColorTable.HomeRibbonColor.BackColor2;
                splitContainer1.Panel2.BackColor = ColorTable.HomeRibbonColor.BackColor2;

                this.BringToFront();
            }

            this.splitContainer1.SplitterWidth = 1;
        }

        private void CargarDiseñoBoton()
        {
            if (Buttons.Count >= 1)
            {
                label1.Text = Buttons[0].Titulo;
                pictureBox1.Image = Buttons[0].Imagen;
                btn1.Visible = true;
                btn1.Checked = true;
                CargaMenu(0);
            }
            else
                btn1.Visible = false;

            if (Buttons.Count >= 2)
            {
                label2.Text = Buttons[1].Titulo;
                pictureBox2.Image = Buttons[1].Imagen;
                btn2.Visible = true;
            }
            else
                btn2.Visible = false;

            if (Buttons.Count >= 3)
            {
                label3.Text = Buttons[2].Titulo;
                pictureBox3.Image = Buttons[2].Imagen;
                btn3.Visible = true;
            }
            else
                btn3.Visible = false;

            if (Buttons.Count >= 4)
            {
                label4.Text = Buttons[3].Titulo;
                pictureBox4.Image = Buttons[3].Imagen;
                btn4.Visible = true;
            }
            else
                btn4.Visible = false;

            if (Buttons.Count >= 5)
            {
                label5.Text = Buttons[4].Titulo;
                pictureBox5.Image = Buttons[4].Imagen;
                btn5.Visible = true;
            }
            else
                btn5.Visible = false;
        }

        public void UpdateDesign(ColorTable Colores)
        {
            ColorTable = Colores;
        }

        void BtnHide_Click(object sender, EventArgs e)
        {
            for (int i = 120; i > 0; i -= 8)
            {
                splitContainer1.SplitterDistance = i;
            }
            DestroyHandle();
        }

        private void CargaMenu(Int32 index)
        {
            splitContainer1.Panel2.Controls.Clear();
            Buttons[index].UserControl.Parent = splitContainer1.Panel2;
            Buttons[index].UserControl.Dock = DockStyle.Fill;
            Buttons[index].UserControl.Show();
        }

        private void BtnClick_CargarMenu(object sender, EventArgs e)
        {
            if (sender is RibbonPanel)
            {
                CargaMenu(Convert.ToInt32((sender as RibbonPanel).Tag));
            }
            else if (sender is PictureBox)
            {
                CargaMenu(Convert.ToInt32((sender as PictureBox).Tag));
                ((sender as PictureBox).Parent as RibbonPanel).Checked = true;
            }
            else if (sender is Label)
            {
                CargaMenu(Convert.ToInt32((sender as Label).Tag));
                ((sender as Label).Parent as RibbonPanel).Checked = true;
            }
        }

        private void HomeRibbon_Paint(object sender, PaintEventArgs e)
        {
            CargarDiseñoBoton();
        }
    }
}