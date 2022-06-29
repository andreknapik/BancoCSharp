using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoCSharp.Models
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(Titular titular) 
        : base(titular)
        {
        }

        public ContaCorrente(Titular titular, double saldoAbertura) 
        : base(titular, saldoAbertura)
        {
        }
    }
}