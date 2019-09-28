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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmasa_Click(object sender, EventArgs e)
        {
            Indicemasa indicemasa = new Indicemasa();
            indicemasa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Promedionotas promedionotas = new Promedionotas();
            promedionotas.Show();
            this.Hide();
        }

        private void btnraiz_Click(object sender, EventArgs e)
        {
            Raizcuadrada raizcuadrada = new Raizcuadrada();
            raizcuadrada.Show();
            this.Hide();
        }

        private void btnvolumen_Click(object sender, EventArgs e)
        {
            Volumencaja volumencaja = new Volumencaja();
            volumencaja.Show();
            this.Hide();
        }

        private void btnetapas_Click(object sender, EventArgs e)
        {
            Edadetapa edadetapa = new Edadetapa();
            edadetapa.Show();
            this.Hide();
        }

        private void btnsegundos_Click(object sender, EventArgs e)
        {
            Segundosvida segundosvida = new Segundosvida();
            segundosvida.Show();
            this.Hide();
        }

        private void btndescuento_Click(object sender, EventArgs e)
        {
            Ivadescuento ivadescuento = new Ivadescuento();
            ivadescuento.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Costollamadas costollamadas = new Costollamadas();
            costollamadas.Show();
            this.Hide();
        }

       
        private void btnsalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
