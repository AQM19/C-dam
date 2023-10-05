using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT2E9
{
    public class Libro
    {
        public int LibroId { get; set; }
        public string Titulo { get; set; }
        public int Anno { get; set; }
        public string Autor { get; set; }
    }
}
