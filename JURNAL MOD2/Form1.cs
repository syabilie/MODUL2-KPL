using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JURNAL_MOD2
{ 
    public partial class Kalkulator : Form
    {
        decimal bil1;
        decimal bil2;
        int oprt;
        Boolean oprtHasil = false;

        public Kalkulator()
        {
            InitializeComponent();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (output.Text == "0")
            {
                output.Text = "2";
            }
            else
            {
                output.Text += "2";
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (output.Text == "0")
            {
                output.Text = "7";
            }
            else
            {
                output.Text += "7";
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (output.Text == "0")
            {
                output.Text = "1";
            }
            else
            {
                output.Text += "1";
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (output.Text == "0")
            {
                output.Text = "3";
            }
            else
            {
                output.Text += "3";
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (output.Text == "0")
            {
                output.Text = "4";
            }
            else
            {
                output.Text += "4";
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (output.Text == "0")
            {
                output.Text = "5";
            }
            else
            {
                output.Text += "5";
            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (output.Text == "0")
            {
                output.Text = "6";
            }
            else
            {
                output.Text += "6";
            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (output.Text == "0")
            {
                output.Text = "8";
            }
            else
            {
                output.Text += "8";
            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (output.Text == "0")
            {
                output.Text = "9";
            }
            else
            {
                output.Text += "9";
            }
        }

        private void b0_Click(object sender, EventArgs e)
        {
            if(output.Text != "0")
            {
                output.Text += "0";
            }
        }

        private void b_plus_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(output.Text);
            text_opr.Text = "+";
            output.Text = " ";
            oprt = 1;
            oprtHasil = true;
        }

        private void b_samadengan_Click(object sender, EventArgs e)
        {
            if(oprtHasil == true)
                bil2 = Convert.ToDecimal(output.Text);
            {
                switch (oprt)
                {
                    case 1:
                        output.Text = Convert.ToString(bil1 + bil2);
                        break;
                }
                oprtHasil = false;
                
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            output.Text = "0";
            bil1 = 0;
            bil2 = 0;
            text_opr.Text = " ";
        }
    }
}
