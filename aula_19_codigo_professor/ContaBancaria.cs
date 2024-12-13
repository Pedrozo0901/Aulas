namespace aula_19_codigo_professor
{
    public class ContaBancaria
    {
        public class ContaBancaria{
            // Fazer as propriedades da classe
            public int Numero { get; private set;}
            public string Titular { get; set;}
            public double Saldo {get; private set;}

            // Construtor
            public ContaBancaria(int numero, string titular)
            {
                Numero = numero;
                Titular = titular;
            }

            // Construtor cm 3 parametros
            public ContaBancaria(int numero, string titular, double saldo) :this(numero, titular)
            {
                Saldo = saldo;
            }

            public void Deposito(double quantia)
            {
                Saldo += quantia;
            }

            // Função Saque
            public void Saque(double quantia)
            {
                Saldo -= quantia + 5.0;
            }

            public override string ToString()
            {
                return "Conta " + Numero + ", Titular: " + Titular + ", Saldo: $ " + Saldo.ToString("F2");
            }
        }
    }
}