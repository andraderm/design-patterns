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
        public double Calcula(Orcamento orcamento)
        {
            if (AplicaMaximoImposto(orcamento))
                return MaximoValor(orcamento);

            return MinimoValor(orcamento);
        }

        public abstract double MaximoValor(Orcamento orcamento);
        public abstract double MinimoValor(Orcamento orcamento);
        public abstract bool AplicaMaximoImposto(Orcamento orcamento);
    }
}
