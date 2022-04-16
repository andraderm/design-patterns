using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investimento
{
    public interface IInvestimento
    {
        double Investe(Conta conta);
    }
}
