using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impostos
{
    public class ISS : IImposto
    {
        public ISS() : base() { }
        public ISS(IImposto outroImposto) : base(outroImposto) { }
        
        public override double Calcula(Orcamento orcamento) => orcamento.Valor * 0.06 + CalculaOutroImposto(orcamento);
    }
}
