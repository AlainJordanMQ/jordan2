using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            decimal x = 0;
            int num1, num2;
            float suma;
            float f = 0;
            double d = 0.0;
            string palabra;
            string cadena = "Hola Mundo";
            bool bandera = false;
            DateTime fecha = DateTime.UtcNow;

            Console.WriteLine("El dato de i es: " + i);
            Console.WriteLine("El dato de x es: " + x);
            Console.WriteLine("El dato de f es: " + f);
            Console.WriteLine("El dato de d es: " + d);
            Console.WriteLine("El dato de cadena es: " + cadena);
            Console.WriteLine("El dato de bandera es: " + bandera.ToString());
            Console.WriteLine("El dato de fecha es: " + fecha.ToShortDateString());
            Console.WriteLine("Dame un numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame otro numero: ");
            num2 = int.Parse(Console.ReadLine());
            suma = num1 + num2;
            Console.WriteLine("La suma es: {0}", suma);
            Console.WriteLine("palabra: ");
            palabra = Console.ReadLine();
            Console.WriteLine("{0}", palabra);
            Console.ReadKey();


        }
    }
}
