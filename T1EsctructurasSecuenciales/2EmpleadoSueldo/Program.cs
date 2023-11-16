using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2EmpleadoSueldo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar el número de horas trabajadas");
            int horaTrabajada = Convert.ToInt32(Console.ReadLine());
            int ganancia = horaTrabajada * 20;
            Console.WriteLine("El empleado gana en total: " + ganancia + " soles" );
            Console.ReadKey();
        }
    }
}
