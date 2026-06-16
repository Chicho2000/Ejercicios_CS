namespace EJ5
{
    public abstract class CuentaBancaria
    {
        private double saldo = 0;

        protected double Saldo => saldo;

        public void Depositar(double monto)
        {
            if (monto <= 0)
            {
                Console.WriteLine("El monto a depositar debe ser positivo.");
                return;
            }
            saldo += monto;
        }

        // Cada subclase diferente -.-
        public abstract bool Extraer(double monto);

        public void MostrarSaldo() =>
            Console.WriteLine($"Saldo actual: {saldo}");

        // Pa que las subclases puedan modificar el saldo internamente
        protected void AjustarSaldo(double monto) => saldo += monto;
    }
}