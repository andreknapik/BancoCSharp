// See https://aka.ms/new-console-template for more information
using BancoCSharp.Enums;
using BancoCSharp.Models;

Console.WriteLine("************************************************");
Console.WriteLine("***************** Banco CSharp *****************");
Console.WriteLine("************************************************");
Console.WriteLine();

var endereco = new Endereco
{
    Cep = "88034-000",
    Rua = "Rua XV",
    Numero = 53
};

var titular01 =  new Titular("José da Silva","12345678901", "(21)99993-0239", endereco);
var titular02 =  new Titular("Maria da Silva","12345678911", "(21)99993-0299", endereco);

var conta01 = new ContaCorrente(titular01, 100.00);
var conta02 = new ContaInvestimento(titular02);
var conta03 = new ContaPoupanca(titular02);

conta01.Depositar(50.0);

conta02.Depositar(500.0);
conta02.Sacar(100.0);
conta02.Transferir(conta03, 100.00);

conta03.Sacar(25.0);

conta01.ImprimirExtrato();
conta02.ImprimirExtrato();
conta03.ImprimirExtrato();
