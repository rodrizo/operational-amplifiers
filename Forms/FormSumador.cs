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
    public partial class FormSumador : Form
    {
        public FormSumador()
        {
            InitializeComponent();
        }
        private double calculatingVout()
        {
            double vout, vi, ri, vt, rt, rf, formula;

            if (voltI.Text == "" || voltTwo.Text == "" || resistTwo.Text == "" || resistI.Text == "" || resistF.Text == "")
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
                formula = -rf * ((vi / ri) + (vt / rt));
                vout = Math.Round(formula, 1, MidpointRounding.ToEven);

                return vout;
            }
        }

        private string ganancia()
        {
            double ganancia1, ganancia2, ri, rf, rt;
            string fullText;

            if ( resistTwo.Text == "" || resistI.Text == "" || resistF.Text == "")
            {
                return fullText = "0";
            }
            else
            {
                ri = (float)Convert.ToDouble(resistI.Text);
                rt = (float)Convert.ToDouble(resistTwo.Text);
                rf = (float)Convert.ToDouble(resistF.Text);

                ganancia1 = Math.Round((-rf / ri), 1, MidpointRounding.ToEven);
                ganancia2 = Math.Round((-rf / rt), 1, MidpointRounding.ToEven);

                fullText = $"Ganancia 1 -> {ganancia1}\nGanancia 2 -> {ganancia2}";
                return fullText;
            }
        }


        private void resistF_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void resistI_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void btnClean_Click(object sender, EventArgs e)
        {
            voltI.Text = null;
            voltTwo.Text = null;
            resistF.Text = null;
            resistI.Text = null;
            resistTwo.Text = null;
            lblVolt.Text = null;
            labelGanancia.Text = null;
        }

        private void btnGanancia_Click(object sender, EventArgs e)
        {
            string result = ganancia().ToString();

            labelGanancia.Text = result;
        }

        private void btnVout_Click(object sender, EventArgs e)
        {
            string voltage = calculatingVout().ToString();

            lblVolt.Text = voltage + "V";
        }

    }
}
