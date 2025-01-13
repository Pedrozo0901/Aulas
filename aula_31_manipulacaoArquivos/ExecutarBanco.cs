using System;
using System.Collections.Generic;
using Aula31_ManipulacaoArquivo.Banco;
using ClosedXML.Excel;

namespace Aula_31_ManipulacaoArquivo
{
    public class ExecutarBanco
    {
        static void Main(string[] args)
        {
            // Instanciando cliente e contas
            var cliente = new Customer("João de Deus");
            var contaCorrente = new CurrentAccount(1234, cliente, 500);
            var contaPoupanca = new SavingAccount(5421, cliente, 0.01);

            // Operações nas contas
            contaCorrente.Depositar(100);
            contaCorrente.Sacar(200);

            contaPoupanca.Depositar(500);
            contaPoupanca.AplicarRendimento();

            // Geração de Excel
            GerarExcel(new List<Account> { contaCorrente, contaPoupanca });
        }

        public static void GerarExcel(List<Account> contas)
        {
            // Criando uma nova planilha de Excel
            using (var workbook = new XLWorkbook())
            {
                // Adiciona uma aba chamada "Contas Bancárias"
                var worksheet = workbook.Worksheets.Add("Contas Bancarias");

                // Cabeçalho
                worksheet.Cell(1, 1).Value = "Número da Conta";
                worksheet.Cell(1, 2).Value = "Nome do Cliente";
                worksheet.Cell(1, 3).Value = "Tipo da Conta";
                worksheet.Cell(1, 4).Value = "Saldo";

                // Preenchendo os dados das contas
                int row = 2; // Começa na linha 2
                foreach (var item in contas)
                {
                    worksheet.Cell(row, 1).Value = item.NumeroConta;
                    worksheet.Cell(row, 2).Value = item.Cliente.Nome;
                    worksheet.Cell(row, 3).Value = item.GetType().Name; // Obtém o tipo da conta
                    worksheet.Cell(row, 4).Value = item.Saldo;
                    row++;
                }

                // Salvando o arquivo Excel
                workbook.SaveAs("ContasBancarias.xlsx");
                Console.WriteLine("Arquivo Excel gerado com sucesso!");
            }
        }
    }
}
