using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpelCalc
{
    public partial class Form1 : Form
    {

        private Calcs calcs;
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
            output.Text = calcs.recalc(input.Text);
        }

        private void deg_Click(object sender, EventArgs e)
        {
            rad.Checked = false;
            deg.Checked = true;
            grad.Checked = false;
            calcs.mode = 1;
            output.Text = calcs.recalc(input.Text);
        }

        private void grad_Click(object sender, EventArgs e)
        {
            rad.Checked = false;
            deg.Checked = false;
            grad.Checked = true;
            calcs.mode = 2;
            output.Text = calcs.recalc(input.Text);
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
            output.Text = calcs.recalc(input.Text);
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
            output.Text = calcs.recalc(input.Text);
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            output.Text = calcs.recalc(input.Text);
        }

        private void decpoints_Scroll(object sender, EventArgs e)
        {
            labelDecPoints.Text = "decimal points: " + decpoints.Value;
            calcs.decpl = decpoints.Value;
            output.Text = calcs.recalc(input.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
