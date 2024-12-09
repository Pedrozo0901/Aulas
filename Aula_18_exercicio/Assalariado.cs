namespace Aula_18_exercicio
{
    public class Assalariado : Empregado
    {
        public double Salario;

        public Assalariado(string nome, string sobrenome, string cpf, double salario) : base(nome, sobrenome, cpf)
        {

            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.CPF = cpf;
            this.Salario = salario;

        }

        public override double Vencimento()
        {
            return Salario;
        }

        public void ImprimirDados()
        {
            System.Console.WriteLine("Nome: " + Nome);
            System.Console.WriteLine("Sobrenome: " + Sobrenome);
            System.Console.WriteLine("CPf: " + CPF);
            System.Console.WriteLine("Salario: " + Salario);
        }
    }
}