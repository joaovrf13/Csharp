using System;
using System.Globalization;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace exercicio04 {
    class Program {
        static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split(' ');

            int inicial = int.Parse(valores[0]);
            int final = int.Parse(valores[1]);

            int duracao;

            if (inicial < final) {
                duracao = final - inicial;

                Console.WriteLine("A duração foi de: " +duracao+ "horas");

            }

            else {
                duracao = 24 - inicial + final;

                Console.WriteLine("A duração foi de: " + duracao + "horas");
            }


        }
    }
}



