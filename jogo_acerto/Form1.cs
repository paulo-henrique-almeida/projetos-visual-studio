using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo_acerto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtent_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnverifica_Click(object sender, EventArgs e)
        {
            if (txtent.Text == txtpalavra.Text)
            {
                MessageBox.Show("Parabéns!!! Você acertou a palavra!!!");
            } else
            {
                if (lblcont.Text == "0")
                {
                    MessageBox.Show("Você errou!!!");
                    grbdica.Visible = true;
                } else
                {
                    if (lblcont.Text == "1")
                    {
                        MessageBox.Show("Você errou!!!");
                        lbld2.Visible = true;
                    }
                    else
                    {
                        if (lblcont.Text == "2")
                        {
                            MessageBox.Show("Você errou!!!");
                            lbld3.Visible = true;
                        }
                        else
                        {
                            grbdica.Visible = false;
                            txtent.Enabled = false;
                            btnverifica.Enabled = false;
                        }
                    }
                }
            }
            lblcont.Text = Convert.ToString(Convert.ToInt16(lblcont.Text) + 1);
            lblres.Text = Convert.ToString(Convert.ToInt16(lblres.Text) - 1);
        }

        private void btnaltera_Click(object sender, EventArgs e)
        {
            txtpalavra.Text = txtpalavra.Text.ToUpper();
            grbpalavra.Visible = false;
            txtent.Enabled = true;
            btnverifica.Enabled = true;
            txtd1.Enabled = false;
            txtd2.Enabled = false;
            txtd3.Enabled = false;
            txtpalavra.Enabled = false;
        }

        private void lblcont_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtnome.Text == "Paulo" && txtsenha.Text == "05042006")
            {
                grbpalavra.Visible = true;
                btnaltera.Enabled = true;
                txtpalavra.Enabled = true;
                txtd1.Enabled = true;
                txtd2.Enabled = true;
                txtd3.Enabled = true;
            }
        }
    }
}
