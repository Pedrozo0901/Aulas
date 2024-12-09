namespace Aula_18_exercicio
{
    public class Horista : Empregado
    {
        public double PrecoHora;
        public double HorasTrabalhadas;

        public Horista(string nome, string sobrenome, string cpf, double precohora, double horastrabalhadas) : base(nome, sobrenome, cpf)
        {

            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.CPF = cpf;
            this.PrecoHora = precohora;
            this.HorasTrabalhadas = horastrabalhadas;

        }

        public override double Vencimento()
        {
            return PrecoHora * HorasTrabalhadas;
        }

        public void ImprimirDados()
        {
            System.Console.WriteLine("Nome: " + Nome);
            System.Console.WriteLine("Sobrenome: " + Sobrenome);
            System.Console.WriteLine("CPf: " + CPF);
            System.Console.WriteLine("Preço da hora: " + PrecoHora);
            System.Console.WriteLine("Horas trabalhadas: " + HorasTrabalhadas);
        }
    }
}