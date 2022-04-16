// See https://aka.ms/new-console-template for more information

using DesignPatterns.Descontos;
using Impostos;
using Investimento;

// Strategy

Console.WriteLine("Investimento: ");
Conta conta = new Conta(1000);
Conta conta2 = new Conta(1000);
Conta conta3 = new Conta(1000);
RealizadorDeInvestimento realizadorDeInvestimento = new RealizadorDeInvestimento();

IInvestimento conservador = new Conservador();
IInvestimento moderado = new Moderado();
IInvestimento arrojado = new Arrojado();

realizadorDeInvestimento.RealizaInvestimento(conta, conservador);
realizadorDeInvestimento.RealizaInvestimento(conta2, moderado);
realizadorDeInvestimento.RealizaInvestimento(conta3, arrojado);

Console.WriteLine();
Console.WriteLine("Impostos: ");
IImposto iss = new ISS();
IImposto icsm = new ICMS();
IImposto iccc = new ICCC();

Orcamento orcamento = new Orcamento(50);

CalculadorDeImposto calculador = new CalculadorDeImposto();

calculador.RealizaCalculo(orcamento, iss);
calculador.RealizaCalculo(orcamento, icsm);
calculador.RealizaCalculo(orcamento, iccc);

Orcamento orcamento2 = new Orcamento(1450);
Orcamento orcamento3 = new Orcamento(5000);

calculador.RealizaCalculo(orcamento2, iccc);
calculador.RealizaCalculo(orcamento3, iccc);

// Chain of Responsibility
Console.WriteLine();
Console.WriteLine("Descontos: ");

CalculadorDeDescontos calculadorDeDesconto = new CalculadorDeDescontos();

Orcamento orcamentoDesconto = new Orcamento(500);
orcamentoDesconto.AdicionaItem(new DesignPatterns.Impostos.Item("Caneta", 10));
orcamentoDesconto.AdicionaItem(new DesignPatterns.Impostos.Item("Mouse", 180));
orcamentoDesconto.AdicionaItem(new DesignPatterns.Impostos.Item("Monitor", 1050));
orcamentoDesconto.AdicionaItem(new DesignPatterns.Impostos.Item("Sulfite", 30));
orcamentoDesconto.AdicionaItem(new DesignPatterns.Impostos.Item("Teclado", 300));
// orcamentoDesconto.AdicionaItem(new DesignPatterns.Impostos.Item("Cadeira", 700));

double desconto = calculadorDeDesconto.Calcula(orcamentoDesconto);

Console.WriteLine(desconto);