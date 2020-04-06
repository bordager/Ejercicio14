using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Introduzca un numero");
                string numero;
                numero = Console.ReadLine();
            int num;
            long resultado = 1;

            if (Esnumero(numero) == true)
            {
                num = int.Parse(numero);
            }
            else
            {
                Console.WriteLine("No es un numero");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("La tabla de multiplicar de " + num + " es: ");

            for (int i = 1; i <= 10; i++)
            {
                resultado = num * i;
                Console.WriteLine(num + " x " + i + " = " + resultado);
                
            }

            Console.ReadLine();
        }

        public static bool Esnumero(string numero)
        {
            try
            {
                int num = int.Parse(numero);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
