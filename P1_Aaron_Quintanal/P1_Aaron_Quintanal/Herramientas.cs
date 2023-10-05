using System;
using System.Linq;

namespace P1_Aaron_Quintanal
{
    internal class Herramientas
    {
        public static int? ObtenerProfesorIdPorCodigo(string codigo)
        {
            Parcial1DB bd = new Parcial1DB();
            Profesore profe = bd.Profesores.FirstOrDefault(x => x.Codigo.Equals(codigo));
            if (profe != null)
            {
                return profe.ProfesorId;
            }
            return null;
        }

        public static int? ObtenerProfesorIdPorNombre(string nombre)
        {
            Parcial1DB bd = new Parcial1DB();
            Profesore profe = bd.Profesores.FirstOrDefault(x => x.Nombre.Equals(nombre));
            if (profe != null)
            {
                return profe.ProfesorId;
            }
            return null;
        }

        public static string ObtenerProfesorNombrePorID(int profesorId)
        {
            Parcial1DB bd = new Parcial1DB();
            Profesore profe = bd.Profesores.FirstOrDefault(x => x.ProfesorId.Equals(profesorId));
            if (profe != null)
            {
                return profe.Nombre;
            }
            return string.Empty;
        }

        public static string GenerarCodigoProfesor()
        {
            Parcial1DB bd = new Parcial1DB();
            if (bd.Profesores.Count() == 0)
            {
                return "P01";
            }
            string cadena = bd.Profesores.Max(x => x.Codigo).Substring(1);
            return $"P{(Convert.ToInt32(cadena) + 1).ToString("00")}";
        }
    }
}