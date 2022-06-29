using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoCSharp.Models
{
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(Titular titular) 
        : base(titular)
        {
        }

        public ContaPoupanca(Titular titular, double saldoAbertura) 
        : base(titular, saldoAbertura)
        {
        }
    }
}