using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class gire_a_moeda : Form
    {
        public gire_a_moeda()
        {
            InitializeComponent();
        }

        Random random = new Random();
        int xvencidas = 0;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            como_jogar m = new como_jogar();
            m.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnjogar_Click(object sender, EventArgs e)
        {
            int caracoroa = random.Next(1, 4);

            if (caracoroa == 3 && xvencidas < 3)
            {
                lblresultado.Text = "Você VENCEU!!!";
                xvencidas++;
                int ganho = random.Next(50, 201);
                lbldinheiro.Visible = true;
                lbldolar.Visible = true;
                lbldinheiro.Text = Convert.ToString(Convert.ToInt32(lbldinheiro.Text) + ganho);

            } else
            {
                lblresultado.Text = "Você perdeu.";
                xvencidas = 0;
            }

            lblresultado.Visible = true;
        }
    }
}
