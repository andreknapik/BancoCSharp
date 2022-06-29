using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoCSharp.Models
{
    public class ContaInvestimento : ContaBancaria
    {
        
        public double ValorInvestido { get; private set;}
        
        public ContaInvestimento(Titular titular) 
        : base(titular)
        {
        }

        public ContaInvestimento(Titular titular, double saldoAbertura) 
        : base(titular, saldoAbertura)
        {
        }

        public override void ImprimirExtrato()
        {
            System.Console.WriteLine("Imprimindo Extrato Conta Investimento");
        }
    }
}