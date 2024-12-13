namespace aula_19_exercicio
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta(1, "Leandro Guedes");
            conta1.Nome = "Leandra Guedes";
            
            System.Console.WriteLine("Nome: " + conta1.Nome + " Numero da conta: " +  conta1.NumeroDaConta);
            System.Console.WriteLine("Saldo: " + conta1.GetSaldo());
            conta1.Deposito(300);
            System.Console.WriteLine("Saldo: " + conta1.GetSaldo());
            conta1.Saque(100);
            System.Console.WriteLine("Saldo: " + conta1.GetSaldo());

        }
    }
}