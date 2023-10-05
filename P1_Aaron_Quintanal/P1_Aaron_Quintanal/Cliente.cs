using System.Linq;

namespace P1_Aaron_Quintanal
{
    internal class Cliente
    {
        public Falta[] ObtenerFaltas()
        {
            Parcial1DB bd = new Parcial1DB();
            return bd.Faltas.ToArray();
        }

        public Falta ObtenerFalta(int faltaId)
        {
            Parcial1DB bd = new Parcial1DB();
            return bd.Faltas.FirstOrDefault(x => x.FaltaId == faltaId);
        }

        public void CrearFalta(Falta faltaNuevo)
        {
            Parcial1DB bd = new Parcial1DB();
            bd.Faltas.Add(faltaNuevo);
            bd.SaveChanges();
        }

        public void ActualizarFalta(Falta faltaModificada)
        {
            Parcial1DB bd = new Parcial1DB();
            Falta faltaBD = bd.Faltas.FirstOrDefault(x => x.FaltaId == faltaModificada.FaltaId);
            if (faltaBD != null)
            {
                bd.Entry(faltaBD).CurrentValues.SetValues(faltaModificada);
                bd.SaveChanges();
            }
        }

        public void EliminarFalta(int faltaId)
        {
            Parcial1DB bd = new Parcial1DB();
            Falta faltaBD = bd.Faltas.FirstOrDefault(x => x.FaltaId == faltaId);
            if (faltaBD != null)
            {
                bd.Faltas.Remove(faltaBD);
                bd.SaveChanges();
            }
        }

        public Profesore[] ObtenerProfesores()
        {
            Parcial1DB bd = new Parcial1DB();
            return bd.Profesores.ToArray();
        }

        public Profesore ObtenerProfesor(int profesorId)
        {
            Parcial1DB bd = new Parcial1DB();
            return bd.Profesores.FirstOrDefault(x => x.ProfesorId == profesorId);
        }

        public void CrearProfesor(Profesore profesorNuevo)
        {
            profesorNuevo.Codigo = Herramientas.GenerarCodigoProfesor();
            Parcial1DB bd = new Parcial1DB();
            bd.Profesores.Add(profesorNuevo);
            bd.SaveChanges();
        }

        public void ActualizarProfesor(Profesore profesorModificado)
        {
            Parcial1DB bd = new Parcial1DB();
            Profesore profesorBD = bd.Profesores.FirstOrDefault(x => x.ProfesorId == profesorModificado.ProfesorId);
            if (profesorBD != null)
            {
                bd.Entry(profesorBD).CurrentValues.SetValues(profesorModificado);
                bd.SaveChanges();
            }
        }

        public void EliminarProfesor(int profesorId)
        {
            Parcial1DB bd = new Parcial1DB();
            Profesore profesorBD = bd.Profesores.FirstOrDefault(x => x.ProfesorId == profesorId);
            if (profesorBD != null)
            {
                bd.Faltas.RemoveRange(
                    bd.Faltas.Where(x => x.ProfeFalta.Equals(profesorId) || x.ProfeSusti.Equals(profesorId))
                    );

                bd.Profesores.Remove(profesorBD);
                bd.SaveChanges();
            }
        }
    }

}