using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManagerCleanDashboard.UserControls
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();

            SearchBtn.GotFocus += SearchBtn_GotFocus;
            SearchBtn.LostFocus += SearchBtn_LostFocus; ;
        }

        private void SearchBtn_LostFocus(object sender, EventArgs e)
        {
            SearchBtn.IconRight = Properties.Resources.search_dark;
        }

        private void SearchBtn_GotFocus(object sender, EventArgs e)
        {
            SearchBtn.IconRight = Properties.Resources.search_light;
        }
    }
}
