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
    public partial class FormRestador : Form
    {
        public FormRestador()
        {
            InitializeComponent();
        }
        private double calculatingVout()
        {
            double vout, vi, ri, vt, rt, rf, rx, formula;

            if (voltI.Text == "" || voltTwo.Text == "" || resistTwo.Text == "" || resistI.Text == "" || resistF.Text == "" || resistFour.Text == "")
            {
                return vout = 0;
            }
            else
            {
                vi = (float)Convert.ToDouble(voltI.Text);
                vt = (float)Convert.ToDouble(voltTwo.Text);
                ri = (float)Convert.ToDouble(resistI.Text);
                rt = (float)Convert.ToDouble(resistTwo.Text);
                rf = (float)Convert.ToDouble(resistF.Text);
                rx = (float)Convert.ToDouble(resistFour.Text);
                formula = (((rx * (rt + rf)) / (rt * (ri + rx))) * vi) - ((rf / rt) * vt);
                vout = Math.Round(formula, 1, MidpointRounding.ToEven);

                return vout;
            }
        }

        private void resistF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void resistI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
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

        private void resistTwo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void resistFour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void btnVout_Click(object sender, EventArgs e)
        {
            string voltage = calculatingVout().ToString();

            lblVolt.Text = voltage + "V";

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            voltI.Text = null;
            voltTwo.Text = null;
            resistF.Text = null;
            resistI.Text = null;
            resistTwo.Text = null;
            resistFour.Text = null;
            lblVolt.Text = null;
            labelGanancia.Text = null;

        }
    }
}
