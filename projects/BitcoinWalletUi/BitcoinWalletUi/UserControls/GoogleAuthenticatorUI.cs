using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siticone.Desktop.UI.WinForms;

namespace BitcoinWalletUi.UserControls
{
    public partial class GoogleAuthenticatorUI : Form
    {
        public GoogleAuthenticatorUI()
        {
            InitializeComponent();
            new SiticoneShadowForm(this);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
