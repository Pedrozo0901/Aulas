using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_21_relacoes2
{
    public class Executar
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Herança");
            Porta portaCozinha = new Porta("Branca", 1.5f, 2.5f, 10);
            portaCozinha.Abrir();
            portaCozinha.Fechar();
            System.Console.WriteLine($"Porta Cozinha: Cor: {portaCozinha.cor}, Largura: {portaCozinha.Largura}, Altura: {portaCozinha.Altura}, Peso: {portaCozinha.pesp}");

            System.Console.WriteLine("Agregaão");
            Cozinha cozinha = new Cozinha(true, 20);
            cozinha.Entrar(portaCozinha);

            System.Console.WriteLine("Composição");
            PortaQuarto portaQuarto = new PortaQuarto("Marrom", 1.5f, 9);
            portaQuarto quarto = new portaQuarto(true, 20);
            System.Console.WriteLine($"Quarto: {quarto.PortaQuarto.Cor}");

            System.Console.WriteLine("Associaçã simples");
            stackalloc sala = new Sala();

        }
    }
}