using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Investimento
{
    public interface Investimento
    {
        double Investe(Conta conta);
    }
}
