using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDescuento
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingresar el Precio");
            double precio = double.Parse(Console.ReadLine());
            double descuento = precio * 0.2;
            double totalPagar = precio - descuento;

            Console.WriteLine("El descuento del Producto es: "+ descuento);
            Console.WriteLine("El total a Pagar es: "+ totalPagar);
            Console.ReadLine();
        }
    }
}
