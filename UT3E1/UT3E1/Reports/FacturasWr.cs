using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT3E1.Reports
{
    internal class FacturasWr
    {
        public int FacturaId { get; set; }
        public int Numero { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha { get; set; }
        public double ImporteBase { get; set; }
        public int IVA { get; set; }
        public double ImporteTotal { get; set; }
        public string Nombre { get; set; }
        public string DNICIF { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Concepto { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnidad { get; set; }
        public double TotalDeLaLinea { get; set; }
    }
}
