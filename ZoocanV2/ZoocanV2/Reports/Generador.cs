using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoocanV2.Reports
{
    internal class Generador
    {

        public void CargarInformeRefugio(int id)
        {
            VisorInforme visor = new VisorInforme();
            visor.rpvVisor.LocalReport.ReportEmbeddedResource = "ZoocanV2.Reports.rptRefugios.rdlc";
            string consultaRefugio =
            "SELECT c.CuidadorId, c.RefugioId, c.Direccion as 'DireccionCuidador', c.Especie as 'EspecieCuidador', c.Nombre as 'NombreCuidador', c.SalarioAnual, c.Telefono as 'TelefonoCuidador', c.Responsable, " +
                "r.RefugioId, r.Nombre as 'NombreRefugio', r.Direccion as 'DireccionRefugio', r.Especie as 'EspecieRefugio', r.MaxAnimales, r.Telefono as 'TelefonoRefugio' " +
                "FROM Cuidadores as c " +
                "JOIN Refugios as r ON r.RefugioId = c.RefugioId " +
                "WHERE c.RefugioId = " + id +
                "ORDER BY c.Responsable DESC;";

            ZoocanBD ctx = new ZoocanBD();
            List<RefugiosWr> informeRefugio =
                ctx.Database.SqlQuery<RefugiosWr>(consultaRefugio, new object[0]).ToList();

            ReportDataSource fuenteDatosInforme =
                new ReportDataSource("DataSetRefugios", informeRefugio);
            visor.rpvVisor.LocalReport.DataSources.Add(fuenteDatosInforme);

            visor.rpvVisor.SetDisplayMode(DisplayMode.PrintLayout);
            visor.rpvVisor.RefreshReport();
            visor.Show();
        }

        public void CargarInformeGeneral()
        {
            VisorInforme visor = new VisorInforme();
            visor.rpvVisor.LocalReport.ReportEmbeddedResource = "ZoocanV2.Reports.rptGeneral.rdlc";
            string consultaRefugio =
                "SELECT c.Nombre as 'NombreCuidador', c.Telefono as 'TelefonoCuidador', c.SalarioAnual, c.Responsable, " +
                "r.RefugioId, r.Nombre as 'NombreRefugio', r.Especie as 'EspecieRefugio', r.MaxAnimales" +
                "FROM Cuidadores as c" +
                "JOIN Refugios as r ON c.RefugioId = r.RefugioId;";

            ZoocanBD ctx = new ZoocanBD();
            List<GeneralWr> informeRefugio =
                ctx.Database.SqlQuery<GeneralWr>(consultaRefugio, new object[0]).ToList();

            ReportDataSource fuenteDatosInforme =
                new ReportDataSource("DataSetGeneral", informeRefugio);
            visor.rpvVisor.LocalReport.DataSources.Add(fuenteDatosInforme);

            visor.rpvVisor.SetDisplayMode(DisplayMode.PrintLayout);
            visor.rpvVisor.RefreshReport();
            visor.Show();
        }

        public void CargarInformeAnimal(int id)
        {
            VisorInforme visor = new VisorInforme();
            visor.rpvVisor.LocalReport.ReportEmbeddedResource = "ZoocanV2.Reports.rptAnimales.rdlc";
            string consultaAnimal =
                "SELECT a.AnimalId, a.RefugioId as 'RefugioAnimal', a.Nombre as 'NombreAnimal', a.Nacimiento, a.Entrada, a.Especie as 'EspecieAnimal', a.Raza, a.Peso, a.EspacioMin, " +
                "c.CuidadorId, c.RefugioId as 'RefugioCuidador', c.Nombre as 'NombreCuidador', c.Telefono as 'TelefonoCuidador', c.Direccion as 'DireccionCuidador', c.SalarioAnual, c.Especie as 'EspecieCuidador', c.Responsable, " +
                "r.Nombre as 'NombreRefugio' " +
                "FROM Animales as a " +
                "JOIN Refugios as r ON r.RefugioId = a.RefugioId " +
                "JOIN Cuidadores as c ON c.Especie = a.Especie " +
                "WHERE AnimalId = " + id;

            ZoocanBD ctx = new ZoocanBD();
            List<AnimalesWr> informesAnimal =
                ctx.Database.SqlQuery<AnimalesWr>(consultaAnimal, new object[0]).ToList();

            ReportDataSource fuenteDatosInforme =
                new ReportDataSource("DataSetAnimales", informesAnimal);
            visor.rpvVisor.LocalReport.DataSources.Add(fuenteDatosInforme);

            visor.rpvVisor.SetDisplayMode(DisplayMode.PrintLayout);
            visor.rpvVisor.RefreshReport();
            visor.Show();
        }

        public void CargarInformeAnimalesRefugio(int id)
        {
            VisorInforme visor = new VisorInforme();
            visor.rpvVisor.LocalReport.ReportEmbeddedResource = "ZoocanV2.Reports.rptAnimalesDeRefugio.rdlc";
            string consultaAnimal =
                "SELECT a.AnimalId, a.Nombre as 'NombreAnimal', a.Nacimiento, a.Entrada, a.Raza as 'RazaAnimal', a.Peso, a.EspacioMin, " +
                "r.RefugioId, r.Nombre as 'NombreRefugio', r.Direccion as 'DireccionRefugio', r.Especie as 'EspecieRefugio', r.Telefono as 'TelefonoRefugio', r.MaxAnimales, " +
                "c.Nombre as 'NombreResponsable', c.Responsable " +
                "FROM Animales as a " +
                "JOIN Refugios as r ON a.RefugioId = r.RefugioId " +
                "JOIN Cuidadores as c ON r.RefugioId = c.RefugioId AND c.Responsable = 1 " +
                "WHERE r.RefugioId =  " + id +
                "ORDER BY a.Entrada;";

            ZoocanBD ctx = new ZoocanBD();
            List<AnimalesDeRefugioWr> informesAnimal =
                ctx.Database.SqlQuery<AnimalesDeRefugioWr>(consultaAnimal, new object[0]).ToList();

            ReportDataSource fuenteDatosInforme =
                new ReportDataSource("DataSetAnimalesDeRefugio", informesAnimal);
            visor.rpvVisor.LocalReport.DataSources.Add(fuenteDatosInforme);

            visor.rpvVisor.SetDisplayMode(DisplayMode.PrintLayout);
            visor.rpvVisor.RefreshReport();
            visor.Show();
        }

    }
}
