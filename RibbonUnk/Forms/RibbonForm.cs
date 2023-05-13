using System.ComponentModel;
using System.Drawing;

namespace System.Windows.Forms
{
	public partial class RibbonForm : Form
	{
		//#CONSTANTES
		const int CGRIP = 16;
		const int CCAPTION = 32;
		const int MOUSE_MOVE = 0XF012;
		const int WM_SYSCOMMAND = 0X112;
		const int HTLEFT = 10, HTRIGHT = 11, HTTOP = 12, HTTOPLEFT = 13, HTTOPRIGHT = 14, HTBOTTOM = 15, HTBOTTOMLEFT = 16, HTBOTTOMRIGHT = 17;
		const int _ = 10;
		private Image ImagenBack = null;

		[Browsable(false)]
		public Image ControlBoxImagen
		{
			get
			{
				return ImagenBack;
			}
			set
			{
				ImagenBack = value;
				if (this.ControlBoxImagen != null)
					this.rControlBox.BackgroundImage = value;
				else
					this.rControlBox.BackgroundImage = null;
			}
		}

		//VARIABLES LOCALES
		Int32 x, y, xz, yz;

		//#LLAMADAS A USER32.DLL
		[System.Runtime.InteropServices.DllImportAttribute("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();

		[System.Runtime.InteropServices.DllImportAttribute("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int Iparam);

		//#PROPIEDADES
		//#RIBBON DESIGN
		#region Propiedades				
		[Category("Ribbon Design"), DefaultValue(false)]
		public bool RibbonFormMdi { get; set; }

		Color colorribbon = Color.White;
		[Category("Ribbon Design")]
		public Color ColorRibbon
		{
			get { return colorribbon; }
			set
			{
				colorribbon = value;
				this.PaintRibbonForm();
			}
		}

		bool buttonsoption = true;
		[Category("Ribbon Design")]
		public bool ButtonsOption
		{
			get
			{
				return buttonsoption;
			}
			set
			{
				buttonsoption = value;
				MenuButtonsLeft.Visible = value;
				MenuButtosRight.Visible = value;
			}
		}

		//#RIBBON DESIGN BUTTON MAXIMIZE
		private Color backCmaximize = Color.FromArgb(255, 255, 255);
		[Category("Ribbon Maximize Button")]
		public Color BackColorMaximize
		{
			get { return backCmaximize; }
			set
			{
				backCmaximize = value;
				this.PaintRibbonForm();
			}
		}

		private Color backCmaximizefocus = Color.FromArgb(229, 229, 229);
		[Category("Ribbon Maximize Button")]
		public Color BackColorMaximizeFocus
		{
			get { return backCmaximizefocus; }
			set
			{
				backCmaximizefocus = value;
				this.PaintRibbonForm();
			}
		}

		private Color backCmaximizeclick = Color.FromArgb(202, 202, 203);
		[Category("Ribbon Maximize Button")]
		public Color BackColorMaximizeClick
		{
			get { return backCmaximizeclick; }
			set
			{
				backCmaximizeclick = value;
				this.PaintRibbonForm();
			}
		}

		//#RIBBON DESIGN BUTTON MINIMIZE
		private Color backCminimize = Color.FromArgb(255, 255, 255);
		[Category("Ribbon Minimize Button")]
		public Color BackColorMinimize
		{
			get { return backCminimize; }
			set
			{
				backCminimize = value;
				this.PaintRibbonForm();
			}
		}

		private Color backCminimizefocus = Color.FromArgb(229, 229, 229);
		[Category("Ribbon Minimize Button")]
		public Color BackColorMinimizeFocus
		{
			get { return backCminimizefocus; }
			set
			{
				backCminimizefocus = value;
				this.PaintRibbonForm();
			}
		}

		private Color backCminimizeclick = Color.FromArgb(202, 202, 203);
		[Category("Ribbon Minimize Button")]
		public Color BackColorMinimizeClick
		{
			get { return backCminimizeclick; }
			set
			{
				backCminimizeclick = value;
				this.PaintRibbonForm();
			}
		}

		//#RIBBON DESGIN OTROS
		private Color foreCcontrolbox = Color.Black;
		[Category("Ribbon Design Otros")]
		public Color ForeColorControlBox
		{
			get { return foreCcontrolbox; }
			set
			{
				foreCcontrolbox = value;
				this.PaintRibbonForm();
			}
		}

		private Color foreCtitulotext = Color.FromArgb(0, 0, 0);
		[Category("Ribbon Design Otros")]
		public Color ForeColortituloText
		{
			get { return foreCtitulotext; }
			set
			{
				foreCtitulotext = value;
				this.PaintRibbonForm();
			}
		}

		//#PROPIEDADES PRIVADAS
		private Point Location1 { get; set; }
		private Size Size1 { get; set; }

		Rectangle Top
		{
			get { return new Rectangle(0, 0, this.ClientSize.Width, _); }
		}

		Rectangle Left
		{
			get { return new Rectangle(0, 0, _, this.ClientSize.Height); }
		}

		Rectangle Bottom
		{
			get { return new Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); }
		}

		Rectangle Right
		{
			get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); }
		}

		Rectangle TopLeft
		{
			get { return new Rectangle(0, 0, _, _); }
		}

		Rectangle TopRight
		{
			get { return new Rectangle(this.ClientSize.Width - _, 0, _, _); }
		}

		Rectangle BottomLeft
		{
			get { return new Rectangle(0, this.ClientSize.Height - _, _, _); }
		}

		Rectangle BottomRight
		{
			get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); }
		}
		#endregion

