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
    public partial class Indicemasa : Form
    {
        Masacorporal masacorporal = new Masacorporal();
        public Indicemasa()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            masacorporal.setValoraltura(double.Parse(txtaltura.Text));
            masacorporal.setValorpeso(double.Parse(txtpeso.Text));
            lbltotal.Text = masacorporal.resultado().ToString();
            lbltotal.Visible = true;
            txtaltura.Text = "";
            txtpeso.Text = "";
            txtpeso.Focus();

            if (masacorporal.resultado() < 18.5)
            {
                MessageBox.Show("Peso bajo");
            }
            else {
                if (masacorporal.resultado() < 24.9)
                {
                    MessageBox.Show("Peso normal");
                }
                else {
                 if (masacorporal.resultado() < 29.9)
                    {
                        MessageBox.Show("Sobrepeso");
                    }
                    else {
                        if (masacorporal.resultado() < 34.9) {
                            MessageBox.Show("Obesidad tipo 1");
                        }
                        else {
                            if (masacorporal.resultado() < 39.9)
                            {
                                MessageBox.Show("Obesidad tipo 2");
                            }
                            else
                            {
                                if (masacorporal.resultado() >= 40)
                                {
                                    MessageBox.Show("Obesidad tipo 3");
                                }
                               
                            }

                        }
                    }
                 
                }

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
