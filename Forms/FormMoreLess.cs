using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operational_amplifiers.Forms
{
    public partial class FormMoreLess : Form
    {
        public FormMoreLess()
        {
            InitializeComponent();
        }

        public string calculateVout()
        {

            int vi, vt;
            string vout;

            if (voltI.Text == "" || voltTwo.Text == "")
            {
                return vout = "0";
            }
            else
            {
                vi = (int)Convert.ToDouble(voltI.Text);
                vt = (int)Convert.ToDouble(voltTwo.Text);

                return vout = (vi > vt) ? "+" : ("-");
            }
        }
        private void voltI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void voltTwo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void btnVout_Click(object sender, EventArgs e)
        {
            string voltage = calculateVout().ToString();

            lblVout.Text = voltage;

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            voltI.Text = null;
            voltTwo.Text = null;
            lblVout.Text = null;
        }
    }
}
