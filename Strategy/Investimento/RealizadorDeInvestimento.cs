﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Investimento
{
    public class RealizadorDeInvestimento
    {
        public void RealizaInvestimento(Conta conta, Investimento perfilDeInvestimento)
        {
            Console.WriteLine("Valor inicial: " + conta.Valor);

            double retorno = perfilDeInvestimento.Investe(conta) * 0.75;

            conta.AdicionaSaldo(retorno);

            Console.WriteLine("Valor final: " + conta.Valor);
        }
    }
}
