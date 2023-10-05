using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoocan.Reports
{
    internal class Generador
    {

        public void CargarInformePorAnimalId(int id)
        {
            VisorInforme visor = new VisorInforme();
            visor.rpvVisorInforme.LocalReport.ReportEmbeddedResource = "Zoocan.Reports.rptAnimale.rdlc";
            string consultaAnimal =
                "SELECT a.AnimalId, r.Nombre as 'Refugio', a.Nombre, a.Nacimiento, a.Entrada, a.Especie, a.Raza, a.Peso, a.EspacioMin, " +
                "c.Nombre, c.Telefono, (SELECT r.Nombre FROM Refugios r WHERE r.RefugioId = c.RefugioId) as 'Refugio del cuidador', c.Responsable " +
                "FROM Animales a " +
                "JOIN Cuidadores c ON a.Especie = c.Especie " +
                "JOIN Refugios r ON a.RefugioId = r.RefugioId "+
                "WHERE AnimalId = " + id;

            ZoocanDB ctx = new ZoocanDB();
            List<AnimaleWr> listaAnimale =
                ctx.Database.SqlQuery<AnimaleWr>(consultaAnimal, new object[0]).ToList();

            ReportDataSource fuenteDatosInforme = 
                new ReportDataSource("DataSetAnimale", listaAnimale);
            visor.rpvVisorInforme.LocalReport.DataSources.Add(fuenteDatosInforme);

            visor.rpvVisorInforme.SetDisplayMode(DisplayMode.PrintLayout);
            visor.rpvVisorInforme.RefreshReport();
            visor.Show();
        }

    }
}
