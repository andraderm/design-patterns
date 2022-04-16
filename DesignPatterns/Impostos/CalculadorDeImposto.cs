using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impostos
{
    public class CalculadorDeImposto
    {
        public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            double resultado = imposto.Calcula(orcamento);
            Console.WriteLine(resultado);
        }
    }
}
