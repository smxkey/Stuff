using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MouseManager.UserControls;
using Siticone.Desktop.UI.WinForms;

namespace MouseManager
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();

            // add shadow to the form
            new SiticoneShadowForm(this);

            // add drag capability
            new SiticoneDragControl(SideContainer);
            new SiticoneDragControl(this);

            // add user controls to the panel slider
            PanelSlider.Controls.Add(new Profile1());
            PanelSlider.Controls.Add(new Profile2());
            PanelSlider.Controls.Add(new Profile3());
        }

        private void Profile1_Click(object sender, EventArgs e)
        {
            // show the selected profile
            PanelSlider.Controls.Find("Profile1", false)[0].BringToFront();
        }

        private void Profile2_Click(object sender, EventArgs e)
        {
            // show the selected profile
            PanelSlider.Controls.Find("Profile2", false)[0].BringToFront();
        }

        private void Profile3_Click(object sender, EventArgs e)
        {
            // show the selected profile
            PanelSlider.Controls.Find("Profile3", false)[0].BringToFront();
        }
    }
}
