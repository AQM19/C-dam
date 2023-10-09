using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardiApp
{
    public class Horario
    {
        public int id { get; set; }
        public int profesor { get; set; }   
        public int dia_semana { get; set; }
        public int hora { get; set; }
        public string aula { get; set; }
        public string grupo { get; set; }
        public string materia { get; set; }
        public bool genera_guardia { get; set; }
    }
}
