using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT2E9_SergioGonzalezVelez
{
    public class Pelicula
    {
        public int PeliculaId { get; set; }
        public string Titulo { get; set; }
        public int Anno { get; set; }
        public string Genero { get; set; }

        public Pelicula()
        {
            PeliculaId = 0;
        }

        public Pelicula(string titulo, int anno, string genero)
        {
            Titulo = titulo;
            Anno = anno;
            Genero = genero;
        }
    }

}
