// See https://aka.ms/new-console-template for more information
using Strategy;

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