using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT5E05
{
    internal class IncidenciaHW : Incidencia
    {
        private TipoHardwareEnum Clase { get; set; }
        private bool Enciende { get; set; }
        private string Etiqueta { get; set; }
    }
}
