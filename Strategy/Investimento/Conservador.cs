using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Investimento
{
    public class Conservador : Investimento
    {
        public double Investe(Conta conta)
        {
            return conta.Valor * 0.008;
        }
    }
}
