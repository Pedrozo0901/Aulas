using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_28_exercicio
{
    public class Conta
    {
        public int Numero {get; set;}
        public string Titular {get; set;}
        public double Saldo {get; set;}
        public double LimiteDeSaque {get; set;}

        public Conta(int numero, string titular, double saldo, double limiteDeSaque)
        {
            Numero = numero;
            Titular = titular;
            try
            {
                if (saldo < 0)
                {
                    throw new InvalidOperationException("O saldo não pode ser negativo!");
                }
                Saldo = saldo;
            }
            catch(InvalidOperationException e)
            {
                System.Console.WriteLine("Erro: " + e.Message);
            }
            LimiteDeSaque = limiteDeSaque;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
            LimiteDeSaque += (valor*0.10);
        }

        public void getLimiteDeSaldo()
        {
            System.Console.WriteLine($"Limite de saque da conta: {LimiteDeSaque}");
        }
        public void Saque(double valor)
        {
            try
            {
                if (valor > Saldo)
                {
                    throw new InvalidOperationException("Saldo insuficiente para realizar o saque.");
                }

                if (valor > LimiteDeSaque)
                {
                    throw new InvalidOperationException("Valor do saque excede o limite permitido.");
                }

                Saldo -= valor;
                Console.WriteLine($"Saque de {valor} realizado com sucesso! Saldo restante: {Saldo}");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro inesperado: {e.Message}");
            }
        }

    }
}