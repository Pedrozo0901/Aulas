using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_23_exercicio3
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Moto moto1 = new Moto(250);
            System.Console.WriteLine($"A diaria da moto de {moto1.Cilindrada} cilindradas, custa: {moto1.CalcularAluguel()}");

            Moto moto2 = new Moto();
            System.Console.WriteLine($"A diaria da moto de {moto2.Cilindrada} cilindradas, custa: {moto2.CalcularAluguel()}");

            Caminhao caminhao1 = new Caminhao(2);
            System.Console.WriteLine($"A diaria do caminhão de {caminhao1.Eixos} eixos, custa: {caminhao1.CalcularAluguel()}");

            Carro carro1 = new Carro();
            System.Console.WriteLine($"A diaria do carro custa: {carro1.CalcularAluguel()}");

            Utilitario utilitario1 = new Utilitario();
            System.Console.WriteLine($"A diaria do utilitario custa: {utilitario1.CalcularAluguel()}");
        }
    }
}