		//#CONSTRUCTOR
		public RibbonForm()
		{
			InitializeComponent();
			this.rControlBox.Height = 32;
			//#los bordes del ribbon se muestren sobre cualquier control
			Control[] ObjControles = new Control[] {
				this.rBorderLeft,
				this.rBorderRight,
				this.rBorderTop,
				this.rBorderBottom,
				this.rControlBox
			};
			foreach (Control ObjC in ObjControles)
			{
				ObjC.BringToFront();
			}

			//#obteniendo la ubicacion y el tamaño
			Location1 = new Point(this.Location.X, this.Location.Y);
			Size1 = new Size(this.Width, this.Height);

			MenuButtonsLeft.Visible = ButtonsOption;
			MenuButtosRight.Visible = ButtonsOption;

			if (this.ControlBoxImagen != null)
				this.rControlBox.BackgroundImage = this.ControlBoxImagen;
			else
				this.rControlBox.BackgroundImage = null;

			this.DoubleBuffered = true;
			this.FormBorderStyle = FormBorderStyle.None;
			this.SetStyle(ControlStyles.ResizeRedraw, true);
		}

		//#METODOS Y EVENTOS
		#region Metodos Y Eventos
		Color ColorBordeDefault = Color.FromArgb(24, 112, 181);
		void PaintRibbonForm()
		{
			//#Asignando el Titulo y el Color Asignado 
			this.rTitulo.Text = this.Text;
			this.rTitulo.ForeColor = ForeColortituloText;

			//Asignando el icono y los botones si estaran visibles
			this.rPictureBoxIcon.Image = this.Icon.ToBitmap();
			this.btnMinimize.Enabled = this.MinimizeBox ? true : false;
			this.btnMaximize.Enabled = this.MaximizeBox ? true : false;

			//Si los botones no seran visibles se ocultan
			if (!this.MaximizeBox && !this.MinimizeBox)
			{
				this.btnMaximize.Visible = false;
				this.btnMinimize.Visible = false;
			}

			//Cmbiando el color del borde del Form de acuerdo al colorribbon
			if (colorribbon != Color.White)
			{
				if (colorribbon != Color.Transparent)
				{
					this.rBorderRight.BackColor = colorribbon;
					this.rBorderLeft.BackColor = colorribbon;
					this.rBorderTop.BackColor = colorribbon;
					this.rBorderBottom.BackColor = colorribbon;
					backCminimize = colorribbon;
					backCmaximize = colorribbon;
				}
				else
				{
					this.rBorderRight.BackColor = ColorBordeDefault;
					this.rBorderLeft.BackColor = ColorBordeDefault;
					this.rBorderTop.BackColor = ColorBordeDefault;
					this.rBorderBottom.BackColor = ColorBordeDefault;
					backCminimize = Color.Transparent;
					backCmaximize = Color.Transparent;
				}
			}
			else
			{
				this.rBorderRight.BackColor = ColorBordeDefault;
				this.rBorderLeft.BackColor = ColorBordeDefault;
				this.rBorderTop.BackColor = ColorBordeDefault;
				this.rBorderBottom.BackColor = ColorBordeDefault;
				backCminimize = Color.Transparent;
				backCmaximize = Color.Transparent;
			}

			this.rControlBox.BackColor = colorribbon;
			this.rControlBox.BackGroundColorFocus = colorribbon;
			this.rControlBox.BackGroundColor = colorribbon;
			this.rControlBox.BackGroundColorClick = colorribbon;

			this.rTitulo.BackColor = this.rControlBox.BackColor;

			//#Asignando el Color a los Botones
			this.btnMaximize.BackGroundColor = backCmaximize;
			this.btnMaximize.BackGroundColorFocus = backCmaximizefocus;
			this.btnMaximize.BackGroundColorClick = backCmaximizeclick;

			this.btnMinimize.BackGroundColor = backCminimize;
			this.btnMinimize.BackGroundColorFocus = backCminimizefocus;
			this.btnMinimize.BackGroundColorClick = backCminimizeclick;
		}

		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}

		void BtnmaximizeClick(object sender, EventArgs e)
		{
			if (btnMaximize.Enabled)
			{
				if (RibbonFormMdi)
				{
					this.Location = Screen.PrimaryScreen.WorkingArea.Location;
					this.Size = Screen.PrimaryScreen.WorkingArea.Size;
				}
				else
				{
					if (this.Parent != null)
						this.WindowState = (this.WindowState == FormWindowState.Maximized) ? FormWindowState.Normal : FormWindowState.Maximized;
					else
					{
						if (this.Location == Screen.PrimaryScreen.WorkingArea.Location && this.Size == Screen.PrimaryScreen.WorkingArea.Size)
						{
							this.Size = Size1;
							this.Location = Location1;
						}
						else
						{
							Location1 = new Point(this.Location.X, this.Location.Y);
							Size1 = new Size(this.Width, this.Height);

							this.Location = Screen.PrimaryScreen.WorkingArea.Location;
							this.Size = Screen.PrimaryScreen.WorkingArea.Size;
						}
					}
				}
			}
		}

		void BtnminimizeClick(object sender, EventArgs e)
		{
			if (btnMinimize.Enabled)
				this.WindowState = FormWindowState.Minimized;
		}

		void RibbonFormLoad(object sender, EventArgs e)
		{
			this.PaintRibbonForm();

			if (RibbonFormMdi)
			{
				this.Location = Screen.PrimaryScreen.WorkingArea.Location;
				this.Size = Screen.PrimaryScreen.WorkingArea.Size;
			}
			if (this.StartPosition == FormStartPosition.CenterScreen || this.StartPosition == FormStartPosition.CenterParent)
			{
				if (!RibbonFormMdi)
				{
					if (this.Parent != null)
					{
						x = (this.Parent.Width - this.Width) / 2;
						y = (this.Parent.Height - this.Height) / 2;
						this.Location = new Point(x, y);
					}
				}
			}

			//# Asignando la ubicacion del titulo de acuerdo si tiene botones de opciones
			//# en la parte superior
			if (!buttonsoption)
			{
				this.rTitulo.Size = new Size(this.rTitulo.Width + 100, 16);
				this.rTitulo.Location = new Point(33, 5);
			}
			else
			{
				this.rTitulo.Location = new Point(84, 5);
			}

			this.DoubleBuffered = true;
			SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
		}

		void PanelControlBoxMouseMove(object sender, MouseEventArgs e)
		{
			MoveForm();
		}

		private void MoveForm()
		{
			ReleaseCapture();
			SendMessage(this.Handle, WM_SYSCOMMAND, MOUSE_MOVE, 0);
		}

		void RibbonFormClick(object sender, EventArgs e)
		{
			this.BringToFront();
		}

		void LblcloseMouseMove(object sender, MouseEventArgs e)
		{
			this.lblclose.ForeColor = Color.White;
		}

		void LblcloseMouseLeave(object sender, EventArgs e)
		{
			this.lblclose.ForeColor = ForeColorControlBox;
		}

		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);
			if (m.Msg == 0x84) // WM_NCHITTEST
			{
				var cursor = this.PointToClient(Cursor.Position);
				if (TopLeft.Contains(cursor))
					m.Result = (IntPtr)HTTOPLEFT;
				else if (TopRight.Contains(cursor))
					m.Result = (IntPtr)HTTOPRIGHT;
				else if (BottomLeft.Contains(cursor))
					m.Result = (IntPtr)HTBOTTOMLEFT;
				else if (BottomRight.Contains(cursor))
					m.Result = (IntPtr)HTBOTTOMRIGHT;
				else if (Top.Contains(cursor))
					m.Result = (IntPtr)HTTOP;
				else if (Left.Contains(cursor))
					m.Result = (IntPtr)HTLEFT;
				else if (Right.Contains(cursor))
					m.Result = (IntPtr)HTRIGHT;
				else if (Bottom.Contains(cursor))
					m.Result = (IntPtr)HTBOTTOM;
			}
		}

		void BtnControlBoxPaint(object sender, PaintEventArgs e)
		{
			this.lbl_maximize.ForeColor = ForeColorControlBox;
			this.lbl_minimize.ForeColor = ForeColorControlBox;
		}

		private void RibbonForm_KeyDown(object sender, KeyEventArgs e)
		{
			xz = Screen.PrimaryScreen.WorkingArea.Size.Width / 2;
			yz = Screen.PrimaryScreen.WorkingArea.Size.Height;
			x = Screen.PrimaryScreen.WorkingArea.Size.Width;

			if (RibbonFormMdi)
			{
				if (e.Control && e.KeyCode == Keys.Left)
				{
					this.Location = new Point(0, 0);
					this.Size = new Size(xz, yz);
				}
				if (e.Control && e.KeyCode == Keys.Right)
				{
					this.Location = new Point(xz, 0);
					this.Size = new Size(xz, yz);
				}
			}
		}
		#endregion
	}
}
