using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using McAfeeFuturistic.Controls;
using Siticone.Desktop.UI.WinForms;

namespace McAfeeFuturistic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            new SiticoneShadowForm(this);

            PanelSlider.Controls.Add(new Home() { Dock = DockStyle.Fill, Name = "Home" });
            PanelSlider.Controls.Add(new Privacy() { Dock = DockStyle.Fill, Name = "Privacy" });
            PanelSlider.Controls.Add(new Options() { Dock = DockStyle.Fill, Name = "Options" });
            PanelSlider.Controls.Add(new Security() { Dock = DockStyle.Fill, Name = "Security" });
            PanelSlider.Controls.Add(new Settings() { Dock = DockStyle.Fill, Name = "Settings" });
            PanelSlider.Controls.Add(new Utilities() { Dock = DockStyle.Fill, Name = "Utilities" });
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Control[] cntrls = PanelSlider.Controls.Find("Home", false);
            cntrls[0].BringToFront();
        }

        private void SecurityBtn_Click(object sender, EventArgs e)
        {
            Control[] cntrls = PanelSlider.Controls.Find("Security", false);
            cntrls[0].BringToFront();
        }

        private void PrivacyBtn_Click(object sender, EventArgs e)
        {
            Control[] cntrls = PanelSlider.Controls.Find("Privacy", false);
            cntrls[0].BringToFront();
        }

        private void UtilitiesBtn_Click(object sender, EventArgs e)
        {
            Control[] cntrls = PanelSlider.Controls.Find("Utilities", false);
            cntrls[0].BringToFront();
        }

        private void OptionsBtn_Click(object sender, EventArgs e)
        {
            Control[] cntrls = PanelSlider.Controls.Find("Options", false);
            cntrls[0].BringToFront();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            Control[] cntrls = PanelSlider.Controls.Find("Settings", false);
            cntrls[0].BringToFront();
        }
    }
}
