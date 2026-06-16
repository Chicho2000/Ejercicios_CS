using System;

namespace EJ6
{
    class Program
    {
        static void Main()
        {
            Mazo mazo = new Mazo();
            mazo.Barajar();

            Mano jugador1 = new Mano();
            Mano jugador2 = new Mano();

            for (int i = 0; i < 3; i++)
            {
                jugador1.RecibirCarta(mazo.RobarCarta());
                jugador2.RecibirCarta(mazo.RobarCarta());
            }

            Console.WriteLine("--- Mano Jugador 1 ---");
            jugador1.MostrarMano();

            Console.WriteLine("--- Mano Jugador 2 ---");
            jugador2.MostrarMano();

            Console.WriteLine($"\nCartas restantes en el mazo: {mazo.CuantasCartasQuedan()}");

            Console.WriteLine("\nPresioná Enter para salir...");
            Console.ReadLine();

            //El Mazo no debería repartir porque no es su responsabilidad;
            //lo ideal es una clase Repartidor que coordine el Mazo y las Manos.
        }
    }
}