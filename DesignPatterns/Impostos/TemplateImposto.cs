using Impostos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Impostos
{
    public abstract class TemplateImposto : IImposto
    {
        public TemplateImposto() : base() { }
        public TemplateImposto(IImposto outroImposto) : base(outroImposto) { }

        public override double Calcula(Orcamento orcamento)
        {
            if (AplicaMaximoImposto(orcamento))
                return MaximoValor(orcamento) + CalculaOutroImposto(orcamento);

            return MinimoValor(orcamento) + CalculaOutroImposto(orcamento);
        }

        public abstract double MaximoValor(Orcamento orcamento);
        public abstract double MinimoValor(Orcamento orcamento);
        public abstract bool AplicaMaximoImposto(Orcamento orcamento);
    }
}
