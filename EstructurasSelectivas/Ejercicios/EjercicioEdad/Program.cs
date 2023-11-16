using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEdad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar Edad");
            int Edad = int.Parse(Console.ReadLine());
            if (Edad >= 18)
                Console.WriteLine("La persona es mayor de edad: " + Edad + " Años");
            else
                Console.WriteLine("La persona es menor de edad: " + Edad + " Años");
            Console.ReadKey();

        }
    }
}
