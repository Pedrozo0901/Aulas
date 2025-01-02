namespace desafio_padaria
{
    public abstract class Funcionario
    {
        public string Nome { get; set;}
        public int Codigo { get; set; }
        public string Endereco { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public double SalarioBase { get; set;}

        public Funcionario(string nome, string endereco, string cpf, string telefone, double salarioBase)
        {
            Nome = nome;
            Codigo = codigo;
            Endereco = endereco;
            CPF = cpf;
            Telefone = telefone;
            SalarioBase = salarioBase;
        }
    }
}