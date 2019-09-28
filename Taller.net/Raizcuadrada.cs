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
    

    public partial class Raizcuadrada : Form
    {
        Raiz raiz = new Raiz();
        public Raizcuadrada()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {

            raiz.setNumero1(double.Parse(txtnumero1.Text));
            lbltotal.Text = raiz.calcular().ToString();
            lbltotal.Visible = true;
            txtnumero1.Text = "";
            txtnumero1.Focus();

           

            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
