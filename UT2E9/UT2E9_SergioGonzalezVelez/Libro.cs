using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT2E9_SergioGonzalezVelez
{
    public class Libro
    {
        public int LibroId { get; set; }
        public string Titulo { get; set; }
        public int Anno { get; set; }
        public string Autor { get; set; }

        public Libro() 
        {
            LibroId = 0;
        }
        public Libro(string titulo, int anno, string autor)
        {
            Titulo = titulo;
            Anno = anno;
            Autor = autor;
        }
    }

}
