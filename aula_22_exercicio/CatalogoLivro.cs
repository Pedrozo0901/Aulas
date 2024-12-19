namespace aula_22_exercicio
{
    public class CatalogoLivro
    {
        private List<Livro> livros;

        public CatalogoLivro()
        {
            livros = new List<Livro>();
        }

        public void AdicionarLivro(Livro livro)
        {
            livros.Add(livro);
        }

        public void RemoverLivro(string titulo)
        {
            Livro livroParaRemover = livros.Find(l => l.Titulo == titulo);
            if(livroParaRemover != null)
            {
                livros.Remove(livroParaRemover);
            }
        }

        public void ListarLivros()
        {   
            foreach(var livro in livros)
            {
                System.Console.WriteLine($"Título{livro.Titulo}, Autor: {livro.Autor}, Ano da publicação:{livro.AnoPublicacao} Quantidade: {livro.QuantidadeExemplares}");
            }
        }

    }
}