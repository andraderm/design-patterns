using Impostos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Impostos
{
    public class IKCV : TemplateImposto
    {
        public override bool AplicaMaximoImposto(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && orcamento.Items.Any(x => x.Valor > 100);
        }

        public override double MaximoValor(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        public override double MinimoValor(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}
