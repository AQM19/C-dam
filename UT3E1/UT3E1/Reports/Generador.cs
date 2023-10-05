using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT3E1.Reports
{
    internal class Generador
    {

        public void CargarInformeFabricantes()
        {
            VisorInforme visor = new VisorInforme();
            visor.rpvVisorInforme.LocalReport.ReportEmbeddedResource = "UT3E1.Reports.rptFabricantes.rdlc";
            string consultaFabricantes =
                "select p.fabricante, min(p.Precio) as preciodesde, max(p.precio) as preciohasta, " +
                "count(*) as referencias from productos p " +
                "group by p.Fabricante order by preciodesde";

            NeumaticosBD ctx = new NeumaticosBD();
            List<FabricanteWr> listaFabricantes =
           ctx.Database.SqlQuery<FabricanteWr>(consultaFabricantes, new object[0]).ToList();

            ReportDataSource funteDatosInforme = 
                new ReportDataSource("DataSetFabricantes", listaFabricantes);
            visor.rpvVisorInforme.LocalReport.DataSources.Add(funteDatosInforme);

            ReportParameter parametro = 
                new ReportParameter("ParametroInformacion", "Esto es un mensaje de prueba");

            visor.rpvVisorInforme.LocalReport.SetParameters(parametro);
            visor.rpvVisorInforme.SetDisplayMode(DisplayMode.PrintLayout);
            visor.rpvVisorInforme.RefreshReport();

            visor.Show();
        }

        public void CargarInformeFacturas()
        {
            VisorInforme visor = new VisorInforme();
            visor.rpvVisorInforme.LocalReport.ReportEmbeddedResource = "UT3E1.Reports.rptFacturas.rdlc";

            string consultaFacturas =
                "SELECT f.FacturaId, f.Numero, f.Pagada, f.Fecha, f.ImporteBase, f.IVA, f.ImporteTotal, "+
                "c.Nombre, c.DNICIF, c.Direccion, c.Telefono, " +
                "df.Concepto, df.Cantidad, df.PrecioUnidad, (df.Cantidad*df.PrecioUnidad) as 'Total de la linea' "+
                "FROM Facturas f JOIN Clientes c ON f.ClienteId = c.ClienteId "+
                "JOIN DetalleFacturas df ON f.FacturaId = df.FacturaId WHERE f.FacturaId < 11";

            NeumaticosBD ctx = new NeumaticosBD();
            List<FacturasWr> listaFacturas =
                ctx.Database.SqlQuery<FacturasWr>(consultaFacturas, new object[0]).ToList();
            ReportDataSource fuenteDatosInforme =
                new ReportDataSource("DataSetFacturas", listaFacturas);
            visor.rpvVisorInforme.LocalReport.DataSources.Add(fuenteDatosInforme);

            ReportParameter parametro =
                new ReportParameter("DatosVendedor", "Vendedor de prueba");

            visor.rpvVisorInforme.LocalReport.SetParameters(parametro);
            visor.rpvVisorInforme.SetDisplayMode(DisplayMode.PrintLayout);
            visor.rpvVisorInforme.RefreshReport();

            visor.Show();
        }

    }
}
