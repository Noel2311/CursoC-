using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertirDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 30;
            //ToString nos permite convertir numero a caden as
            string cadena = a.ToString(); 
            Console.WriteLine(cadena);  



            string numero = "20";
            //parse nos permite convertir de cadena a número
            int numeroConvertido = int.Parse(numero);
            int resultado = numeroConvertido + 10;

            Console.WriteLine("suma " + resultado);
            Console.ReadLine(); 
        }
    }
}
