using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoocanV2.Reports
{
    internal class AnimalesWr
    {
        // animales
        public int AnimalId { get; set; }
        public int RefugioAnimal { get; set; }
        public string NombreAnimal { get; set; }
        public DateTime Nacimiento { get; set; }
        public DateTime Entrada { get; set; }
        public string EspecieAnimal { get; set; }
        public string Raza { get; set; }
        public float Peso { get; set; }
        public int EspacioMin { get; set; }

        // cuidadores
        public int CuidadorId { get; set; }
        public int RefugioCuidador { get; set; }
        public string NombreCuidador { get; set; }
        public string TelefonoCuidador { get; set; }
        public string DirecionCuidador { get; set; }
        public int SalarioAnual { get; set; }
        public string EspecieCuidador { get; set; }
        public bool Responsable { get; set; }

        // refugios
        public string NombreRefugio { get; set; }
    }
}
