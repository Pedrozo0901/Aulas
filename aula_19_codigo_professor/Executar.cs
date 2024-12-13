namespace aula_19_codigo_professor
{
    public class Executar
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            System.Console.WriteLine("Entre o número da sua conta");
            int numero = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Entre o nome do titular");
            string titular = System.Console.ReadLine();
            
            System.Console.WriteLine("Haverá depósito inicial (s/n)?");
            char resp = char.Parse(System.Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                System.Console.WriteLine("Entre com o valor de depósito inicial: ");
                double depositoInicial = double.Parse(System.Console.ReadLine());
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else {
                conta = new ContaBancaria(numero, tiular);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Dados da conta: ");
            System.Console.WriteLine(conta);

            System.Console.WriteLine();
            System.Console.WriteLine("Entre com o valor do depósito: ");
            double quantia = double.Parse(System.Console.ReadLine(), Culture.InvariantCulture);
            conta.Deposito(quantia);
            System.Console.WriteLine("Dados Atualzados da conta");
            System.Console.WriteLine(conta);

            System.Console.WriteLine();
            System.Console.WriteLine("Entre com o valor do saque:");
            
        }
    }
}