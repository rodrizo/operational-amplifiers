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
    public partial class FormVoltage : Form
    {
        public FormVoltage()
        {
            InitializeComponent();
        }

        public double calculateVref()
        {

            double vref, vut, vlt, n, vctr, vh;

            if (VUT.Text == "" || VLT.Text == "")
            {
                return vref = 0;
            }
            else
            {
                vut = (int)Convert.ToDouble(VUT.Text);
                vlt = (int)Convert.ToDouble(VLT.Text);

                if ((vut < 15 && vlt < 15) && (vut != vlt))
                {
                    vctr = (vut + vlt) / 2;
                    vh = vut - vlt;

                    n = ((15 - (-15)) / vh) - 1;

                    vref = Math.Round(((n + 1) / n) * (vctr), 1, MidpointRounding.ToEven);

                    return vref;
                }
                else
                {
                    if (vut == vlt)
                    {
                        MessageBox.Show("⚠️¡VUT y VLT no pueden ser similares!⚠️", "⚠️ERROR⚠️");
                    }
                    else
                    {
                        MessageBox.Show("⚠️¡No puedes poner voltajes superiores a Vsat!⚠️", "⚠️ERROR⚠️");
                    }
                    return 0;
                }


            }
        }

        private void btnVout_Click(object sender, EventArgs e)
        {
            string voltage = calculateVref().ToString();

            lblVref.Text = voltage + "V";

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            VUT.Text = null;
            VLT.Text = null;
            lblVref.Text = null;
        }

        private void VUT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void VLT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }
    }
}
