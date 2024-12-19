namespace aula_22_exercicio
{
    public class Funcionario : Usuario
    {
        public string Cargo { get; set;}

        public Funcionario(string nome, string cpf, string cargo) : base(nome, cpf)
        {
            Nome = nome;
            CPF = cpf;
            Cargo = cargo;
        }

        public void RealizarEmprestimo()
        {
            System.Console.WriteLine($"O funcionario {Nome} realizou um emprestimo");
        }
    }
}