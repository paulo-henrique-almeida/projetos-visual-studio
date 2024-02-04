using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetinho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            lblimccalc.Text = Convert.ToString(Convert.ToDecimal(txtmassa.Text) / (Convert.ToDecimal(txtaltura.Text) * Convert.ToDecimal(txtaltura.Text)));
            lblimc.Visible = true;
            lblimccalc.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblimccalc_Click(object sender, EventArgs e)
        {

        }

        private void txtmassa_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtaltura_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtaltura.Text) < 1)
            {
                txtaltura.Text = "0.1";
            }
        }
    }
}
