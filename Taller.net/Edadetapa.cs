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
    public partial class Edadetapa : Form
    {
        Edad edad = new Edad();
        public Edadetapa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            edad.setNumeroedad(int.Parse(txt1.Text));
            txt1.Focus();
            txt1.Text = "";
            if (edad.getNumeroedad() <= 10) {
                MessageBox.Show("Es un niño");
            } else {
             if (edad.getNumeroedad() <=14) {
                    MessageBox.Show("Es un pre-Adolescente");
                }
                else {
                 if(edad.getNumeroedad()<=18) {
                        MessageBox.Show("Es un Adolescente");
                    }
                    else {
                     if (edad.getNumeroedad() <=25) {
                            MessageBox.Show("Es un Joven");
                        }
                        else {
                            if (edad.getNumeroedad() <= 65) {
                                MessageBox.Show("es un Adulto");
                            }
                            else {
                              if (edad.getNumeroedad() > 65)
                                {
                                    MessageBox.Show("Es un Anciano");
                                }
                              
                            }
                        }

                    }

                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
