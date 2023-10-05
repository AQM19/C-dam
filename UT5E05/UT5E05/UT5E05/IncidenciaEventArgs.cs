using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT5E05
{
    internal class IncidenciaEventArgs
    {
        private object _dato;

        public object Dato { get { return _dato; } }

        public IncidenciaEventArgs(Incidencia incidencia) {}
    }
}
