namespace aula_22_exercicio
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Livro livro1 = new Livro("1984", "George Orwer", "1936", 180);
            Livro livro2 = new Livro("A revolução dos bixos", "George Orwer", "1945", 180);
            CatalogoLivro catalogo = new CatalogoLivro();

            catalogo.AdicionarLivro(livro1);
            catalogo.AdicionarLivro(livro2);
            catalogo.ListarLivros();
            catalogo.RemoverLivro("1984");
            catalogo.ListarLivros();

        }

    }

}