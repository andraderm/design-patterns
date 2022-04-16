using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investimento
{
    public class Conta
    {
        public string? Titular { get; set; }
        public double Valor { get; set; }

        public Conta() {}
        public Conta(double valor)
        {
            Valor = valor;
        }

        public Conta(string titular, double valor)
        {
            Titular = titular;
            Valor = valor;
        }

        public void AdicionaSaldo(double valor) => Valor += valor;
    }
}
