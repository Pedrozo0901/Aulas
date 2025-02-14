using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Aula_14
{
    public class PilhaEncadeada
    {
        class Node
        {
            public int valor;
            public Node? proximo;
        }

        static Node? topo = null;

        // Empilha é acrescentar um elemento no topo da pilha
        static void Empilhar(int valor)
        {
            // Cria um novo no com valor fornecido
            Node novoNode = new Node { valor = valor, proximo = topo };

            // Atualiza o topo do No
            topo = novoNode;
        }

        // Desempilhar é remover o elemento do topo da pilha
        static void Desempilhar()
        {
            if (topo == null)
            {
                Console.WriteLine("Pilha vazia!");
                return;
            }

            Console.WriteLine($"Desempilhando {topo.valor}");
            topo = topo.proximo;
        }

        // Reverter os Ponteiros
        static void Reverter()
        {
            // Se a pilha estiver vazia ou tiver apenas um elemento
            if (topo == null || topo.proximo == null)
            {
                return;
            }
            Node? anterior = null;
            Node? atual = topo;
            Node? proximo;

            while (atual != null)
            {
                proximo = atual.proximo; // Salva o próximo nó
                atual.proximo = anterior; // Inverte o ponteiro
                anterior = atual; // Atualiza o anterior
                atual = proximo; // Avança para o próximo nó
            }

            // Ajusta o topo da pilha
            topo = anterior;
        }

        // Listar a Pilha
        static void Listar()
        {
            if (topo == null)
            {
                Console.WriteLine("Pilha vazia!");
                return;
            }
            System.Console.WriteLine("Listando a Pilha");
            Node? atual = topo;
            while (atual != null)
            {
                Console.WriteLine(atual.valor);
                atual = atual.proximo;
            }
        }

        static void Teste()
        {
            Empilhar(10);
            Empilhar(20);
            Empilhar(30);
            Empilhar(40);
            Empilhar(50);
            Listar();
            Reverter();
            Listar();
        }
    }
}