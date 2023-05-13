using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnterpriseUpdater.Forms
{
    public partial class FrmMain:RibbonForm 
    {
        public FrmMain()
        {
            InitializeComponent();
            RibbonManager Skin = new RibbonManager(this,System.Windows.Forms.Skin.Blue);
            Skin.UpdateSkin();
        }
    }
}
