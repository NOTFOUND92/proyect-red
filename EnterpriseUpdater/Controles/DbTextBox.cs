using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnterpriseUpdater.Controles
{
    public class DbTextBox:TextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e); 
            if (e.KeyChar ==13)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
