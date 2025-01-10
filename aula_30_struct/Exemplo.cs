// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace aula_30_struct
// {
//     public struct PessoaStruct
//     {
//         public string Nome {get; set;}
//         public int Idade {get; set;}

//         public PessoaStruct(string nome, int idade)
//         {
//             Nome = nome;
//             Idade = idade;
//         }

//         public override string ToString()
//         {
//             return $"Nome: {Nome}, Idade: {Idade}";
//         }
//     }

//     public struct PessoaClasse
//     {
//         public string Nome {get; set;}
//         public int Idade {get; set;}

//         public PessoaClasse(string nome, int idade)
//         {
//             Nome = nome;
//             Idade = idade;
//         }

//         public override string ToString()
//         {
//             return $"Nome: {Nome}, Idade: {Idade}";
//         }
//     }

//     class ExecutarExe
//     {
//         public static void Main(string[] args)
//         {
//             // Trabalha com struct pessoa
//             PessoaStruct pessoaStruct1 = new PessoaStruct("Jhon", 20);
//             PessoaStruct pessoaStruct2 = pessoaStruct1;
//             pessoaStruct2.Nome = "Maria";

//             System.Console.WriteLine(pessoaStruct1);
//             System.Console.WriteLine(pessoaStruct2);

//             // Trabalha com class pessoa
//             PessoaStruct pessoaClasse1 = new PessoaStruct("Jhon", 20);
//             PessoaStruct pessoaClasse2 = pessoaClasse1;
//             pessoaStruct2.Nome = "Maria";

//             System.Console.WriteLine(pessoaClasse1);
//             System.Console.WriteLine(pessoaClasse2);

//             // 1. Struct é um tipo de valor, então atibuições criam copias independentes
//             // 2. Classe é um tipo de referênca, então atribuições criam referências para o me
//             // 3. Struct são mais leves e geralmente são usado parados simples e imutaveis
//             // 4

//         }
//     }
// }