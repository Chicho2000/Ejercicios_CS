using System;

namespace Ej3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("¿Qué tipo de jugador querés crear?");
            Console.WriteLine("1. Amateur");
            Console.WriteLine("2. Profesional");
            Console.Write("Opción: ");
            string opcion = Console.ReadLine();

            IJugador jugador;
            if (opcion == "1")
                jugador = new Amateur();
            else if (opcion == "2")
                jugador = new Profesional();
            else
            {
                Console.WriteLine("Opción inválida.");
                return;
            }

            // Caso de prueba
            Console.WriteLine("\n--- Caso de prueba ---");

            Console.WriteLine("Intenta correr 15 minutos: " + jugador.Correr(15));
            Console.WriteLine("¿Está cansado?: " + jugador.Cansado());

            Console.WriteLine("Intenta correr 10 minutos más: " + jugador.Correr(10));
            Console.WriteLine("¿Está cansado?: " + jugador.Cansado());

            Console.WriteLine("Descansa 20 minutos...");
            jugador.Descansar(20);
            Console.WriteLine("¿Está cansado?: " + jugador.Cansado());

            Console.WriteLine("Intenta correr 5 minutos: " + jugador.Correr(5));
        }
    }
}