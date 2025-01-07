using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_26_exercicio1
{
    public class Empregados
    {
        private int iNumeroMaximo = 50;
        public Empregado[] empregados { get; set; }
        public int iNumeroEmpregados { get { return empregados.Length; } }

        public Empregados()
        {
            empregados = new Empregado[iNumeroMaximo];
        }

        public void inserir(Empregado novoEmpregado)
        {
            for (int i = 0; i < iNumeroMaximo; i++)
            {

                if (empregados[i] == null)
                {
                    empregados[i] = novoEmpregado;
                    System.Console.WriteLine($"Empregado inserido com sucesso!");
                    break; 
                }
            }
        }

        public void imprime()
        {
            for(int i = 0; i < empregados.Length; i++)
            {
                System.Console.WriteLine($"Empregado: {empregados[i]}");
            }
        }

        public double doFolhaPagamento()
        {
            double totalPagamento = 0;

            for (int i = 0; i < empregados.Length; i++)
            {
                if (empregados[i] != null)
                {
                    totalPagamento += empregados[i].getSalario();
                }
            }

            return totalPagamento;
        }
    }
}