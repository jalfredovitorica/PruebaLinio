using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola gente de Linio :)");

            Console.WriteLine("¿Hasta que numeros vamos a llegar?");
            string valor = Console.ReadLine();
            int contador = int.Parse(valor);

            Console.WriteLine("-----------------------------------------------");

            for (int i = 1; i <= contador; i++)
            {
                if (i % 3 == 0 & i % 5 == 0)
                {
                    Console.WriteLine("Linianos");
                }
                else
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine("Linio");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("IT");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
