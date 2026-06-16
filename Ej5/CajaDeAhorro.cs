namespace EJ5
{
    public class CajaDeAhorro : CuentaBancaria
    {
        public override bool Extraer(double monto)
        {
            if (monto <= 0)
            {
                Console.WriteLine("El monto debe ser positivo.");
                return false;
            }
            if (monto > Saldo)
            {
                Console.WriteLine("Saldo insuficiente. Operación rechazada.");
                return false;
            }
            AjustarSaldo(-monto);
            return true;
        }
    }
}