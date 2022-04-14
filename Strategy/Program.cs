﻿// See https://aka.ms/new-console-template for more information
using Strategy;
using Strategy.Investimento;

Conta conta = new Conta(1000);
Conta conta2 = new Conta(1000);
Conta conta3 = new Conta(1000);
RealizadorDeInvestimento realizadorDeInvestimento = new RealizadorDeInvestimento();

Investimento conservador = new Conservador();
Investimento moderado = new Moderado();
Investimento arrojado = new Arrojado();

realizadorDeInvestimento.RealizaInvestimento(conta, conservador);
realizadorDeInvestimento.RealizaInvestimento(conta2, moderado);
realizadorDeInvestimento.RealizaInvestimento(conta3, arrojado);

/*
Imposto iss = new ISS();
Imposto icsm = new ICMS();
Imposto iccc = new ICCC();

Orcamento orcamento = new Orcamento(50);

CalculadorDeImposto calculador = new CalculadorDeImposto();

calculador.RealizaCalculo(orcamento, iss);
calculador.RealizaCalculo(orcamento, icsm);
calculador.RealizaCalculo(orcamento, iccc);

Orcamento orcamento2 = new Orcamento(1450);
Orcamento orcamento3 = new Orcamento(5000);

calculador.RealizaCalculo(orcamento2, iccc);
calculador.RealizaCalculo(orcamento3, iccc);
*/