using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT5E04
{
    internal class Negocio
    {
        private int _reservaId = 0;
        private List<Reserva> reservas;

        public void BorrarReserva(int reservaid) {
            Reserva reserva = reservas.FirstOrDefault(x => x.ReservaId == reservaid);
            if(reserva != null)
            {
                reservas.Remove(reserva);
            }
        }
        public void CrearReserva(Reserva reserva) {
            if(reserva != null)
            {
                reserva.ReservaId = SiguienteReservaId();
                reservas.Add(reserva);
            }
        }
        public Negocio() {
            reservas = new List<Reserva>();
        }
        public Reserva ObtenerReserva(int reservaid) {
            return reservas.FirstOrDefault(x => x.ReservaId == reservaid);
        }
        public Reserva[] ObtenerReservas() {
            return reservas.ToArray();
        }
        private int SiguienteReservaId() {
            return ++_reservaId;
        }
        public void ConfirmarAsistencia(Reserva reserva)
        {
            if(reserva != null)
            {
                reserva.Asiste = !reserva.Asiste;
            }
        }
    }
}
