using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 10;
            int suma = a + b;
            int resta = a - b;
            int multiplicacion = a * b;
            int division = a / b;
            Console.WriteLine("El resultado es:");
            Console.WriteLine("suma: " + suma);
            Console.WriteLine("resta: " + resta);
            Console.WriteLine("multiplicacion: " + multiplicacion);
            Console.WriteLine("Division: " + division);
        }
    }
}
