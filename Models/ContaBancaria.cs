using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoCSharp.Enums;

namespace BancoCSharp.Models
{
    
    public abstract class ContaBancaria
    {
        #region Atributos
        public Titular Titular {get; set;}
        public double Saldo {get; private set;}
        public DateTime DataAbertura {get; private set;}
        protected List<Movimentacao> Movimentacoes {get; set;}
        protected readonly double VALOR_MINIMO = 10.0;

        #endregion


    #region Construtores
    
        public ContaBancaria(Titular titular, double saldoAbertura)
        {
            Titular = titular;
            Saldo = saldoAbertura;
            DataAbertura = DateTime.Now;

            Movimentacoes = new List<Movimentacao>()
            {
                new Movimentacao(TipoMovimentacao.ABERTURA_CONTA, saldoAbertura)
            };
        }

        public ContaBancaria(Titular titular)
        {
            Titular = titular;
            Saldo = 0;
            DataAbertura = DateTime.Now;
            Movimentacoes = new List<Movimentacao>()
            {
                new Movimentacao(TipoMovimentacao.ABERTURA_CONTA, Saldo)
            };
        }

        #endregion

    #region Metodos

        public void Depositar(double valor)
    {
        if(valor < VALOR_MINIMO) {
            throw new Exception("O valor mínimo para deposito é R$" + VALOR_MINIMO);
        }

        Saldo += valor;
        Movimentacoes.Add(new Movimentacao(TipoMovimentacao.DEPOSITO______, valor));
        
    }
        public double Sacar(double valor)
    {
        if(valor < VALOR_MINIMO) 
        {
            throw new Exception("O valor mínimo para saque é R$" + VALOR_MINIMO);
        } 
        else if(valor > Saldo)
        {
            throw new Exception("Saldo insuficiente para Saque, Saldo atual é de R$" + Saldo);
        }

        Saldo -= valor;

        Movimentacoes.Add(new Movimentacao(TipoMovimentacao.SAQUE_________, valor));

        return valor;
    }
        public void Transferir(ContaBancaria contaDestino, double valor)

    {
        if(valor < VALOR_MINIMO)
        {
            throw new Exception("O valor mínimo para Transferência é de R$" + VALOR_MINIMO);
        }         
        else if(valor > Saldo)
        {
            throw new Exception("Saldo insuficiente para Transferência, Saldo atual é de R$" + Saldo);
        }

        contaDestino.Depositar(valor);
        Saldo -= valor;

        Movimentacoes.Add(new Movimentacao(TipoMovimentacao.TRANSFERENCIA_, valor));

    }

        public abstract void ImprimirExtrato();




    #endregion

    }
}