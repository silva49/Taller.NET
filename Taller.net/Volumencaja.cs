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
    public partial class Volumencaja : Form
    {
        Volumen volumen = new Volumen();
        public Volumencaja()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            volumen.setNumeroalto(double.Parse(txtaltura.Text));
            volumen.setNumeroancho(double.Parse(txtancho.Text));
            volumen.setNumerolargo(double.Parse(txtlargo.Text));
            lbltotal.Text = volumen.calcular().ToString();
            lbltotal.Visible = true;
            txtaltura.Focus();
            txtaltura.Text = "";
            txtancho.Text = "";
            txtlargo.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
