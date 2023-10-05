using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_Nuget_ORM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InsertarDatos();
            //SeleccionarDatos();
            BorrarDatos();
            //ActualizarDatos();

            Console.WriteLine("Intro para salir.");
            Console.ReadLine();
        }

        public static void InsertarDatos()
        {
            demoBD bd = new demoBD();

            Cliente nuevoCliente = new Cliente() 
            { 
                Nombre = "Juan",
                ClienteId = -1
            };

            bd.Clientes.Add(nuevoCliente);

            Gasto nuevoGasto = new Gasto()
            {
                ClienteId = -1,
                Fecha = new DateTime(2020, 12, 1),
                Importe = 50.50
            };

            Gasto nuevoGasto2 = new Gasto()
            {
                ClienteId = -1,
                Fecha = new DateTime(2020, 12, 5),
                Importe = 50.75
            };

            bd.Gastos.Add(nuevoGasto);
            bd.Gastos.Add(nuevoGasto2);
            // Ahora esta todo en la RAM, no hay datos cambiados en la base de datos

            bd.SaveChanges(); // Inicia una transacción, si hay un error no mete nada. Todo o nada.
        }

        public static void SeleccionarDatos()
        {
            demoBD bd = new demoBD();

            List<Gasto> resultado = bd.Gastos.Where( x => x.Importe >= 40 ).ToList();

            foreach(Gasto gasto in resultado)
            {
                Console.WriteLine(gasto.Importe + " " + gasto.Fecha.ToShortDateString());
            }

            Cliente cliente = bd.Clientes.FirstOrDefault(x => x.Nombre == "Juan");
            if(cliente != null)
            {
                Console.WriteLine($"Cliente {cliente.Nombre}, con id {cliente.ClienteId}");
            } else
            {
                Console.WriteLine("Cliente no encontrado.");
            }
        }

        public static void BorrarDatos()
        {
            demoBD bd = new demoBD();

            List<Gasto> result = bd.Gastos.Where(x => x.Importe >= 40).ToList();

            bd.Gastos.RemoveRange(result);
            bd.SaveChanges();
        }

        public static void ActualizarDatos()
        {
            demoBD bd = new demoBD();

            Cliente cliente = bd.Clientes.FirstOrDefault(x => x.ClienteId == 3);

            if(cliente != null)
            {
                cliente.Nombre = "Antonio";
                bd.SaveChanges();
            }
        }
    }
    // static, generarId, antes de constructos desaparece
    // cada metodo instancia base de datos
}
