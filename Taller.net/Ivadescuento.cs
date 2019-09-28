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
    public partial class Ivadescuento : Form
    {
        Descuento descuento = new Descuento();
        public Ivadescuento()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            descuento.setNumerocompra(double.Parse(txtprecio.Text));
           lbldescuento.Text = descuento.descuento().ToString();
            lbliva.Text = descuento.total().ToString();

            //txtaño.Focus();
           // txtaño.Text = "";
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
