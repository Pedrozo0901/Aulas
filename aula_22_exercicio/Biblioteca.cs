namespace aula_22_exercicio
{
    public class Biblioteca
    {
        public string Nome {get; set;}
        public CatalogoLivro catalogo;

        private List<Funcionario> funcionarios = new List<Funcionario>();
    
        public Biblioteca(string nome)
        {
            Nome = nome;
            catalogo = new CatalogoLivro(); // Composição
        }

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            funcionarios.Add(funcionario);
        }

        public void RemoverFuncionario(Funcionario funcionario)
        {
            funcionarios.Remove(funcionario);
        }

        public void ConsultarLivros()
        {
            catalogo.ListarLivros();
        }

    }
}