// See https://aka.ms/new-console-template for more information
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

try
{
    conta01.Transferir(conta02, 25.0);
}
catch (System.Exception ex)
{
    Console.WriteLine(ex.Message);
}

System.Console.WriteLine("Saldo Conta01: " + conta01.Saldo);
System.Console.WriteLine("Saldo Conta02: " + conta02.Saldo);

System.Console.WriteLine();