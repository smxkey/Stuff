using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SearchableMenu.UserControls;
using Siticone.Desktop.UI.WinForms;

namespace SearchableMenu
{
    public partial class Form1 : Form
    {
        private readonly IEnumerable<SiticoneButton> MenuButtons;

        public Form1()
        {
            InitializeComponent();
            new SiticoneShadowForm(this);
            new SiticoneDragControl(this);

            // save all buttons to the list
            MenuButtons = MenuContainer.Controls.OfType<SiticoneButton>();

            // add user controls
            var hiddenUI = new EmptyResultsUI();
            hiddenUI.Hide();

            MenuContainer.Controls.Add(hiddenUI);

            PanelSlider.Controls.Add(new Dashboard());
            PanelSlider.Controls.Add(new Account());
            PanelSlider.Controls.Add(new Accounts());
            PanelSlider.Controls.Add(new Profile());
            PanelSlider.Controls.Add(new Users());
            PanelSlider.Controls.Add(new Settings());
            PanelSlider.Controls.Add(new Securities());
            PanelSlider.Controls.Add(new Security());
            PanelSlider.Controls.Add(new Preferences());

            // search
            SearchBx.TextChanged += SearchBx_TextChanged;
        }

        private void SearchBx_TextChanged(object sender, EventArgs e)
        {
            int hiddenButtons = 0;

            foreach (SiticoneButton button in MenuButtons)
            {
                if (button.Text.ToLower().Contains(SearchBx.Text.ToLower()))
                {
                    button.Show();
                    continue;
                }
                else
                {
                    button.Hide();
                    hiddenButtons += 1;

                }
            }

            // if all the buttons are hidden, show the empty ui
            if (hiddenButtons == MenuContainer.Controls.OfType<SiticoneButton>().Count())
            {
                MenuContainer.Controls.Find("EmptyResultsUI", false)[0].Show();
            }
            else
            {
                MenuContainer.Controls.Find("EmptyResultsUI", false)[0].Hide();
            }
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            PanelSlider.Controls.Find("Dashboard", false)[0].BringToFront();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            PanelSlider.Controls.Find("Settings", false)[0].BringToFront();
        }

        private void AccountBtn_Click(object sender, EventArgs e)
        {
            PanelSlider.Controls.Find("Account", false)[0].BringToFront();
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            PanelSlider.Controls.Find("Profile", false)[0].BringToFront();
        }

        private void PreferenceBtn_Click(object sender, EventArgs e)
        {
            PanelSlider.Controls.Find("Preferences", false)[0].BringToFront();
        }

        private void SecurityBtn_Click(object sender, EventArgs e)
        {
            PanelSlider.Controls.Find("Security", false)[0].BringToFront();
        }

        private void Users1Btn_Click(object sender, EventArgs e)
        {
            PanelSlider.Controls.Find("Users", false)[0].BringToFront();
        }

        private void SecuritiesBtn_Click(object sender, EventArgs e)
        {
            PanelSlider.Controls.Find("Securities", false)[0].BringToFront();
        }

        private void AccountsBtn_Click(object sender, EventArgs e)
        {
            PanelSlider.Controls.Find("Accounts", false)[0].BringToFront();
        }
    }
}
