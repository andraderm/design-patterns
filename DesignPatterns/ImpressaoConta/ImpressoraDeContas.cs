using Investimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ImpressaoConta
{
    public class ImpressoraDeContas
    {
        public void Imprime(Conta conta, Requisicao requisicao)
        {
            IImpressora i1 = new ImpressoraCSV();
            IImpressora i2 = new ImpressoraXML();
            IImpressora i3 = new ImpressoraPorcento();
            IImpressora iFinal = new ImpressoraDefault();

            i1.Proximo = i2;
            i2.Proximo = i3;
            i3.Proximo = iFinal;

            Console.WriteLine(i1.Imprime(conta, requisicao));
        }
    }
}
