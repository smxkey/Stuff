using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BitcoinWalletUi.UserControls;
using Siticone.Desktop.UI.WinForms;

namespace BitcoinWalletUi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            new SiticoneDragControl(this);
            new SiticoneShadowForm(this);

            PanelSlider.Controls.Add(new Send());
            PanelSlider.Controls.Add(new History());
            PanelSlider.Controls.Add(new Receive());
        }

        private void HistoryBtn_Click(object sender, EventArgs e)
        {
            PanelSlider.Controls.Find("History", false)[0].BringToFront();
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            PanelSlider.Controls.Find("Send", false)[0].BringToFront();
        }

        private void ReceiveBtn_Click(object sender, EventArgs e)
        {
            PanelSlider.Controls.Find("Receive", false)[0].BringToFront();
        }
    }
}
