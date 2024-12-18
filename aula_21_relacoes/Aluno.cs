namespace aula_21_relacoes
{
    // Classe aluno, vai ser fundamental para a Escola
    // Então vai ter relação de composição
    public class Aluno
    {
        // propriedades
        public string Nome { get; set;}

        public Aluno(string nome)
        {
            Nome = nome;
        }

        public void MostrarInfo()
        {
            System.Console.WriteLine($"Nome: {Nome}");
        }
    }
}