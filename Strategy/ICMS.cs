using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ICMS : Imposto
    {
        public double Calcula(Orcamento orcamento) => orcamento.Valor * 0.05;
    }
}
