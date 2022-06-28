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

var conta01 = new ContaBancaria(titular01, 100.00);

System.Console.WriteLine(conta01.Saldo);