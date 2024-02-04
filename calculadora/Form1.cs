using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            Conta();
            lblope.Text = "÷";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Conta()
        {
            if (lblope.Text == "P")
            {
                lblres.Text = txtvisor.Text;
            } else if (lblope.Text == "+")
            {
                lblres.Text = Convert.ToString(Convert.ToDecimal(lblres.Text) + Convert.ToDecimal(txtvisor.Text));
            }
            else if (lblope.Text == "-")
            {
                lblres.Text = Convert.ToString(Convert.ToDecimal(lblres.Text) - Convert.ToDecimal(txtvisor.Text));
            }
            else if (lblope.Text == "×")
            {
                lblres.Text = Convert.ToString(Convert.ToDecimal(lblres.Text) * Convert.ToDecimal(txtvisor.Text));
            }
            else if (lblope = "%")
            {
                lblres.Text = Convert.ToString(Convert.ToDecimal(lblres.Text) / 100);
            }
            else
            {
                if (txtvisor.Text == "0")
                {
                    txtvisor.Text = "Resultado indefinido ou indeterminado.";
                    lblres.Text = "0";
                    lblope.Text = "P";
                } else
                {
                    lblres.Text = Convert.ToString(Convert.ToDecimal(lblres.Text) / Convert.ToDecimal(txtvisor.Text));
                }
            }

            if (txtvisor.Text != "Resultado indefinido ou indeterminado.")
            {
                txtvisor.Text = "0";
            }
            btnpt.Enabled = true;
        }

        private void btnce_Click(object sender, EventArgs e)
        {
            txtvisor.Text = "0";
            btnpt.Enabled = true;
            lblope.Text = "P";
            lblres.Text = "0";
        }

        private void lblnum_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txtvisor.Text) == 0)
            {
                txtvisor.Text = "1";
            } else
            {
                txtvisor.Text = txtvisor.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txtvisor.Text) == 0)
            {
                txtvisor.Text = "2";
            }
            else
            {
                txtvisor.Text = txtvisor.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txtvisor.Text) == 0)
            {
                txtvisor.Text = "3";
            }
            else
            {
                txtvisor.Text = txtvisor.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txtvisor.Text) == 0)
            {
                txtvisor.Text = "4";
            }
            else
            {
                txtvisor.Text = txtvisor.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txtvisor.Text) == 0)
            {
                txtvisor.Text = "5";
            }
            else
            {
                txtvisor.Text = txtvisor.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txtvisor.Text) == 0)
            {
                txtvisor.Text = "6";
            }
            else
            {
                txtvisor.Text = txtvisor.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txtvisor.Text) == 0)
            {
                txtvisor.Text = "7";
            }
            else
            {
                txtvisor.Text = txtvisor.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txtvisor.Text) == 0)
            {
                txtvisor.Text = "8";
            }
            else
            {
                txtvisor.Text = txtvisor.Text + "8";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txtvisor.Text) == 0)
            {
                txtvisor.Text = "9";
            }
            else
            {
                txtvisor.Text = txtvisor.Text + "9";
            }
        }

        private void btnpt_Click(object sender, EventArgs e)
        {
            txtvisor.Text = txtvisor.Text + ".";
            btnpt.Enabled = false;
        }

        private void btnmm_Click(object sender, EventArgs e)
        {
            txtvisor.Text = Convert.ToString(Convert.ToDecimal(txtvisor.Text) * (-1));
        }

        private void btnadc_Click(object sender, EventArgs e)
        {
            Conta();
            lblope.Text = "+";
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            Conta();
            lblope.Text = "-";
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            Conta();
            lblope.Text = "×";
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            Conta();
            txtvisor.Text = lblres.Text;
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            lblres.Text = "0";
            lblope.Text = "P";
            txtvisor.Text = "0";
            btnpt.Enabled = true;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txtvisor.Text) != 0)
            {
                txtvisor.Text = txtvisor.Text + "0";
            }
        }

        private void btnpor_Click(object sender, EventArgs e)
        {
            Conta();
            lblope.Text = "%";
        }
    }
}
