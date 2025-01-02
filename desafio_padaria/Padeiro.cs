namespace desafio_padaria
{
    public class Padeiro : Funcionario, ICalcular
    {
        public int HorasNoturnas {get; set;}

        public Vendedor(string nome, int codigo, string endereco, string cpf, string telefone, double salarioBase, int horasNoturnas) : base ( nome,  codigo,  endereco,  cpf,  telefone,  salarioBase)
        {
            Nome = nome;
            Codigo = codigo;
            Endereco = endereco;
            CPF = cpf;
            Telefone = telefone;
            SalarioBase = salarioBase;
            HorasNoturnas = horasNoturnas;
        }

        public double CalcularSalario(int horasNoturnas)
        {
            return SalarioBase + ((SalarioBase*0.25)*HorasNoturnas);
        }
    }
}