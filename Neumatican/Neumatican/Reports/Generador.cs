using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neumatican.Reports
{
    internal class Generador
    {
        public void CargarInformeFabricantes()
        {
            VisorInforme visor = new VisorInforme();
            visor.rpvVisorInforme.LocalReport.ReportEmbeddedResource =
                "Neumatican.Reports.rptfabricantes.rdlc";

            string consultaFabricantes =
                "select p.fabricante, min(p.Precio) as preciodesde, max(p.precio) as preciohasta, " +
                "count(*) as referencias from productos p " +
                "group by p.Fabricante order by preciodesde";

            NeumaticosBD ctx = new NeumaticosBD();

            List<FabricanteWr> listaFabricantes = 
                ctx.Database.SqlQuery<FabricanteWr>(consultaFabricantes, new object[0]).ToList();

            ReportDataSource fuenteDatosInforme = 
                new ReportDataSource("DataSetFabricantes", listaFabricantes);
            visor.rpvVisorInforme.LocalReport.DataSources.Add(fuenteDatosInforme);

            ReportParameter parametro = 
                new ReportParameter("ParametroInformacion", "Esto es un mensaje de prueba");

            visor.rpvVisorInforme.LocalReport.SetParameters(parametro);
            visor.rpvVisorInforme.SetDisplayMode(DisplayMode.PrintLayout);
            visor.rpvVisorInforme.RefreshReport();
            visor.Show();
        }
    }
}
