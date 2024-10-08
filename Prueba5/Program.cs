using System;

namespace Tarea
{
    class Program
    {
        public static void Main(string[] args)
        {
            int CalculoTotal = 0;

            Console.WriteLine("Grupo 1M2-S");

            do
            {
                Console.WriteLine("Ingrese la Asistencia Total: ");
                CalculoTotal = Convert.ToInt32(Console.ReadLine());
                if (CalculoTotal < 0)
                {
                    Console.WriteLine("Ingrese un numero Positivo");
                }

            } while (CalculoTotal < 0);


            Console.WriteLine("Ingrese la Cantidad de Estudiante");
            int estudiante = Convert.ToInt32(Console.ReadLine());

            string[] CantidadNombre = new string[estudiante];
            double[] CantidadAsis = new double[estudiante];
        }
    }
}

//C: \Users\T440\Documents\