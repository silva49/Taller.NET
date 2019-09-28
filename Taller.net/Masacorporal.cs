using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller.net
{
   public class Masacorporal
    {
        private double valoraltura;
        private double valorpeso;

        public void setValoraltura(double altura)
        {

            this.valoraltura = altura;
        }


        public double getValoraltura()
        {
            return this.valoraltura;
        }

        public void setValorpeso(double peso)
        {

            this.valorpeso = peso;
        }


        public double getValorpeso()
        {
            return this.valorpeso;
        }


        public double resultado()
        {
            return (this.getValorpeso() / (this.getValoraltura() * this.getValoraltura()));
            
        }
    }
}
