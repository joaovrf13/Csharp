﻿using System;
using System.ComponentModel.Design;
using System.Threading.Channels;

namespace exercicio03 {
    class Program {
        static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split(' ');

            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);

            if (A % B == 0 | B % A == 0) {

                Console.WriteLine("Sao multiplos");
            }
            else {

                Console.WriteLine("Nao são multiplos");
            }
          









        }






    }





}