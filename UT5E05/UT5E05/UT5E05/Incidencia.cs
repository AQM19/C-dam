using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT5E05
{
    internal abstract class Incidencia
    {
        private bool Cerrada { get; set; }
        private string Descripcion { get; set; }
        private DateTime Fecha { get; set; }
        private int IncidenciaId { get; set; }
        private string Observaciones { get; set; }
        private TipoIncidenciaEnum Tipo { get; set; }

        private void IncidenciaBorradaEventHandler(object sender, IncidenciaEventArgs args) { }
        private void IncidenciaModificadaEventHandler(object sender, IncidenciaEventArgs args) { }
    }
}
