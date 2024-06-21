using System;

namespace exercicio03 {
    class Program {

        static void Main(string[] args) { 
        
            int A, B , C , D ;

            Console.WriteLine("Digite o primeiro valor: ");
            A = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite o segundo valor: ");
            B = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite o terceiro valor: ");
            C = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite o quarto valor: ");
            D = int.Parse(Console.ReadLine());

            int diferenca = (A * B - C * D);

            Console.WriteLine($"A diferença é:{diferenca}");













        }   















    }













}