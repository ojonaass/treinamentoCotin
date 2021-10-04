using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static POO.Veiculo;

namespace POO
{
    public class Aviao : Veiculo
    {
        public Aviao()
        {
            Console.WriteLine("Eu sou um avião! ");
        }

        public override void Acelerar()
        {
            throw new NotImplementedException();
        }

        public override void Frear()
        {
            throw new NotImplementedException();
        }

        public override void Ligar()
        {
            InjetadoCombustivel = true;
            MotorLigado = true;
            Console.WriteLine("O Avião está ligado!");
        }
    }
}
