using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSuma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese numero 1");
            string numero1 = Console.ReadLine();
            int numero1Convertido = int.Parse(numero1);
            Console.WriteLine("Ingrese numero 2");
            string numero2 = Console.ReadLine();
            int numero2Convertido = int.Parse(numero2);

            int suma = numero1Convertido + numero2Convertido;
            Console.WriteLine("La suma es:" + suma);
            Console.ReadLine();
        }
    }
}
