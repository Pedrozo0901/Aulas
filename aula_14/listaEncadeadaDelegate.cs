// using System;

// namespace Aua_14
// {
//     public class ListaEncadeadaDelegate 
//     {
//         static delegate void FuncaDelegate(int valor);

//         string x = null;

//         static FuncaDelegate? inicio = null;

//         static FuncaoDelegate? inicio = null;

//         static FuncaDelegate CriarNo(int valor, FuncaDelegate? proximo)
//         {
//             return v =>
//             {
//                 System.Console.WriteLine(valor);
//                 proximo?.Index(v);
//             };
//         }
    
//     }

// }