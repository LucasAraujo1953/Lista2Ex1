using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.WriteLine("De dois valores distintos: ");
            Console.Write("Digite o primeiro valor: ");
            a=int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            b=int.Parse(Console.ReadLine());
            if (a > b)
                Console.WriteLine("O primeiro valor é maior que o Segundo.");
               else
                Console.WriteLine("O segundo valor é maior que o Primeiro.");
        }
    }
}
