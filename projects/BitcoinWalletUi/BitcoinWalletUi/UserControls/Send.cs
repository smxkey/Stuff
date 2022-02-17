using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitcoinWalletUi.UserControls
{
    public partial class Send : UserControl
    {
        public Send()
        {
            InitializeComponent();
        }

        private void AuthBtn_Click(object sender, EventArgs e)
        {
            new GoogleAuthenticatorUI().ShowDialog();
        }
    }
}
