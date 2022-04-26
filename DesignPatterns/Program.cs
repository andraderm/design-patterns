// See https://aka.ms/new-console-template for more information

using DesignPatterns.Descontos;
using DesignPatterns.Impostos;
using DesignPatterns.ImpressaoConta;
using DesignPatterns.NotasFiscais;
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
IImposto issIcms = new ISS(new ICMS());
IImposto icsm = new ICMS();
IImposto iccc = new ICCC();

Orcamento orcamento = new Orcamento(50);

CalculadorDeImposto calculador = new CalculadorDeImposto();

calculador.RealizaCalculo(orcamento, iss);
calculador.RealizaCalculo(orcamento, issIcms);
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
orcamentoDesconto.AdicionaItem(new DesignPatterns.Impostos.Item("Lapis", 5));
//orcamentoDesconto.AdicionaItem(new DesignPatterns.Impostos.Item("Mouse", 180));
//orcamentoDesconto.AdicionaItem(new DesignPatterns.Impostos.Item("Monitor", 1050));
//orcamentoDesconto.AdicionaItem(new DesignPatterns.Impostos.Item("Sulfite", 30));
//orcamentoDesconto.AdicionaItem(new DesignPatterns.Impostos.Item("Teclado", 300));
// orcamentoDesconto.AdicionaItem(new DesignPatterns.Impostos.Item("Cadeira", 700));

double desconto = calculadorDeDesconto.Calcula(orcamentoDesconto);

Console.WriteLine(desconto);

// Impressao de Conta
ImpressoraDeContas impressoraDeContas = new ImpressoraDeContas();

Conta c1 = new Conta("Teste", 1000);

Requisicao r1 = new Requisicao(Formato.CSV);
Requisicao r2 = new Requisicao(Formato.XML);
Requisicao r3 = new Requisicao(Formato.PORCENTO);

impressoraDeContas.Imprime(c1, r1);
impressoraDeContas.Imprime(c1, r2);
impressoraDeContas.Imprime(c1, r3);

// Template
Console.WriteLine();
Console.WriteLine("Template: ");

Orcamento orc = new Orcamento(1000);
orc.AdicionaItem(new Item("Mesa", 280));

Orcamento orc2 = new Orcamento(300);

Orcamento orc3 = new Orcamento(1000);
orc3.AdicionaItem(new Item("Mesa", 200));
orc3.AdicionaItem(new Item("Mesa", 300));

Orcamento orc4 = new Orcamento(1000);
orc4.AdicionaItem(new Item("Cadeira", 200));
orc4.AdicionaItem(new Item("Mesa", 300));

ICPP icpp = new ICPP();
IKCV ikcv = new IKCV();
IHIT ihit = new IHIT();

Console.WriteLine("Orçamento 1 - R$1000 + 1 item");
Console.WriteLine("ICPP - " + icpp.Calcula(orc));
Console.WriteLine("ICPP - " + icpp.Calcula(orc2));

Console.WriteLine("Orçamento 2 - R$300");
Console.WriteLine("IKCV - " + ikcv.Calcula(orc));
Console.WriteLine("IKCV - " + ikcv.Calcula(orc2));

Console.WriteLine("Orçamento 3 - Itens iguais");
Console.WriteLine("IHIT - " + ihit.Calcula(orc3));

Console.WriteLine("Orçamento 4 - Itens diferentes");
Console.WriteLine("IHIT - " + ihit.Calcula(orc4));

Console.WriteLine();
Console.WriteLine("Desconto Extra: ");
Orcamento reforma = new Orcamento(500.0);

reforma.AplicaDescontoExtra();
Console.WriteLine(reforma.Valor); // imprime 475,00 pois descontou 5%
reforma.Aprova();

reforma.AplicaDescontoExtra();
Console.WriteLine(reforma.Valor); // imprime 465,50 pois descontou 2%

reforma.Finaliza();

// reforma.AplicaDescontoExtra(); lança excecao, pois não pode dar desconto nesse estado
// reforma.Aprova(); lança exceção, pois não pode ir para aprovado

Console.WriteLine();
Console.WriteLine("Nota Fiscal: ");

NotaFiscal nf = new NotaFiscalBuilder()
    .ParaEmpresa("Empresa")
    .ComCnpj("123.456.789/0001-12")
    .ComItem(new ItemDaNota(100.0, "Item 1"))
    .ComItem(new ItemDaNota(200.0, "Item 2"))
    .ComObservacoes("Obs")
    .Constroi();

Console.WriteLine(nf.ValorBruto);
Console.WriteLine(nf.Cnpj);
Console.WriteLine(nf.DataDeEmissao);