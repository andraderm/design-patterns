using Investimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DesignPatterns.ImpressaoConta
{
    public class ImpressoraCSV : IImpressora
    {
        public IImpressora Proximo { get; set; }
        public string Imprime(Conta conta, Requisicao requisicao)
        {
            if (requisicao.Formato.Equals(Formato.CSV))
            {
                return $"{conta.Titular},{conta.Valor}";
            }

            return Proximo.Imprime(conta, requisicao);
        }

        public ImpressoraCSV() { }

        public ImpressoraCSV(IImpressora proximo)
        {
            Proximo = proximo;
        }
    }

    public class ImpressoraXML : IImpressora
    {
        public IImpressora Proximo { get; set; }

        public string Imprime(Conta conta, Requisicao requisicao)
        {
            if (requisicao.Formato.Equals(Formato.XML))
            {
                var writer = new StringWriter();
                var serializer = new XmlSerializer(typeof(Conta));
                serializer.Serialize(writer, conta);
                return writer.ToString();
            }

            return Proximo.Imprime(conta, requisicao);
        }

        public ImpressoraXML() { }

        public ImpressoraXML(IImpressora proximo)
        {
            Proximo = proximo;
        }
    }

    public class ImpressoraPorcento : IImpressora
    {
        public IImpressora Proximo { get; set; }

        public string Imprime(Conta conta, Requisicao requisicao)
        {
            if (requisicao.Formato.Equals(Formato.PORCENTO))
            {
                return $"{conta.Titular}%{conta.Valor}";
            }

            return Proximo.Imprime(conta, requisicao);
        }

        public ImpressoraPorcento() { }

        public ImpressoraPorcento(IImpressora proximo)
        {
            Proximo = proximo;
        }
    }

    public class ImpressoraDefault : IImpressora
    {
        public IImpressora Proximo { get; set; }

        public string Imprime(Conta conta, Requisicao requisicao)
        {
            return $"{conta.Titular} - {conta.Valor}";
        }

        public ImpressoraDefault() { }
    }
}
