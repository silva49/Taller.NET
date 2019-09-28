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
    public partial class Costollamadas : Form
    {

        Llamadas llamada = new Llamadas();

        public Costollamadas()
        {
            InitializeComponent();
        }



        private void Costollamadas_Load(object sender, EventArgs e)
        {
            cmbDestino.Items.Add("Estados Unidos");
            cmbDestino.Items.Add("Canadá");
            cmbDestino.Items.Add("Europa");
            cmbDestino.Items.Add("Resto del mundo");
        }

        private void btnCosto_Click(object sender, EventArgs e)
        {
            llamada.setdestino(cmbDestino.Text);
            llamada.setduracion(double.Parse(txtduracion.Text));
            lblTotal.Text = llamada.totalapagar().ToString();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
