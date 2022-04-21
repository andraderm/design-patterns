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
            IImpressora iFinal = new ImpressoraDefault();
            IImpressora i3 = new ImpressoraPorcento(iFinal);
            IImpressora i2 = new ImpressoraXML(i3);
            IImpressora i1 = new ImpressoraCSV(i2);

            Console.WriteLine(i1.Imprime(conta, requisicao));
        }
    }
}
