using System;
using System.Threading.Channels;
using System.Globalization;

namespace exercicio04{
    class Program {
        static void Main(string[] args) {

            int hours, number;
            double remuneration, valorHora;


            number = int.Parse(Console.ReadLine());
            hours = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            remuneration = valorHora * hours;

            

            Console.WriteLine("Numero:" +number);
            Console.WriteLine("Salário R$:" +remuneration.ToString("F2", CultureInfo.InvariantCulture));


















        }
    }
}