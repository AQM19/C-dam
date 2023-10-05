using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JuegoConsola
{
    public class Granizo
    {
        private Random rnd = new Random();

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="resolucionX">Tamaño horizontal del area de juego</param>
        /// <param name="resolucionY">Tamaño vertical del area de juego</param>
        /// <remarks>
        /// 1 - crea la matriz Estado con el tamaño de resolucionX y resolucionY
        /// 2 - llama a Limpiar()
        /// 3 - establecer BolarPorLinea a 4
        /// </remarks>
        public Granizo(int resolucionX, int resolucionY)
        {
            Estado = new int[resolucionX,resolucionY];
            Limpiar();
            BolasPorLinea = 4;
        }

        /// <summary>
        /// Obtiene o establece el numero de bolas maximo por fila de granizo
        /// </summary>
        public int BolasPorLinea
        {
            get;
            set;
        }

        /// <summary>
        /// Obtiene la matriz con las filas de granizo
        /// </summary>
        public int[,] Estado
        {
            get;
            private set;
        }
    
        /// <summary>
        /// Añade una nueva linea al estado
        /// </summary>
        /// <remarks>
        /// OJO: el suelo es la fila 0 y el cielo es la última
        /// 1 - desplaza todas las filas en Estado una posicion (la 1 es la 0, la 2 es la 1, etc...)
        /// 2 - calcula aleatoriamente los granizos por fila (0 a BolasPorFila)
        /// 3 - rellena la ultima fila con el numero de copos obtenido aleatoriamente
        /// 3.1 - calcular aleatoriamente la posicion del granizo y añadirlo a la fila, si esta ocupado ponerlo en la siguiente posicion libre
        ///       el valor de ocupado sera un 1
        /// </remarks>
        public void AvanzarLinea()
        {
            // desplazar filas
            for(int i = Estado.GetLength(0)-1; i >= 0; i--)
            {
                for(int j = 0; j < Estado.GetLength(1); j++)
                {
                    if(i == 0)
                    {
                        Estado[i, j] = 0;
                    } else
                    {
                        Estado[i, j] = Estado[i - 1, j];
                    }
                }
            }

            // calcular aleatorio
            int NumeroCopos = rnd.Next(BolasPorLinea+1);

            // rellenar fila
            for(int i = 0; i <= NumeroCopos; i++)
            {
                int pos = rnd.Next(0, Estado.GetLength(0)-1);

                if(Estado[0, pos] != 1)
                {
                    Estado[0, pos] = 1;
                } 

            }


        }

        /// <summary>
        /// Restablece la propiedad Estado a valores por defecto
        /// </summary>
        /// <remarks>
        /// 1 - rellena Estado con el numero con 0 en todas las posiciones
        /// </remarks>
        public void Limpiar()
        {
            for(int i = 0; i < Estado.GetLength(0); i++)
            {
                for(int j = 0; j < Estado.GetLength(1); j++)
                {
                    Estado[i, j] = 0;
                }
            }
        }
    }
}
