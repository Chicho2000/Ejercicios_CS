using System;

namespace Ej2
{
    public class Cronometro
    {
        private int segundos;
        private int minutos;

        public Cronometro()
        {
            segundos = 0;
            minutos = 0;
        }

        public void Reiniciar()
        {
            segundos = 0;
            minutos = 0;
        }

        public void IncrementarTiempo()
        {
            segundos++;
            if (segundos > 59)
            {
                segundos = 0;
                minutos++;
            }
        }

        public string MostrarTiempo()
        {
            return minutos + " minutos, " + segundos + " segundos";
        }
    }
}