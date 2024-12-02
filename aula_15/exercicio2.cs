using System;

namespace Aula_15
{
    class Lista
    {
        // Estrutura de um nó (Node) para armazenar valores e apontar para o próximo nó
        class Node
        {
            public int Valor;      // Valor armazenado no nó
            public Node? Proximo;  // Referência para o próximo nó na lista encadeada
        }

        // Variável para armazenar o início da lista encadeada
        private Node? inicio = null;

        // Função para inserir um valor no final da lista
        public void Inserir(int valor)
        {
            Node novoNode = new Node { Valor = valor, Proximo = null };

            if (inicio == null)
            {
                inicio = novoNode;
            }
            else
            {
                Node atual = inicio;
                while (atual.Proximo != null)
                {
                    atual = atual.Proximo;
                }
                atual.Proximo = novoNode;
            }
        }

        public void Verificar(int valor)
        {
        Node? atual = inicio;
        int i = 0;

        while (atual != null)
        {
            if (atual.Valor == valor)
            {
                Console.WriteLine($"Esse valor existe e está na posição: {i}");
                return;
            }
            else
            {
                atual = atual.Proximo; 
                i++;
            }
        }

        Console.WriteLine("Esse valor não existe.");
        }

        // Função para excluir um valor específico da lista
        public void Excluir(int valor)
        {
            if (inicio == null) return;

            if (inicio.Valor == valor)
            {
                inicio = inicio.Proximo;
                return;
            }

            Node atual = inicio;
            while (atual.Proximo != null && atual.Proximo.Valor != valor)
            {
                atual = atual.Proximo;
            }

            if (atual.Proximo != null)
            {
                atual.Proximo = atual.Proximo.Proximo;
            }
        }

        // Função para listar todos os valores da lista
        public void Listar()
        {
            if (inicio == null)
            {
                Console.WriteLine("A lista está vazia.");
                return;
            }

            Node? atual = inicio;
            Console.WriteLine("Elementos na lista:");

            while (atual != null)
            {
                Console.WriteLine(atual.Valor);
                atual = atual.Proximo;
            }
        }

        // Função principal para execução do programa
        static void Teste(string[] args)
        {
            Lista lista = new Lista();

            lista.Inserir(10);
            lista.Inserir(20);
            lista.Inserir(30);

            lista.Listar();
            lista.Verificar(20);

            
        }
    }
}