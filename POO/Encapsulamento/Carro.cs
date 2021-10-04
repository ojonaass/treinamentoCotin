using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class Carro : Veiculo
    {
        public Carro()
        {
            Console.WriteLine("Eu sou um carro!");
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
            MotorPartidaAcionado = true;
            InjetadoCombustivel = true;
            MotorLigado = true;
            Console.WriteLine("O carro está ligado!");
        }
    }
}