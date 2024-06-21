using System;
using System.Globalization;

namespace exercicio06 {
    class Program {
        static void Main(string[] args) {

            double A, B, C, tri, cir, trap, qua, ret, pi = 3.14159;


            string[] valores = Console.ReadLine().Split(' ');
            
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);


            tri = A * C / 2.0;
            cir = A = pi * C * C;
            trap = A + B / 2.0 * C;
            qua = B * B;
            ret = A * B;

            Console.WriteLine("Triangulo: " +tri.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Circulo: " +cir.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapezio: " +trap.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Quadrado: " + qua.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Retangulo: " + ret.ToString("F3", CultureInfo.InvariantCulture));












        }



    }



}
