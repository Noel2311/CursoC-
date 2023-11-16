using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1SemanaDia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar un Número");
            int numero = int.Parse(Console.ReadLine());
            int semanadia = numero * 7;
            Console.WriteLine("El numero de semana " + numero + " tiene " + semanadia + " dias ");
            Console.ReadLine();
        }
    }
}
