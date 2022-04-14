using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Investimento
{
    public class Arrojado : Investimento
    {
        public double Investe(Conta conta)
        {
            int chance = new Random().Next(101);

            if (chance > 50)
            {
                return chance > 80 ? conta.Valor * 0.05 : conta.Valor * 0.03;
            }

            return conta.Valor * 0.006;
        }
    }
}
