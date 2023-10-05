using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GuardiApp
{
    static class Herramientas
    {
        /// <summary>
        /// Métodos manejadores del WebConsumer
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        #region
        public static async Task<Profesor> ObtenerAdmin(string user, string password)
        {
            WebConsumer wb = new WebConsumer();
            Profesor admin = await wb.PostAsync<Profesor>("http://127.0.0.1:8080/adminlogin", user, password);
            if (admin != null)
            {
                return admin;
            }
            return null;
        }
        public static async Task<List<Guardia>> ObtenerGuardias()
        {
            WebConsumer wb = new WebConsumer();
            List<Guardia> guardias = await wb.GetAsync<List<Guardia>>("http://127.0.0.1:8080/listadoguardias");
            return guardias;
        }
        public static async Task EliminarGuardia(int id)
        {
            WebConsumer wb = new WebConsumer();
            _ = await wb.DeleteAsync<Task>($"http://127.0.0.1:8080/guardia/eliminar/{id}");
        }
        public static async void ActualizarGuardia(Guardia guardia)
        {
            WebConsumer wb = new WebConsumer();
            _ = await wb.UpdateAsync($"http://127.0.0.1:8080/guardia/actualizar/{guardia.id}", guardia);
        }
        public static async Task CrearGuardia(Guardia guardia)
        {
            WebConsumer wb = new WebConsumer();
            _ = await wb.CreateAsync("http://127.0.0.1:8080/guardias/crear", guardia);
        }
        public static async Task<Profesor> ObtenerProfesorPorId(int id)
        {
            WebConsumer wb = new WebConsumer();
            Profesor profesor = await wb.GetAsync<Profesor>($"http://127.0.0.1:8080/profesores/{id}");
            return profesor;
        }
        public static async Task<Profesor> ObtenerProfesorPorNombre(string nombre)
        {
            WebConsumer wb = new WebConsumer();
            Profesor profesor = await wb.GetAsync<Profesor>($"http://127.0.0.1:8080/profesor/{nombre}");
            return profesor;
        }
        public static async Task<Horario> ObtenerHorario(int id, int hora, int dia)
        {
            WebConsumer wb = new WebConsumer();
            Horario horario = await wb.GetAsync<Horario>($"http://127.0.0.1:8080/horario/{id}/{hora}/{dia}");
            return horario;
        }
        #endregion
    }
}
