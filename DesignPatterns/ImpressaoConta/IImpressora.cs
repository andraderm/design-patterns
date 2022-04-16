using Investimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ImpressaoConta
{
    public interface IImpressora
    {
        string Imprime(Conta conta, Requisicao requisicao);
        IImpressora Proximo { get; set; }
    }
}
