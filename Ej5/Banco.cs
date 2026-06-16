namespace EJ5
{
    public class Banco
    {
        private List<CuentaBancaria> cuentas = new List<CuentaBancaria>();

        public void AgregarCuenta(CuentaBancaria cuenta) => cuentas.Add(cuenta);

        public void Transferir(CuentaBancaria origen, CuentaBancaria destino, double monto)
        {
            if (!cuentas.Contains(origen) || !cuentas.Contains(destino))
            {
                Console.WriteLine("Transferencia rechazada: una o ambas cuentas no están registradas.");
                return;
            }
            if (monto <= 0)
            {
                Console.WriteLine("Transferencia rechazada: el monto debe ser positivo.");
                return;
            }
            bool exito = origen.Extraer(monto);
            if (exito)
            {
                destino.Depositar(monto);
                Console.WriteLine($"Transferencia de {monto} realizada con éxito.");
            }
            else
            {
                Console.WriteLine("Transferencia rechazada: la cuenta origen no pudo realizar la extracción.");
            }
        }
    }
}