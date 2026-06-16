using System;
using System.Threading;

namespace Ej1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese el color inicial (Rojo, Verde, Amarillo): ");
            string inicio = Console.ReadLine();
            Semaforo miSemaforo = new Semaforo(inicio);

            Console.WriteLine("\nPresioná Ctrl+C para frenar el semáforo.\n");

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== SIMULADOR DE SEMÁFORO ===");
                miSemaforo.MostrarColor();
                miSemaforo.PasoDelTiempo(1);
                Thread.Sleep(1000);
            }
        }
    }
}