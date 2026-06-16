namespace EJ5
{
    public class CuentaCorriente : CuentaBancaria
    {
        private double descubierto;

        public CuentaCorriente(double descubierto)
        {
            this.descubierto = descubierto;
        }

        public override bool Extraer(double monto)
        {
            if (monto <= 0)
            {
                Console.WriteLine("El monto debe ser positivo.");
                return false;
            }
            if (Saldo - monto < -descubierto)
            {
                Console.WriteLine("Supera el límite de descubierto. Operación rechazada.");
                return false;
            }
            AjustarSaldo(-monto);
            return true;
        }
    }
}