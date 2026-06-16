using System;

namespace Ej1
{
    public class Semaforo
    {
        private string colorActual;
        private int segundosTranscurridos;
        private bool intermitente;
        private int segundosIntermitente;

        public Semaforo(string colorInicial)
        {
            colorActual = colorInicial;
            segundosTranscurridos = 0;
            intermitente = false;
            segundosIntermitente = 0;
        }

        public void PasoDelTiempo(int segundos)
        {
            if (intermitente)
            {
                segundosIntermitente += segundos;
                return;
            }
            segundosTranscurridos += segundos;
            ActualizarEstado();
        }

        private void ActualizarEstado()
        {
            bool cambio = true;
            while (cambio)
            {
                cambio = false;
                if (colorActual == "Rojo" && segundosTranscurridos >= 30)
                {
                    segundosTranscurridos -= 30;
                    colorActual = "Rojo + Amarillo";
                    cambio = true;
                }
                else if (colorActual == "Rojo + Amarillo" && segundosTranscurridos >= 2)
                {
                    segundosTranscurridos -= 2;
                    colorActual = "Verde";
                    cambio = true;
                }
                else if (colorActual == "Verde" && segundosTranscurridos >= 20)
                {
                    segundosTranscurridos -= 20;
                    colorActual = "Amarillo";
                    cambio = true;
                }
                else if (colorActual == "Amarillo" && segundosTranscurridos >= 2)
                {
                    segundosTranscurridos -= 2;
                    colorActual = "Rojo";
                    cambio = true;
                }
            }
        }

        public void MostrarColor()
        {
            if (intermitente)
            {
                Console.WriteLine(segundosIntermitente % 2 == 0 ? "LUZ: AMARILLO" : "LUZ: [APAGADO]");
            }
            else
            {
                Console.WriteLine("LUZ ACTUAL: " + colorActual);
                Console.WriteLine("TIEMPO EN ESTE COLOR: " + segundosTranscurridos + "s");
            }
        }

        public void PonerEnIntermitente()
        {
            intermitente = true;
            segundosIntermitente = 0;
        }

        public void SacarDeIntermitente()
        {
            intermitente = false;
        }
    }
}