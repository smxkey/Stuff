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
using UserManagerCleanDashboard.UserControls;

namespace UserManagerCleanDashboard
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            new SiticoneShadowForm(this);
            new SiticoneDragControl(TopHeader);
            new SiticoneDragControl(LogoHub);
            new SiticoneDragControl(DragPanel);

            // add controls
            PanelSlider.Controls.Add(new Dashboard());
            PanelSlider.Controls.Add(new Chat());
            PanelSlider.Controls.Add(new Notifications());
            PanelSlider.Controls.Add(new Sales());
            PanelSlider.Controls.Add(new Settings());
            PanelSlider.Controls.Add(new Reports());
            PanelSlider.Controls.Add(new Roles());
            PanelSlider.Controls.Add(new Accounts());
            PanelSlider.Controls.Add(new Invoices());
        }

        private void RedTrack_Scroll(object sender, ScrollEventArgs e)
        {
            SideNav.BackColor = Color.FromArgb(255, RedTrack.Value, GreenTrack.Value, BlueTrack.Value);
            SideNavButtonContainer.BackColor = Color.FromArgb(255, RedTrack.Value, GreenTrack.Value, BlueTrack.Value);
        }

        private void GreenTrack_Scroll(object sender, ScrollEventArgs e)
        {
            SideNav.BackColor = Color.FromArgb(255, RedTrack.Value, GreenTrack.Value, BlueTrack.Value);
            SideNavButtonContainer.BackColor = Color.FromArgb(255, RedTrack.Value, GreenTrack.Value, BlueTrack.Value);
        }

        private void BlueTrack_Scroll(object sender, ScrollEventArgs e)
        {
            SideNav.BackColor = Color.FromArgb(255, RedTrack.Value, GreenTrack.Value, BlueTrack.Value);
            SideNavButtonContainer.BackColor = Color.FromArgb(255, RedTrack.Value, GreenTrack.Value, BlueTrack.Value);
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            UISwitch("Dashboard", true);
        }

        private void ChatBtn_Click(object sender, EventArgs e)
        {
            UISwitch("Chat", true);
        }

        private void NotificationBtn_Click(object sender, EventArgs e)
        {
            UISwitch("Notifications", true);
        }

        private void SalesBtn_Click(object sender, EventArgs e)
        {
            UISwitch("Sales", true);
        }

        private void SettingBtn_Click(object sender, EventArgs e)
        {
            UISwitch("Settings", true);
        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            UISwitch("Reports", false);
        }
        private void RolesBtn_Click(object sender, EventArgs e)
        {
            UISwitch("Roles", false);
        }

        private void AccountsBtn_Click(object sender, EventArgs e)
        {
            UISwitch("Accounts", false);
        }

        private void InvoicesBtn_Click(object sender, EventArgs e)
        {
            UISwitch("Invoices", false);
        }

        // panel switch
        private void UISwitch(string ui, bool isSideNav)
        {
            switch (ui)
            {
                case "Dashboard":
                    PanelSlider.Controls.Find("Dashboard", false)[0].BringToFront();
                    break;
                case "Notifications":
                    PanelSlider.Controls.Find("Notifications", false)[0].BringToFront();
                    break;
                case "Sales":
                    PanelSlider.Controls.Find("Sales", false)[0].BringToFront();
                    break;
                case "Settings":
                    PanelSlider.Controls.Find("Settings", false)[0].BringToFront();
                    break;
                case "Reports":
                    PanelSlider.Controls.Find("Reports", false)[0].BringToFront();
                    break;
                case "Roles":
                    PanelSlider.Controls.Find("Roles", false)[0].BringToFront();
                    break;
                case "Accounts":
                    PanelSlider.Controls.Find("Accounts", false)[0].BringToFront();
                    break;
                case "Invoices":
                    PanelSlider.Controls.Find("Invoices", false)[0].BringToFront();
                    break;
                case "Chat":
                    PanelSlider.Controls.Find("Chat", false)[0].BringToFront();
                    break;
            }

            switch (isSideNav)
            {
                case true:
                    foreach (SiticoneButton button in DragPanel.Controls.OfType<SiticoneButton>())
                    {
                        button.Checked = false;
                    }
                    break;
                default:
                    foreach (SiticoneButton button in SideNavButtonContainer.Controls.OfType<SiticoneButton>())
                    {
                        button.Checked = false;
                    }
                    break;
            }
        }
    }
}
