using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace System.Windows.Forms
{
    public partial class RibbonFormTheme : RibbonForm
    {
        public RibbonManager ribbonManager  { get; set; }
        public Form form  { get; set; }

        public RibbonFormTheme(Form _form ,RibbonManager _ribbonManager )
        {
            InitializeComponent();
            form = _form;
            ribbonManager = _ribbonManager;
        }
    }
}
