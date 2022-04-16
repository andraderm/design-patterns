using DesignPatterns.Desconto;
using Impostos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Descontos
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            IDesconto d1 = new DescontoPorCincoItens();
            IDesconto d2 = new DescontoPorMaisDeQuinhentosReais();
            IDesconto dFinal = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = dFinal;

            return d1.Desconta(orcamento);
        }
    }
}
