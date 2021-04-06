using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una fecha: ");
            DateTime Fecha;
            while (true)
            {
                if(DateTime.TryParse(Console.ReadLine(), out Fecha))
                {
                    break;
                }

                Console.Write("Fecha inválida. Ingrésela nuevamente: ");
            }

            Console.WriteLine($"Hora de la fecha: {Fecha.Hour}");
            Console.WriteLine($"Hora completa de la fecha: {Fecha.ToString("HH:mm:ss.fff")}");

            Console.ReadKey();
        }
    }
}
