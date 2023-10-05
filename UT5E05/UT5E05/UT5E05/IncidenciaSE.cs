using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT5E05
{
    internal class IncidenciaSE : Incidencia
    {
        private string Etiqueta { get; set; }
        private bool Instalacion { get; set; }
        private string Programa { get; set; }
        private bool Reconfiguracion { get; set; }
    }
}
