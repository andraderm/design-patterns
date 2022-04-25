using Impostos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Impostos
{
    public class IHIT : TemplateImposto
    {
        public IHIT() : base() { }
        public IHIT(IImposto outroImposto) : base() { }

        public override bool AplicaMaximoImposto(Orcamento orcamento)
        {
            IList<string> noOrcamento = new List<string>();

            foreach(Item item in orcamento.Items)
            {
                if (noOrcamento.Contains(item.Nome))
                    return true;
                else
                    noOrcamento.Add(item.Nome.ToUpper());
            }

            return false;
        }

        public override double MaximoValor(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100;
        }

        public override double MinimoValor(Orcamento orcamento)
        {
            return orcamento.Valor * 0.01 * orcamento.Items.Count();
        }
    }
}
