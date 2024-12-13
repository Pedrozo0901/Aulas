namespace aula_19_exercicio
{
    public class Conta
    {
        private int _numeroDaConta;
        public string Nome { get; set;}
        protected double Saldo;

        public Conta(int numeroConta, string nome)
        {
            _numeroDaConta = numeroConta;
            Nome = nome; 
        }

        public Conta(int numeroConta, string nome, double saldo) : this(numeroConta, nome)
        {
            _numeroDaConta = numeroConta;
            Nome = nome; 
            Saldo = saldo;
        }

        public int NumeroDaConta
        {
            get{
                return _numeroDaConta;
            }
        }
        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo -= (saque + 5);
        }

        public double GetSaldo()
        {
            return Saldo;
        }
    }
}