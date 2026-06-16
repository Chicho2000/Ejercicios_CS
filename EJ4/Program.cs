using System;

namespace EJ4
{
    class Program
    {
        static void Main()
        {
            // Prueba 
            Auto fiat = new Auto(45);
            Bicicleta bici = new Bicicleta();
            Camion camion = new Camion();

            bici.Mover(20);
            Console.WriteLine($"Posición bici tras 20s: {bici.Posicion()} metros");
            bici.Mover(10);
            Console.WriteLine($"Posición bici tras 10s más: {bici.Posicion()} metros");

            // Carrera
            Console.WriteLine("\n--- Carrera: Fiat vs Camión (60 segundos) ---");
            Carrera carrera = new Carrera(fiat, camion);
            carrera.Correr(60);

            Console.WriteLine("\nPresioná Enter para salir...");
            Console.ReadLine(); 
        }
    }
}