using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardiApp
{
    public class Guardia
    {
        public int id { get; set; }
        public int prof_falta { get; set; }
        public int? prof_hace_guardia { get; set; }
        public string estado { get; set; }
        public DateTime fecha { get; set; }
        public int horario { get; set; }
        public int? dia_semana { get; set; }
        public int hora { get; set; }
        public int? aviso { get; set; }
        public string grupo { get; set; }
        public string aula { get; set; }
        public string observaciones { get; set; }

        
    }
}
