using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoocanV2.Reports
{
    internal class AnimalesDeRefugioWr
    {
        // animales
        public int AnimalId { get; set; }
        public string NombreAnimal { get; set; }
        public DateTime? Nacimiento { get; set; }
        public DateTime Entrada { get; set; }
        public int RefugioAnimal { get; set; }
        public string Raza { get; set; }
        public float Peso { get; set; }
        public int EspacioMin { get; set; }

        // refugios
        public int RefugioId { get; set; }
        public string NombreRefugio { get; set; }
        public string DireccionRefugio { get; set; }
        public string EspecieRefugio { get; set; }
        public string TelefonoRefugio { get; set; }
        public int MaxAnimales { get; set; }

        // cuidadores
        public string NombreResponsable { get; set; }
        public string TelefonoResponsable { get; set; }
    }
}
