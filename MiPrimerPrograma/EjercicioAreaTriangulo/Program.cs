using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAreaTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la base del triangulo");
            string cadena = Console.ReadLine();
            int baset = int.Parse(cadena);
            Console.WriteLine("Ingrese la altura del triangulo");
            string cadena1 = Console.ReadLine();
            int altura = int.Parse(cadena1);
            int area = baset * altura /2;

            Console.WriteLine("El area del triangulo es: " + area);
            
            
            Console.ReadLine();

        }
    }
}
