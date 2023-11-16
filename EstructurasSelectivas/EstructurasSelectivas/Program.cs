using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasSelectivas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 30;
            int b = 30;

            /*
             if(a > b){
                Console.WriteLine("A es mayor a B");
            }
            else
            {
                Console.WriteLine("B es mayor a A");
            }*/
            if (a.Equals(b)) 
                Console.WriteLine("Son Iguales");
            else
                Console.WriteLine(" No son Iguales");



            Console.ReadKey();
        }
    }
}
