using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_26_exercicio1
{
    public class Executar
    {
        static void Main(string[] args)
        {
            GerenteVendas gerenteVendas = new GerenteVendas(12000, 4500, Regioes.Norte);

            Vendedor vendedor1 = new Vendedor(5000, 2500);
            Vendedor vendedor2 = new Vendedor(4500, 2500);
            Vendedor vendedor3 = new Vendedor(5600, 2500);

            System.Console.WriteLine($"Gerente de vendas:\nRegião: {gerenteVendas.getRegiao()}\nSalário: {gerenteVendas.getSalario()}\n");

            System.Console.WriteLine($"Vendedor:\nSalário: {vendedor1.getSalario()}\n");

            Empregados empregados = new Empregados();
            empregados.inserir(vendedor1);
            empregados.inserir(vendedor2);
            empregados.inserir(vendedor3);
            empregados.inserir(gerenteVendas);

            System.Console.WriteLine();

            System.Console.WriteLine($"Folha de pagamentos sem comissão: {empregados.doFolhaPagamento()}");  
        }
    }
}