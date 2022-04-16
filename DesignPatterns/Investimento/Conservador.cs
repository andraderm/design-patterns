using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investimento
{
    public class Conservador : IInvestimento
    {
        public double Investe(Conta conta)
        {
            return conta.Valor * 0.008;
        }
    }
}
