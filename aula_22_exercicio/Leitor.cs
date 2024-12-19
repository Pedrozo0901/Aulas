namespace aula_22_exercicio
{
    public class Leitor : Usuario
    {
        public Leitor(string nome, string cpf) : base(nome, cpf)
        {
            Nome = nome;
            CPF = cpf;
        }
    }
}