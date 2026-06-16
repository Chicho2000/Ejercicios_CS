using System;

namespace Ej2
{
    class Program
    {
        static void Main()
        {
            Cronometro cronometro = new Cronometro();

            // Simulamos el paso del tiempo 5000 veces
            for (int i = 0; i < 5000; i++)
            {
                cronometro.IncrementarTiempo();
            }

            Console.WriteLine(cronometro.MostrarTiempo());
        }
    }
}