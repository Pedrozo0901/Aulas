using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace Aula31_ManipulacaoArquivo.Banco
{
    public class ATMTransaction
    {
        public string Tipo { get; private set; }
        public double Valor { get; private set; }

        public ATMTransaction(string tipo, double valor)
        {
            Tipo = tipo;
            Valor = valor;
        }
    }
}