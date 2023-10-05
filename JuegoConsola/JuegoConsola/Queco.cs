using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JuegoConsola
{
    public class Queco
    {
        private int posicion;

        /// <summary>
        /// Obtiene o establece el espacio en el que se puede mover el queco
        /// </summary>
        public int Ancho 
        {
            get;
            private set;
        }

        /// <summary>
        /// Obtiene o establece la posicion en la que se encuentra el queco
        /// </summary>
        public int Posicion
        {
            get
            {
                return posicion;
            }

            private set
            {
                posicion = value;
            }
        }

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="resolucionX">Espacio horizontal en el que se puede mover el queco</param>
        /// <remarks>
        /// 1 - asignar a Ancho la resolucionX
        /// 2 - llamar a MoverCentro()
        /// </remarks>
        public Queco(int resolucionX)
        {
            Ancho = resolucionX;
            MoverCentro();
        }
    
        /// <summary>
        /// Mueve el queco a la derecha
        /// </summary>
        /// <remarks>
        /// 1 - Si posicion menor que ancho
        /// 1.1 - aumenta la posicion en 1
        /// </remarks>
        public void MoverDerecha()
        {
            if(Posicion < Ancho)
            {
                Posicion++;
            }
        }

        /// <summary>
        /// Mueve el queco a la izquierda
        /// </summary>
        /// <remarks>
        /// 1 - Si posicion > 0
        /// 1.1 - disminuye la posicion en 1
        /// </remarks>
        public void MoverIzquierda()
        {
            if(Posicion > 0)
            {
                Posicion--;
            }
        }

        /// <summary>
        /// Mueve el queco al centro de la pantalla.
        /// </summary>
        /// <remarks>
        /// 1 - Esteblece posicion como (Ancho / 2) 
        /// </remarks>
        public void MoverCentro()
        {
            Posicion = Ancho / 2;
        }
    }
}
