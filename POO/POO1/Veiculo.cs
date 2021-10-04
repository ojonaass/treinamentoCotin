using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    public class Veiculo
    {
        private string tipo;
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public Veiculo(string tipoVeiculo)
        {
            this.tipo = tipoVeiculo;
        }
        public virtual void Mover() { }
        public virtual void Parar() { }
    }
}
