using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impostos
{
    public class ICMS : IImposto
    {
        public ICMS() : base() { }
        public ICMS(IImposto outroImposto) : base(outroImposto) { }

        public override double Calcula(Orcamento orcamento) => orcamento.Valor * 0.05 + 50 + CalculaOutroImposto(orcamento);
    }
}
