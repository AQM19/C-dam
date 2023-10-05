using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoocan.Reports
{
    internal class AnimaleWr
    {
        public int AnimalId { get; set; }
        public string NombreRefugio { get; set; }
        public string NombreAnimale { get; set; }
        public DateTime Nacimiento { get; set; }
        public DateTime Entrada { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public float Peso { get; set; }
        public int EspacioMinimo { get; set; }
        public string NombreCuidadore { get; set; }
        public string Telefono { get; set; }
        public string NombreRefugioCuidadore { get; set; }
        public bool Responsable { get; set; }
    }
}
