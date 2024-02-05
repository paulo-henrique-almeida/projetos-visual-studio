using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_velha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            rgbentrada.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Limpatudo()
        {
            BTN1.Text = "";
            BTN2.Text = "";
            BTN3.Text = "";
            BTN4.Text = "";
            BTN5.Text = "";
            BTN6.Text = "";
            BTN7.Text = "";
            BTN8.Text = "";
            BTN9.Text = "";
        }
        private void Liberar()
        {
            BTN1.Enabled = true;
            BTN2.Enabled = true;
            BTN3.Enabled = true;
            BTN4.Enabled = true;
            BTN5.Enabled = true;
            BTN6.Enabled = true;
            BTN7.Enabled = true;
            BTN8.Enabled = true;
            BTN9.Enabled = true;
        }
        private void Bloquear()
        {
            BTN1.Enabled = false;
            BTN2.Enabled = false;
            BTN3.Enabled = false;
            BTN4.Enabled = false;
            BTN5.Enabled = false;
            BTN6.Enabled = false;
            BTN7.Enabled = false;
            BTN8.Enabled = false;
            BTN9.Enabled = false;
        }
        private void Verificarjogador()
        {
            if (lbljogada.Text == "1")
            {
                lbldes.Text = txtdesj1.Text;
                lbljogada.Text = "2";
            } else
            {
                lbldes.Text = txtdesj2.Text;
                lbljogada.Text = "1";
            }
        }

        private void BTN1_Click(object sender, EventArgs e)
        {
            Verificarjogador();
            BTN1.Text = lbldes.Text;
            BTN1.Enabled = false;
            Verificavencedor();
        }

        private void BTN2_Click(object sender, EventArgs e)
        {
            Verificarjogador();
            BTN2.Text = lbldes.Text;
            BTN2.Enabled = false;
            Verificavencedor();
        }

        private void BTN3_Click(object sender, EventArgs e)
        {
            Verificarjogador();
            BTN3.Text = lbldes.Text;
            BTN3.Enabled = false;
            Verificavencedor();
        }

        private void BTN4_Click(object sender, EventArgs e)
        {
            Verificarjogador();
            BTN4.Text = lbldes.Text;
            BTN4.Enabled = false;
            Verificavencedor();
        }

        private void BTN5_Click(object sender, EventArgs e)
        {
            Verificarjogador();
            BTN5.Text = lbldes.Text;
            BTN5.Enabled = false;
            Verificavencedor();
        }

        private void BTN6_Click(object sender, EventArgs e)
        {
            Verificarjogador();
            BTN6.Text = lbldes.Text;
            BTN6.Enabled = false;
            Verificavencedor();
        }

        private void BTN7_Click(object sender, EventArgs e)
        {
            Verificarjogador();
            BTN7.Text = lbldes.Text;
            BTN7.Enabled = false;
            Verificavencedor();
        }

        private void BTN8_Click(object sender, EventArgs e)
        {
            Verificarjogador();
            BTN8.Text = lbldes.Text;
            BTN8.Enabled = false;
            Verificavencedor();
        }

        private void BTN9_Click(object sender, EventArgs e)
        {
            Verificarjogador();
            BTN9.Text = lbldes.Text;
            BTN9.Enabled = false;
            Verificavencedor();
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            Novojogo();
        }
        private void Verificavencedor()
        {
            if ((BTN1.Text == BTN2.Text) && (BTN2.Text == BTN3.Text) && (BTN1.Text != ""))
            {
                Pontuar();
                Bloquear();
            } 
            else if ((BTN4.Text == BTN5.Text) && (BTN5.Text == BTN6.Text) && (BTN4.Text != ""))
            {
                Pontuar();
                Bloquear();
            }
            else if ((BTN7.Text == BTN8.Text) && (BTN8.Text == BTN9.Text) && (BTN7.Text != ""))
            {
                Pontuar();
                Bloquear();
            }
            else if ((BTN1.Text == BTN4.Text) && (BTN4.Text == BTN7.Text) && (BTN1.Text != ""))
            {
                Pontuar();
                Bloquear();
            }
            else if ((BTN2.Text == BTN5.Text) && (BTN5.Text == BTN8.Text) && (BTN2.Text != ""))
            {
                Pontuar();
                Bloquear();
            }
            else if ((BTN3.Text == BTN6.Text) && (BTN6.Text == BTN9.Text) && (BTN3.Text != ""))
            {
                Pontuar();
                Bloquear();
            }
            else if ((BTN1.Text == BTN5.Text) && (BTN5.Text == BTN9.Text) && (BTN1.Text != ""))
            {
                Pontuar();
                Bloquear();
            }
            else if ((BTN3.Text == BTN5.Text) && (BTN5.Text == BTN7.Text) && (BTN3.Text != ""))
            {
                Pontuar();
                Bloquear();
            } 
            else if (lblvelha.Text == "9") {
                MessageBox.Show("Velha :(");
                Bloquear();
                Contajogo();
            }
            lblvelha.Text = Convert.ToString(Convert.ToInt32(lblvelha.Text) + 1);
        }
        private void Pontuar()
        {
            if (Convert.ToDecimal(lbljogada.Text) == 1)
            {
                MessageBox.Show("Jogador 2 ganhou!");
                lblpontj2.Text = Convert.ToString(Convert.ToInt16(lblpontj2.Text) + 1);
            }
            else
            {
                MessageBox.Show("Jogador 1 ganhou!");
                lblpontj1.Text = Convert.ToString(Convert.ToInt16(lblpontj1.Text) + 1);
            }
            Contajogo();
        }

        private void lblvelha_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnconfirma_Click(object sender, EventArgs e)
        {
            if ((txtdesj1.Text == "") || (txtdesj2.Text == ""))
            {
                MessageBox.Show("Campos não podem estar vazios.");
            } else
                if (txtdesj1.Text == txtdesj2.Text)
            {
                MessageBox.Show("Desenhos não podem ser iguais.");
            }
                else
            {
                lblj1.Text = txtdesj1.Text;
                lblj2.Text = txtdesj2.Text;
            }
            grbdesenho.Visible = false;
            Novojogo();
        }
        private void Novojogo()
        {
            Limpatudo();
            Liberar();
            lblvelha.Text = "1";
            Verificaprimeiro();
        }
        private void Verificaprimeiro()
        {
            if (Convert.ToDecimal(lblnumjogo.Text) % 2 == 1)
            {
                lbljogada.Text = "1";
            }
            else
            {
                lbljogada.Text = "2";
            }
        }
        private void Contajogo()
        {
            lblnumjogo.Text = Convert.ToString(Convert.ToInt32(lblnumjogo.Text) + 1);
            Verificaprimeiro();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            if ((lbllogin.Text == txtlogin.Text) && (lblsenha.Text == txtsenha.Text)) {
                MessageBox.Show("Você possui acesso para alterar o desenho");
                rgbentrada.Visible = false;
                grbdesenho.Visible = true;
            } else
            {
                MessageBox.Show("Acesso negado");
                rgbentrada.Visible = false;
            }
        }
    }
}
