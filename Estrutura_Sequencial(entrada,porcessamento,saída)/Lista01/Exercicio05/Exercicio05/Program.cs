using System;
using System.Globalization;


namespace exercicio05 {
    class Program {
        static void Main(string[] args){

            int cod1, cod2,qtde1,qtde2;
            double preco1, preco2, total;

            string[] valores = Console.ReadLine().Split(' ');
            cod1 = int.Parse(valores[0]);
            qtde1 = int.Parse(valores[1]);
            preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);


            string[] valores2 = Console.ReadLine().Split(' ');
            cod2 = int.Parse(valores2[0]);
            qtde2 = int.Parse(valores2[1]);
            preco2 = double.Parse(valores2[2], CultureInfo.InvariantCulture);

            total = preco1 * qtde1 + preco2 * qtde2;

            Console.WriteLine("Valor a pagar:R$" + total.ToString("F2", CultureInfo.InvariantCulture));











        }
    }
}

