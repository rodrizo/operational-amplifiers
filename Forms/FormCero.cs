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
    public partial class FormCero : Form
    {
        public FormCero()
        {
            InitializeComponent();
        }

        public int calculateVout()
        {

            int vout, vi, vt;

            if (voltI.Text == "" || voltTwo.Text == "")
            {
                return vout = 0;
            }
            else
            {
                vi = (int)Convert.ToDouble(voltI.Text);
                vt = (int)Convert.ToDouble(voltTwo.Text);

                return vout = (vi > vt) ? 10 : (-10);
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

            lblVout.Text = voltage + "V";
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            voltI.Text = null;
            voltTwo.Text = null;
            lblVout.Text = null;
        }
    }
}
