using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ZoocanV2.Reports
{
    internal class RefugiosWr
    {
        // cuidadores
        public int CuidadorId { get; set; }
        public string DirecionCuidador { get; set; }
        public string EspecieCuidador { get; set; }
        public string NombreCuidador { get; set; }
        public int SalarioAnual { get; set; }
        public string TelefonoCuidador { get; set; }
        public bool Responsable { get; set; }

        // refugios
        public int RefugioId { get; set; }
        public string NombreRefugio { get; set; }
        public string DireccionRefugio { get; set; }
        public string EspecieRefugio { get; set; }
        public int MaxAnimales { get; set; }
        public string TelefonoRefugio { get; set; }
    }
}
