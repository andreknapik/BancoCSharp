using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoCSharp.Enums;

namespace BancoCSharp.Models
{
    public class Movimentacao
    {
        private DateTime DataHoraMovimentacao {get; set;}
        private TipoMovimentacao TipoMovimentacao {get;set;}
        private double Valor {get;set;}

    public Movimentacao(TipoMovimentacao tipoMovimentacao, int valor)
    {
        TipoMovimentacao = tipoMovimentacao;
        DataHoraMovimentacao = DateTime.Now;
        Valor = valor;
    }

        public override string ToString()
        {
            var valor = (this.TipoMovimentacao == TipoMovimentacao.SAQUE ||
                        this.TipoMovimentacao == TipoMovimentacao.TRANSFERENCIA) 
            ? "-R$ " + Valor
            : " R$ " + Valor;
            
            return $"{DataHoraMovimentacao}hs | {TipoMovimentacao} | {valor}";
        }

        // 02/04/2022 as 19:30hs - SAQUE - R$10,00
    }
}