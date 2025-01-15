using System;
using System.Globalization;
using System.IO;

class Executar
{
    static void Main(string[] args)
    {
        string caminhoEntrada = @"C:\Users\feliperibeiro\Documents\Aulas\Aulas\aula_32_exercicio\dadosclientes.csv";
        string caminhoSaida = @"C:\Users\feliperibeiro\Documents\Aulas\Aulas\aula_32_exercicio\out\resultado.csv";  

        try
        {
            Directory.CreateDirectory(Path.GetDirectoryName(caminhoSaida));

            var linhas = File.ReadAllLines(caminhoEntrada);

            using (var writer = new StreamWriter(caminhoSaida))
            {
                for (int i = 1; i < linhas.Length; i++)
                {
                    var campos = linhas[i].Split(',');

                    string item = campos[0]; 
                    int quantidade = int.Parse(campos[1]); 
                    decimal valorUnitario = decimal.Parse(campos[2], CultureInfo.InvariantCulture);

                    decimal valorTotal = quantidade * valorUnitario;

                    writer.WriteLine($"{item},{valorTotal.ToString("F2", CultureInfo.InvariantCulture)}");
                }
            }

            Console.WriteLine($"Arquivo '{caminhoSaida}' criado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao processar o arquivo: {ex.Message}");
        }
    }
}
rh@dhtbr.com.br