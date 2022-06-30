using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoCSharp.Enums;

namespace BancoCSharp.Models
{
    public class Movimentacao
    {
        private TipoMovimentacao ABERTURA_CONTA;
        private double saldoAbertura;

        private DateTime DataHoraMovimentacao {get; set;}
        private TipoMovimentacao TipoMovimentacao {get;set;}
        private double Valor {get;set;}

    public Movimentacao(TipoMovimentacao tipoMovimentacao, double valor)
    {
        TipoMovimentacao = tipoMovimentacao;
        DataHoraMovimentacao = DateTime.Now;
        Valor = valor;
    }

        public override string ToString()
        {
            var valor = (this.TipoMovimentacao == TipoMovimentacao.SAQUE_________ ||
                         this.TipoMovimentacao == TipoMovimentacao.TRANSFERENCIA_) 
            ? "-R$ " + Valor
            : " R$ " + Valor;
            
            return $"{DataHoraMovimentacao}hs | {TipoMovimentacao} | {valor}";
        }

        // 02/04/2022 as 19:30hs - SAQUE - R$10,00
    }
}