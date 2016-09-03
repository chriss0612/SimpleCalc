using System;
using System.Windows.Forms;

namespace SimpelCalc
{
    public partial class Form1 : Form
    {

        private Calcs calcs;
        private decimal erg;
        public Form1()
        {
            calcs = new Calcs();
            InitializeComponent();
        }

        private void rad_Click(object sender, EventArgs e)
        {
            rad.Checked = true;
            deg.Checked = false;
            grad.Checked = false;
            calcs.mode = 0;
            erg = calcs.recalc(input.Text);
            reprint();
        }

        private void deg_Click(object sender, EventArgs e)
        {
            rad.Checked = false;
            deg.Checked = true;
            grad.Checked = false;
            calcs.mode = 1;
            erg = calcs.recalc(input.Text);
            reprint();
        }

        private void grad_Click(object sender, EventArgs e)
        {
            rad.Checked = false;
            deg.Checked = false;
            grad.Checked = true;
            calcs.mode = 2;
            erg = calcs.recalc(input.Text);
            reprint();
        }

        private void emptyTo0_Click(object sender, EventArgs e)
        {

            if (emptyTo0.Checked)
            {
                emptyTo0.Checked = false;
            }
            else
            {
                emptyTo0.Checked = true;
                convertErrorTo0.Checked = false;
            }

            calcs.nullto0 = emptyTo0.Checked;
            erg = calcs.recalc(input.Text);
            reprint();
        }

        private void convertErrorTo0_Click(object sender, EventArgs e)
        {
            if (convertErrorTo0.Checked)
            {
                convertErrorTo0.Checked = false;
            }
            else
            {
                convertErrorTo0.Checked = true;
                emptyTo0.Checked = false;
            }
            calcs.errto0 = convertErrorTo0.Checked;
            erg = calcs.recalc(input.Text);
            reprint();
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            erg = calcs.recalc(input.Text);
            reprint();
        }

        private void decpoints_Scroll(object sender, EventArgs e)
        {
            labelDecPoints.Text = "decimal points: " + decpoints.Value;
            reprint();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void reprint()
        {
            if (calcs.err)
            {
                if (calcs.errkey == Properties.Resources.DefaultKey)
                {
                    output.Text = "Error";
                }
                else if (calcs.errkey == Properties.Resources.DivideByZeroKey)
                {
                    output.Text = "Error: (" + calcs.errkey + ") " + Properties.Resources.DivideByZero;
                }
                else if (calcs.errkey == Properties.Resources.NullConvertDecimalKey|| calcs.errkey == Properties.Resources.NullConvertDoubleKey || calcs.errkey == Properties.Resources.NullConvertIntKey)
                {
                    output.Text = "Error: (" + calcs.errkey + ") " + Properties.Resources.NullConvert;
                }
                else if (calcs.errkey == Properties.Resources.ErrConvertDoubleKey || calcs.errkey == Properties.Resources.ErrConvertDecimalKey || calcs.errkey == Properties.Resources.ErrConvertIntKey)
                {
                    output.Text = "Error: (" + calcs.errkey + ") " + Properties.Resources.ErrConvert;
                }
                else if (calcs.errkey == Properties.Resources.PotAndEKey)
                {
                    output.Text = "Error: (" + calcs.errkey + ") " + Properties.Resources.PotAndE;
                }
                else
                {
                    output.Text = "Error: " + calcs.errkey;
                }
                
            }
            else
            {
                output.Text = Convert.ToString(Math.Round(erg, decpoints.Value));
            }
        }

    }
}
