using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public abstract class Veiculo
    {
        protected bool MotorLigado;
        protected bool MotorPartidaAcionado;
        protected bool InjetadoCombustivel;

        public Veiculo()
        {
            Console.WriteLine("Eu sou um veiculo!");
        }
        public abstract void Ligar();
        public abstract void Acelerar();
        public abstract void Frear();

    }
}
