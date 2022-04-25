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
        public string Nome { get; set; }
        public string Numero { get; set; }
        public string Agencia { get; set; }
        public decimal Saldo { get; set; }

        public Conta() {}

        public Conta(double valor)
        {
            Valor = valor;
            Saldo = (decimal)valor;
            Titular = "";
            Nome = "";
            Numero = "";
            Agencia = "";
        }

        public Conta(string titular, double valor)
        {
            Titular = titular;
            Valor = valor;
            Nome = "";
            Saldo = (decimal)valor;
            Numero = "";
            Agencia = "";
        }

        public Conta(string titular, double valor, string nome, string numero, string agencia)
        {
            Titular = titular;
            Valor = valor;
            Nome = nome;
            Saldo = (decimal)valor;
            Numero = numero;
            Agencia = agencia;
        }

        public void AdicionaSaldo(double valor) => Valor += valor;
    }
}
