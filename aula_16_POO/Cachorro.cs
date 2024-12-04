// using System;

// namespace Aula_16
// {
//     class Cachorro
//     {
//         public string Nome;
//         public string Raca;
//         public int Idade;

//         public void escrevaSaida()
//         {
//             Console.WriteLine("Nome: " + Nome);
//             Console.WriteLine("Raça: " + Raca);
//             Console.WriteLine("Idade: " + Idade + "Anos");
//             Console.WriteLine("Idade em humano " + getIdadeHumano());
//         }

//         public int getIdadeHumano()
//         {
//             int idadeHumano = 0;
//             if(Idade <= 2){
//                 idadeHumano = Idade * 11;
//             } else{
//                 idadeHumano = 22 + (Idade - 2) * 5;
//             }
//             return idadeHumano;
//         }
//     }
// }