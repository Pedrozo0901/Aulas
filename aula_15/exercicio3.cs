using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Aula_15
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

        static void VerificarTopo()
        {
            if(topo == null)
            {

                System.Console.WriteLine("A lista está vazia");
                return;
            }
            else
            {
                System.Console.WriteLine($"O topo da lista é {topo.valor}");
                return;
            }
        }

        static void teste(string[] args)
        {
            Empilhar(10);
            Empilhar(20);
            Empilhar(30);
            Listar();
            VerificarTopo();
        }
    }
}