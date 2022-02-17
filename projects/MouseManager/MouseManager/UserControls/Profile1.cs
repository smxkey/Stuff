using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseManager.UserControls
{
    public partial class Profile1 : UserControl
    {
        public Profile1()
        {
            InitializeComponent();

            // on panel load, update the values
            Value1.Text = Track1.Value.ToString();
            Value2.Text = Track2.Value.ToString();
            Value3.Text = Track3.Value.ToString();

            // let us try to handle the events here
            // handling the value changed event this wasis much cleanner than other ways
            Track1.ValueChanged += Track1_ValueChanged;
            Track2.ValueChanged += Track2_ValueChanged;
            Track3.ValueChanged += Track3_ValueChanged;
        }

        private void Track3_ValueChanged(object sender, EventArgs e)
        {
            Value3.Text = Track3.Value.ToString();
        }

        private void Track2_ValueChanged(object sender, EventArgs e)
        {
            Value2.Text = Track2.Value.ToString();
        }

        private void Track1_ValueChanged(object sender, EventArgs e)
        {
            Value1.Text = Track1.Value.ToString();
        }
    }
}
