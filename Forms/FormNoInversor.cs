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
    public partial class FormNoInversor : Form
    {
        public FormNoInversor()
        {
            InitializeComponent();
        }

        private double calculatingVout()
        {
            double vout, vi, ri, rf, formula;

            if (voltI.Text == "" || resistI.Text == "" || resistF.Text == "")
            {
                return vout = 0;
            }
            else
            {
                vi = (float)Convert.ToDouble(voltI.Text);
                ri = (float)Convert.ToDouble(resistI.Text);
                rf = (float)Convert.ToDouble(resistF.Text);
                formula = (1 + (rf / ri))*(vi);
                vout = Math.Round(formula, 1, MidpointRounding.ToEven);

                return vout;
            }
        }

        private double ganancia()
        {
            double ganancia, ri, rf;

            if (voltI.Text == "" || resistI.Text == "" || resistF.Text == "")
            {
                return ganancia = 0;
            }
            else
            {
                ri = (float)Convert.ToDouble(resistI.Text);
                rf = (float)Convert.ToDouble(resistF.Text);

                ganancia = Math.Round((1 + (rf / ri)), 1, MidpointRounding.ToEven);

                return ganancia;
            }
        }



        private void voltI_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void resistF_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnVout_Click_1(object sender, EventArgs e)
        {

            string voltage = calculatingVout().ToString();

            lblVolt.Text = voltage + "V";
        }

        private void btnGanancia_Click_1(object sender, EventArgs e)
        {

            string result = ganancia().ToString();

            lblGanancia.Text = "Ganancia:" + result;
        }

        private void btnClean_Click_1(object sender, EventArgs e)
        {

            voltI.Text = null;
            resistF.Text = null;
            resistI.Text = null;
            lblVolt.Text = null;
            lblGanancia.Text = null;
        }

        private void FormNoInversor_Load(object sender, EventArgs e)
        {

        }
    }
}
