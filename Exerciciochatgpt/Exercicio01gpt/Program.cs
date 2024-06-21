using System;
using System.Globalization;

namespace exercicio01 {

    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite um número de 1 a 7:");

            int dia = int.Parse(s: Console.ReadLine());

            switch (dia) {

                case 1:
                    Console.WriteLine("Domingo");
                    break;

                case 2:
                    Console.WriteLine("Segunda");
                    break;

                case 3:
                    Console.WriteLine("Terça");
                    break;

                case 4:
                    Console.WriteLine("Quarta");
                    break;

                case 5:
                    Console.WriteLine("Quinta");
                    break;

                case 6:
                    Console.WriteLine("Sexta");
                    break;

                case 7:
                    Console.WriteLine("Sabado");
                    break;

                default:
                    Console.WriteLine("Número inválido. Por Favor, digite um número de 1 a 7");
                    break;





            }
        }
    }
}















      



