using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller.net
{
    public partial class Segundosvida : Form
    {
        Edadaño edadaño = new Edadaño();

        public Segundosvida()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            edadaño.setNumeronac(int.Parse(txtaño.Text));
            lbledad.Text = edadaño.calcular().ToString();
            lblsegundos.Text = edadaño.segundos().ToString();

            txtaño.Focus();
            txtaño.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
