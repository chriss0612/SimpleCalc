using System;
using System.Windows.Forms;

namespace SimpelCalc
{
    public partial class Font : Form
    {

        private Calcs calcs;
        private Komplex erg;
        private Komplex storA;
        private Komplex storB;
        private Komplex storC;
        private Komplex storD;
        public Font()
        {
            calcs = new Calcs();
            InitializeComponent();
        }

        private void rad_Click(object sender, EventArgs e)
        {
            rad.Checked = true;
            deg.Checked = false;
            grad.Checked = false;
            Calcs.mode = 0;
            if (input.Text.Contains("sin") || input.Text.Contains("cos") || input.Text.Contains("tan"))
            {
                calc();
            }
            reprint();
        }

        private void deg_Click(object sender, EventArgs e)
        {
            rad.Checked = false;
            deg.Checked = true;
            grad.Checked = false;
            Calcs.mode = 1;
            if (input.Text.Contains("sin") || input.Text.Contains("cos") || input.Text.Contains("tan"))
            {
                erg = calcs.recalc(input.Text);
                reprint();
            }
        }
        private void calc()
        {
            string inp = input.Text;
            if (storA != null) inp=inp.Replace("A", storA.ToString(true));
            if (storB != null) inp=inp.Replace("B", storB.ToString(true));
            if (storC != null) inp=inp.Replace("C", storC.ToString(true));
            if (storD != null) inp=inp.Replace("D", storD.ToString(true));
            erg = calcs.recalc(inp);
        }
        private void grad_Click(object sender, EventArgs e)
        {
            rad.Checked = false;
            deg.Checked = false;
            grad.Checked = true;
            Calcs.mode = 2;
            if (input.Text.Contains("sin")|| input.Text.Contains("cos")|| input.Text.Contains("tan"))
            {
                calc();
            }
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
            calc();
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
            calc();
            reprint();
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            calc();
            reprint();
        }

        private void decpoints_Scroll(object sender, EventArgs e)
        {
            labelDecPoints.Text = "Significant Places: " + decpoints.Value;
            reprint();
        }

        private void reprint()
        {
            if (Calcs.err)
            {
                if (calcs.errkey == Properties.Resources.DefaultKey)
                {
                    output.Text = "Error";
                }
                else if (calcs.errkey == Properties.Resources.DivideByZeroKey)
                {
                    output.Text = "Error: (" + calcs.errkey + ") " + Properties.Resources.DivideByZero;
                }
                else if (calcs.errkey == Properties.Resources.NullConvertDecimalKey || calcs.errkey == Properties.Resources.NullConvertDoubleKey || calcs.errkey == Properties.Resources.NullConvertIntKey)
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
                if (northToolStripMenuItem.Checked)
                {
                    output.Text = erg.ToString("G"+decpoints.Value);
                }
                if (sCIToolStripMenuItem.Checked)
                {
                    output.Text = erg.ToString("E" + decpoints.Value);
                }
            }
        }
        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eToolStripMenuItem.Checked = true;
            calcs.logbase = Calcs.eul;
            if (input.Text.Contains("log"))
            {
                calc();
            }
            reprint();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            eToolStripMenuItem.Checked = false;
            calcs.logbase = calcs.toDouble(toolStripComboBox1.Text);
            if (input.Text.Contains("log"))
            {
                calc();
            }
            reprint();
        }

        private void northToolStripMenuItem_Click(object sender, EventArgs e)
        {
            northToolStripMenuItem.Checked = true;
            sCIToolStripMenuItem.Checked = false;
            reprint();
        }

        private void sCIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            northToolStripMenuItem.Checked = false;
            sCIToolStripMenuItem.Checked = true;
            reprint();
        }

        private void strA_Click(object sender, EventArgs e)
        {
            storA = erg;
            if (northToolStripMenuItem.Checked)
            {
                textA.Text = storA.ToString("G" + decpoints.Value);
            }
            if (sCIToolStripMenuItem.Checked)
            {
                textA.Text = storA.ToString("E" + decpoints.Value);
            }
            calc();
            reprint();
        }
        private void strB_Click(object sender, EventArgs e)
        {
            storB = erg;
            if (northToolStripMenuItem.Checked)
            {
                textB.Text = storB.ToString("G" + decpoints.Value);
            }
            if (sCIToolStripMenuItem.Checked)
            {
                textB.Text = storB.ToString("E" + decpoints.Value);
            }
            calc();
            reprint();
        }
        private void strC_Click(object sender, EventArgs e)
        {
            storC = erg;
            if (northToolStripMenuItem.Checked)
            {
                textC.Text = storC.ToString("G" + decpoints.Value);
            }
            if (sCIToolStripMenuItem.Checked)
            {
                textC.Text = storC.ToString("E" + decpoints.Value);
            }
            calc();
            reprint();
        }
        private void strD_Click(object sender, EventArgs e)
        {
            storD = erg;
            if (northToolStripMenuItem.Checked)
            {
                textD.Text = storD.ToString("G" + decpoints.Value);
            }
            if (sCIToolStripMenuItem.Checked)
            {
                textD.Text = storD.ToString("E" + decpoints.Value);
            }
            calc();
            reprint();
        }
    }
}
