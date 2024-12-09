namespace Aula_18_exercicio
{
    public abstract class Empregado
    {
        public string Nome;
        public string Sobrenome;
        public string CPF;

        public Empregado(string nome, string sobrenome, string cpf)
        {
            
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.CPF = cpf;

        }

        public abstract double Vencimento();
        
    }
}