namespace aula_22_exercicio
{
    public class RedeBibliotecas
    {
        private List<Biblioteca> Bibliotecas;

        public RedeBibliotecas()
        {
            Bibliotecas = new List<Biblioteca>();
        }

        public void AdicionarBiblioteca(Biblioteca biblioteca)
        {
            Bibliotecas.Add(biblioteca);
        }

        public void RemoverBiblioteca(string nome)
        {
            Biblioteca bibliotecaParaRemover = Bibliotecas.Find(l => l.Nome == nome);
            if(bibliotecaParaRemover != null)
            {
                Bibliotecas.Remove(bibliotecaParaRemover);
            }
        }

        public void ListarBibliotecas()
        {   
            foreach(var biblioteca in Bibliotecas)
            {
                System.Console.WriteLine($"Nome: {biblioteca.Nome}");
            }
        }

    }
}