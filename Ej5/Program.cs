using System;

namespace EJ5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("--- Prueba CajaDeAhorro ---");
            CajaDeAhorro ahorro = new CajaDeAhorro();
            ahorro.Depositar(1000);
            ahorro.Extraer(400);
            ahorro.Extraer(800); // rechazada

            Console.WriteLine("\n--- Prueba CuentaCorriente ---");
            CuentaCorriente corriente = new CuentaCorriente(500);
            corriente.Depositar(200);
            corriente.Extraer(600); // queda en -400, valido
            corriente.Extraer(200); // supera descubierto, rechazada
            corriente.MostrarSaldo(); 

            Console.WriteLine("\n--- Prueba Banco ---");
            Banco banco = new Banco();
            CajaDeAhorro ahorro2 = new CajaDeAhorro();
            CuentaCorriente corriente2 = new CuentaCorriente(500);
            banco.AgregarCuenta(ahorro2);
            banco.AgregarCuenta(corriente2);
            ahorro2.Depositar(1000);
            banco.Transferir(ahorro2, corriente2, 300);  // todo bien
            banco.Transferir(ahorro2, corriente2, 900);  // rechazada

            Console.WriteLine("\nPresioná Enter para salir...");
            Console.ReadLine(); //agrego estas porque no me deja ver la solucion 
        }
    }
}