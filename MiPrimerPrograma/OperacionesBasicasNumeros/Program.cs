using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesBasicasNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 50;
            int b = 40;
            double c = 20.5;

            int suma = a + b;
            int resta = a - b;
            int multiplicacion = a * b;
            double division = (a * 1.0) / b;
            int residuo = a % b;

            Console.WriteLine("La suma es: " + suma);
            Console.WriteLine("La resta es: " + resta);
            Console.WriteLine("La multiplicación es: " + multiplicacion);
            Console.WriteLine("La división es: " + division);
            Console.WriteLine("El residuo es: " + residuo);
            Console.ReadLine();
        }
    }
}
