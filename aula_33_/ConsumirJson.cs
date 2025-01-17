using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_33_
{
    public class ConsumirJson
    {
        static async Task Main(string[] args)
        {
            // Url do arquivo json conteudo informações sobre animes
            string url = "https://raw.githubusercontent.com/manami-project/anime-offline-database/master/anime-offline-database-minified.json";

            //  Nome do arquivo TCT de saída
            string nomeArquivo = "animes.txt";

            try{
                // HttpClient é uma classe que permite fazer requisições  HTTP
                using(HttpClient cliente = new HttpClient())
                {
                    // Faz a requisição get para obter o Json
                    var response = await cliente.GetAsync(url);

                    // Lê o onteúdo da resposta
                    var responseString = await response.Content.ReadAsStringAsync();

                    // Deixar o json em estrutura dinâmica que é JArray
                    using(JsonDocument document = JsonDocument.Parse(responseString))
                    {
                        var animeList = document.RootElement.GetProperty("data");

                        // Função que grava todas as informações do Json e salva em um arquivo
                        SalvarEmTxt(animeList, nomeArquivo);
                    }

                    System.Console.WriteLine("Informações salvas com sucessos! ");
                }
            }
        }

        static void SalvarEmTxt(JsonElement animeList, string nomeArquivo)
        {
            try{
                using(StremWriter writer = new StremWriter(nomeArquivo))
                {
                    foreach (var anime in animeList.EnumerateArray())
                    {
                        string title = anime.GetProperty("title").GetString() ?? "Sem título";
                        string type = anime.GetProperty("type").GetString() ?? "Sem tipo";
                        string episodes = anime.GetProperty("episodes").GetString() ?? "Sem episodios";
                        string status = anime.GetProperty("status").GetString() ?? "Sem status";

                        // escreve a temporada do anime
                        string season = "N/A";
                        int year = 2023;

                        // if(anime.TryGetProperty("animoeSeason", out JsonElement seasonElement))  //out é a forma de acessar as propriedades de animeSeason
                        // {
                        //     season = animeSeason.TryGetProperty("season").GetString() ?? "N/A";
                        // }
                        writer.WriteLine($"Titulo: {title}");
                        writer.WriteLine($"Tipo: {type}");
                        writer.WriteLine($"")
                    }

                    
                }
            }
            catch
            {

            }
        }
    }
}