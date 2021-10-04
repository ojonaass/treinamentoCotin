using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    class Retangulo
    {
        private double comprimento;
        private double largura;

        public double Comprimento
        {
            get { return comprimento; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("O valor do comprimento não pode ser menor que zero!");
                }
                else
                {
                    comprimento = value;
                }
            }
        }

        public double Largura
        {
            get { return largura; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("O valor da largura não pode ser menor que zero!");
                }
                else
                {
                    largura = value;
                }
            }
        }

        public double GetArea()
        {
            return Comprimento * Largura;
        }
    }
}
