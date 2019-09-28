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
    public partial class Promedionotas : Form
    {

        Promedio promedio = new Promedio();
        public Promedionotas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            promedio.setNota1(double.Parse(txtnota1.Text));
            promedio.setNota2(double.Parse(txtnota2.Text));
            promedio.setNota3(double.Parse(txtnota3.Text));
            promedio.setNota4(double.Parse(txtnota4.Text));
           
            lbltotal.Text = promedio.resultado().ToString();
            lbltotal.Visible = true;
            txtnota1.Text = "";
            txtnota2.Text = "";
            txtnota3.Text = "";
            txtnota4.Text = "";
            
            txtnota1.Focus();

            if (promedio.resultado() < 2.99) {

                MessageBox.Show(" Nota Deficiente");
            }
            else {

                if (promedio.resultado() < 3.99)
                {

                    MessageBox.Show("Nota Buena");
                }
                else
                {

                    if (promedio.resultado() >4 && (promedio.resultado() <= 5))
                    {

                        MessageBox.Show("Nota Excelente");
                    }
                    
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
