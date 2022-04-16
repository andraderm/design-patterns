using DesignPatterns.Desconto;
using Impostos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Descontos
{
    public class DescontoPorCincoItens : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Items.Count > 5)
            {
                return orcamento.Items.Sum(x => x.Valor) * 0.1;
            }

            return Proximo.Desconta(orcamento);
        }
    }

    public class DescontoPorMaisDeQuinhentosReais : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Items.Sum(x => x.Valor) > 500)
            {
                return orcamento.Items.Sum(x => x.Valor) * 0.07;
            }

            return Proximo.Desconta(orcamento);
        }
    }

    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            bool recebeDesconto = orcamento.Items.Any(x => "CANETA".Equals(x.Nome.ToUpper())) && orcamento.Items.Any(x => "LAPIS".Equals(x.Nome.ToUpper()));
            if (recebeDesconto)
            {
                return orcamento.Items.Sum(x => x.Valor) * 0.05;
            }

            return Proximo.Desconta(orcamento);
        }
    }

    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            return 0;
        }
    }
}
