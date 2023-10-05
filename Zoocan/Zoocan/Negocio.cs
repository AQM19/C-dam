using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Zoocan
{
    public class Negocio // importante hacerlo publico
    {
        // CRUD Animales
        public List<Animale> ObtenerAnimales()
        {
            ZoocanDB db = new ZoocanDB();
            return db.Animales.ToList();
        }

        public Animale ObtenerAnimale(int animaleId)
        {
            ZoocanDB db = new ZoocanDB();
            return db.Animales.Where(x => x.AnimalId == animaleId).FirstOrDefault();
        }

        public void CrearAnimale(Animale animalecreado)
        {
            ZoocanDB db = new ZoocanDB();
            if(animalecreado != null)
            {
                db.Animales.Add(animalecreado);
                db.SaveChanges();
            }
        }

        public void BorrarAnimale(int animaleId)
        {
            ZoocanDB db = new ZoocanDB();
            Animale animalborrado = db.Animales.Where(x => x.AnimalId == animaleId).FirstOrDefault();

            if(animalborrado != null)
            {
                db.Animales.Remove(animalborrado);
                db.SaveChanges();
            }
        }

        public void ActualizarAnimale(Animale animalactualizado)
        {
            ZoocanDB db = new ZoocanDB();
            db.Entry(db.Animales.
                Where(x => x.AnimalId == animalactualizado.AnimalId).First())
                .CurrentValues.SetValues(animalactualizado);
            db.SaveChanges();
        }

        // CRUD Refugios
        public List<Refugio> ObtenerRefugios()
        {
            ZoocanDB db = new ZoocanDB();
            return db.Refugios.ToList();
        }

        public Refugio ObtenerRefugio(int refugioId)
        {
            ZoocanDB db = new ZoocanDB();
            return db.Refugios.Where(x => x.RefugioId == refugioId).FirstOrDefault();
        }

        public void CrearRefugio(Refugio refugiocreado)
        {
            ZoocanDB db = new ZoocanDB();
            if (refugiocreado != null)
            {
                db.Refugios.Add(refugiocreado);
                db.SaveChanges();
            }
        }

        public void BorrarRefugio(int refugioId)
        {
            ZoocanDB db = new ZoocanDB();
            Refugio refugioborrado = db.Refugios.Where(x => x.RefugioId == refugioId).FirstOrDefault();

            if (refugioborrado != null)
            {
                db.Refugios.Remove(refugioborrado);
                db.SaveChanges();
            }
        }

        public void ActualizarRefugio(Refugio refugioactualizado)
        {
            ZoocanDB db = new ZoocanDB();
            db.Entry(db.Refugios.
                Where(x => x.RefugioId == refugioactualizado.RefugioId).First())
                .CurrentValues.SetValues(refugioactualizado);
            db.SaveChanges();
        }

        // CRUD Cuidadores
        public List<Cuidadore> ObtenerCuidadores()
        {
            ZoocanDB db = new ZoocanDB();
            return db.Cuidadores.ToList();
        }

        public Cuidadore ObtenerCuidadorePorId(int cuidadoreId)
        {
            ZoocanDB db = new ZoocanDB();
            return db.Cuidadores.Where(x => x.CuidadorId == cuidadoreId).FirstOrDefault();
        }

        public Cuidadore ObtenerCuidadorePorNombre(string nombre)
        {
            ZoocanDB db = new ZoocanDB();
            return db.Cuidadores.Where(x => x.Nombre == nombre).FirstOrDefault();
        }

        public Cuidadore ObtenerCuidadoreResponsable(int id)
        {
            ZoocanDB db = new ZoocanDB();
            return db.Cuidadores.Where(x => x.RefugioId == id).FirstOrDefault();
        }

        public void CrearCuidadore(Cuidadore cuidadorecreado)
        {
            ZoocanDB db = new ZoocanDB();
            if (cuidadorecreado != null)
            {
                db.Cuidadores.Add(cuidadorecreado);
                db.SaveChanges();
            }
        }

        public void BorrarCuidadore(int cuidadoreId)
        {
            ZoocanDB db = new ZoocanDB();
            Cuidadore cuidadoreborrado = db.Cuidadores.Where(x => x.CuidadorId == cuidadoreId).FirstOrDefault();

            if (cuidadoreborrado != null)
            {
                db.Cuidadores.Remove(cuidadoreborrado);
                db.SaveChanges();
            }
        }

        public void ActualizarCuidadore(Cuidadore cuidadoreactualizado)
        {
            ZoocanDB db = new ZoocanDB();
            db.Entry(db.Cuidadores.
                Where(x => x.CuidadorId == cuidadoreactualizado.CuidadorId).First())
                .CurrentValues.SetValues(cuidadoreactualizado);
            db.SaveChanges();
        }
    }
}
