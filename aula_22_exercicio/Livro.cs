namespace aula_22_exercicio
{
    public class Livro
    {
        public string Titulo {get; set;}
        public string Autor {get; set;}
        public string AnoPublicacao {get; set;}
        public int QuantidadeExemplares {get; set;}

        public Livro(string titulo, string autor, string anopublicacao, int quantidadeExemplares)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anopublicacao;
            QuantidadeExemplares = quantidadeExemplares;
        }
    }
}