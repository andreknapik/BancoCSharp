using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoCSharp.Models
{
    public class ContaBancaria
    {
        public Titular Titular {get; set;}
        public double Saldo {get; private set;}
        public DateTime DataAbertura {get; private set;}



        public ContaBancaria(Titular titular, double saldoAbertura)
        {
            Titular = titular;
            Saldo = saldoAbertura;
            DataAbertura = DateTime.Now;
        }
    }
}