namespace aula_6;

public class Exemplo
{
    static void Teste()
    {
        int[] vetor = new int[10];
        for(int i = 0; i < 10; i++)
        {
            // System.Console.WriteLine("Digite um número");
            // vetor[i] = int.Parse(System.Console.ReadLine());
            vetor[i] = Random.Shared.Next(1,100);
        }
        // oremde direa
        System.Console.WriteLine("Ordem direta");
        for(int i = 0; i < 10; i++)
        {
            Console.Write($"{vetor[i]},");
        }

        System.Console.WriteLine("");

        // ordem inversa
        System.Console.WriteLine("Ordem inversa");
        for(int i = 0; i >= 0; i++)
        {
            System.Console.WriteLine($"{vetor[i]}");
        }
    }
}