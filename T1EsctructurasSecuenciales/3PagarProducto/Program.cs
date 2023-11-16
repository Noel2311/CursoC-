using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PagarProducto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar el precio del producto: ");
            double precioProducto = double.Parse(Console.ReadLine());
            double igv = precioProducto * 0.18;
            Console.WriteLine("IGV = " + igv);
            double totalPagar = precioProducto + igv;
            Console.WriteLine("El total del producto a pagar: " + totalPagar);
            Console.ReadKey();
        }
    }
}
