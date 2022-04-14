using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Investimento
{
    public class Conta
    {
        public double Valor { get; private set; }

        public Conta(double valor)
        {
            Valor = valor;
        }

        public void AdicionaSaldo(double valor) => Valor += valor;
    }
}
