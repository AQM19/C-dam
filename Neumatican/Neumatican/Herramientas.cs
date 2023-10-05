using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neumatican
{
    internal class Herramientas
    {
        // Clientes

        public List<Cliente> ObtenerClientes()
        {
            NeumaticosBD bd = new NeumaticosBD();
            return bd.Clientes.ToList();
        }

        public void CrearCliente(Cliente nuevocliente)
        {
            NeumaticosBD bd = new NeumaticosBD();
            bd.Clientes.Add(nuevocliente);
            bd.SaveChanges();
        }
        public Cliente ObtenerCliente(int clienteid)
        {
            NeumaticosBD bd = new NeumaticosBD();
            return bd.Clientes.Where(x => x.ClienteId.Equals(clienteid)).FirstOrDefault();
        }
        public void BorrarCliente(int clienteid)
        {
            NeumaticosBD bd = new NeumaticosBD();
            Cliente cliente = bd.Clientes.Where(x => x.ClienteId.Equals(clienteid)).FirstOrDefault();

            if(cliente != null)
            {
                bd.Clientes.Remove(cliente);
                bd.SaveChanges();
            }

        }
        public void ActualizarCliente(Cliente cliente)
        {
            NeumaticosBD bd = new NeumaticosBD();
            bd.Entry(bd.Clientes.Where(x => x.ClienteId == cliente.ClienteId).First()).CurrentValues.SetValues(cliente);
            bd.SaveChanges();
        }

        // Detalles
        // Facturas
        // Productos

    }
}
