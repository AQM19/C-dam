using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoocanV2.Reports
{
    internal class GeneralWr
    {

        public string NombreCuidador { get; set; }
        public string TelefonoCuidador { get; set; }
        public int SalarioAnual { get; set; }
        public bool Responsable { get; set; }

        public int RefugioId { get; set; }
        public string NombreRefugio { get; set; }
        public string EspecieRefugio { get; set; }
        public int MaxAnimales { get; set; }
    }
}
