namespace aula_6;

class Exercicio
{
    static void Main(string[] args)
    {
        int [] vetor = new int[10];
        for(int i = 0; i < 10; i++)
        {
            vetor[i] = int.Parse(System.Console.ReadLine());
        }
        int maior = vetor[0];
        int menor = vetor[0];
        for(int i = 1; i < 10; i++)
        {
            if(vetor[i] > maior){
                maior = vetor[i];
            } else if(vetor[i] < menor)
            {
                menor = vetor[i];
            }
        }

        System.Console.WriteLine($"Maior: {maior}");
        System.Console.WriteLine($"Menor: {menor}");
    }
}
