using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoocanV2
{
    public class Herramientas
    {
        private ZoocanBD contexto;
        public Herramientas()
        {
            this.contexto = new ZoocanBD();
        }
        public Herramientas(ZoocanBD contexto)
        {
            this.contexto = contexto;
        }


        public ZoocanBD Object { get; }

        /// <summary>
        /// Gestión de Refugios.
        /// </summary>
        /// <returns></returns>
        #region
        //
        // Obtiene una lista de todos los refugios.
        //

        public List<Refugio> ObtenerRefugios()
        {
            ZoocanBD db = this.contexto;
            return db.Refugios.ToList();
        }

        //
        // Obtiene un cuidador concreto a través de su id pasado como parámetro.
        //
        public Refugio ObtenerRefugioPorId(int refugioId)
        {
            ZoocanBD db = this.contexto;
            return db.Refugios.FirstOrDefault(x => x.RefugioId == refugioId);
        }

        //
        // Obtiene el primer cuidador con el mismo nombre que el dato pasado como parámetro.
        //
        public Refugio ObtenerRefugioPorNombre(string nombre)
        {
            ZoocanBD db = this.contexto;
            return db.Refugios.FirstOrDefault(x => x.Nombre.Equals(nombre));
        }

        //
        // Obtiene la especie animal del refugio con el id pasado por parámetro.
        //
        public string ObtenerEspecieDeRefugioPorId(int id)
        {
            ZoocanBD db = this.contexto;
            return db.Refugios.FirstOrDefault(x => x.RefugioId.Equals(id)).Especie;
        }

        //
        // Obtiene la especie animal del refugio con el nombre pasado por parámetro
        //
        public string ObtenerEspecieDeRefugioPorNombre(string nombre)
        {
            ZoocanBD db = this.contexto;
            return db.Refugios.FirstOrDefault(x => x.Nombre.Equals(nombre)).Especie;
        }

        //
        // Obtener numero de Cuidadores del refugio
        //
        public int ObtenerNumeroCuidadores(int id)
        {
            ZoocanBD db = this.contexto;
            return db.Cuidadores.Where(x => x.RefugioId == id).Count();
        }

        //
        // Obtener numero de animales del refugio recogido por id
        //
        public int ObtenerNumeroAnimalesPorId(int id)
        {
            ZoocanBD db = this.contexto;
            return db.Animales.Where(x => x.RefugioId == id).Count();
        }

        //
        // Obtener numero de animales del refugio recogido por nombre
        //
        public int ObtenerNumeroAnimalesPorNombre(string nombre)
        {
            ZoocanBD db = this.contexto;
            return db.Animales.Where(x => x.Nombre.Equals(nombre)).Count();
        }

        //
        // Crea un cuidador en la base de datos que se manda por parámetro.
        //
        public void CrearRefugio(Refugio refugiocreado)
        {
            ZoocanBD db = this.contexto;
            if (refugiocreado == null)
            {
                throw new ZoocanException("No se puede actualizar un refugio nulo.");
            }

            db.Refugios.Add(refugiocreado);
            db.SaveChanges();
        }

        //
        // Borra el cuidador de la base de datos que tenga el mismo id que el parámetro pasado.
        //
        public void BorrarRefugio(int refugioId)
        {
            ZoocanBD db = this.contexto;
            Refugio refugioborrado = db.Refugios.FirstOrDefault(x => x.RefugioId == refugioId);

            if (refugioborrado == null)
            {
                throw new ZoocanException("No se pudo borrar el refugio.");
            }
            if (ObtenerNumeroAnimalesPorId(refugioId) > 0)
            {
                throw new ZoocanException("No se puede borrar un refugio que tiene animales.");
            }
            if (ObtenerCuidadoresPorRefugio(refugioId).Count > 0)
            {
                throw new ZoocanException("No se puede borrar un refugio que tiene Cuidadores.");
            }

            db.Refugios.Remove(refugioborrado);
            db.SaveChanges();
        }

        //
        // Actualiza el cuidador de la base de datos con los datos del cuidador pasado por parámetro.
        //
        public void ActualizarRefugio(Refugio refugioactualizado)
        {
            ZoocanBD db = this.contexto;
            if (refugioactualizado == null)
            {
                throw new ZoocanException("No se puede actualizar un refugio nulo.");
            }
            if (!ObtenerEspecieDeRefugioPorId(refugioactualizado.RefugioId).Equals(refugioactualizado.Especie))
            {
                throw new ZoocanException("No se puede cambiar la especie de un refugio si ya hay animales de dicha especie dentro.");
            }
            if (ObtenerNumeroAnimalesPorId(refugioactualizado.RefugioId) >= refugioactualizado.MaxAnimales)
            {
                throw new ZoocanException("No se puede poner más animales de los que hay ya en el refugio.");
            }

            //db.Entry(db.Refugios.FirstOrDefault(x => x.RefugioId == refugioactualizado.RefugioId)).CurrentValues.SetValues(refugioactualizado);

            Refugio refugio = db.Refugios.FirstOrDefault(x => x.RefugioId == refugioactualizado.RefugioId);

            refugio.RefugioId = refugioactualizado.RefugioId;
            refugio.Nombre = refugioactualizado.Nombre;
            refugio.Direccion = refugioactualizado.Direccion;
            refugio.Especie = refugioactualizado.Especie;
            refugio.Telefono = refugioactualizado.Telefono;
            refugio.MaxAnimales = refugioactualizado.MaxAnimales;

            db.SaveChanges();
        }
        #endregion

        /// <summary>
        /// Gestión de Cuidadores.
        /// </summary>
        /// <returns></returns>
        #region
        //
        // Obtiene una lista de todos los Cuidadores.
        //
        public List<Cuidador> ObtenerCuidadores()
        {
            ZoocanBD db = this.contexto;
            return db.Cuidadores.ToList();
        }


        //
        // Obtiene una lista de todos los Cuidadores asignados a un cuidador por un id pasado como parámetro.
        //
        public List<Cuidador> ObtenerCuidadoresPorRefugio(int refugioId)
        {
            ZoocanBD db = this.contexto;
            return db.Cuidadores.Where(x => x.RefugioId == refugioId).ToList();
        }

        //
        // Obtiene un cuidador concreto a través de su id pasado como parámetro.
        //
        public Cuidador ObtenerCuidadorPorId(int CuidadorId)
        {
            ZoocanBD db = this.contexto;
            return db.Cuidadores.FirstOrDefault(x => x.CuidadorId == CuidadorId);
        }

        //
        // Obtiene un cuidador concreto a través de su nombre pasado como parámetro.
        //
        public Cuidador ObtenerCuidadorPorNombre(string nombre)
        {
            ZoocanBD db = this.contexto;
            return db.Cuidadores.FirstOrDefault(x => x.Nombre == nombre);
        }

        //
        // Obtiene un cuidador responsable concreto a través de su id pasado como parámetro.
        //
        public Cuidador ObtenerCuidadorResponsablePorRefugioId(int id)
        {
            ZoocanBD db = this.contexto;
            return db.Cuidadores.FirstOrDefault(x => x.RefugioId == id);
        }

        //
        // Crea un cuidador en la base de datos que se manda por parámetro.
        //
        public void CrearCuidador(Cuidador Cuidadorcreado)
        {
            ZoocanBD db = this.contexto;

            if (Cuidadorcreado == null)
            {
                throw new ZoocanException("No puedes crear un cuidador nulo.");
            }
            if (Cuidadorcreado.Responsable && ObtenerCuidadorResponsablePorRefugioId(Cuidadorcreado.RefugioId) != null)
            {
                throw new ZoocanException("No puedes asignar otro responsable al refugio.");
            }

            if (!ObtenerEspecieDeRefugioPorId(Cuidadorcreado.RefugioId).Equals(Cuidadorcreado.Especie))
            {
                throw new ZoocanException("No puedes contratar un cuidador que no esté especializado en la misma especie.");
            }

            db.Cuidadores.Add(Cuidadorcreado);
            db.SaveChanges();
        }

        //
        // Actualiza el cuidador de la base de datos con los datos del cuidador pasado por parámetro.
        //
        public void BorrarCuidador(int CuidadorId)
        {
            ZoocanBD db = this.contexto;
            Cuidador Cuidadorborrado = db.Cuidadores.FirstOrDefault(x => x.CuidadorId == CuidadorId);

            if (Cuidadorborrado != null)
            {
                db.Cuidadores.Remove(Cuidadorborrado);
                db.SaveChanges();
            }
        }

        //
        // Actualiza el cuidador de la base de datos con los datos del cuidador pasado por parámetro.
        //
        public void ActualizarCuidador(Cuidador Cuidadoractualizado)
        {
            ZoocanBD db = this.contexto;

            if (Cuidadoractualizado == null)
            {
                throw new ZoocanException("No puedes crear un cuidador nulo.");
            }
            if (Cuidadoractualizado.Responsable && ObtenerCuidadorResponsablePorRefugioId(Cuidadoractualizado.RefugioId) != null)
            {
                throw new ZoocanException("No puedes asignar otro responsable al refugio.");
            }

            if (!ObtenerEspecieDeRefugioPorId(Cuidadoractualizado.RefugioId).Equals(Cuidadoractualizado.Especie))
            {
                throw new ZoocanException("No puedes contratar un cuidador que no esté especializado en la misma especie.");
            }

            //db.Entry(db.Cuidadores.FirstOrDefault(x => x.CuidadorId == Cuidadoractualizado.CuidadorId)).CurrentValues.SetValues(Cuidadoractualizado);

            Cuidador cuidador = db.Cuidadores.FirstOrDefault(x => x.CuidadorId == Cuidadoractualizado.CuidadorId);
            cuidador.CuidadorId = Cuidadoractualizado.CuidadorId;
            cuidador.RefugioId = Cuidadoractualizado.RefugioId;
            cuidador.Nombre = Cuidadoractualizado.Nombre;
            cuidador.Telefono = Cuidadoractualizado.Telefono;
            cuidador.Direccion = Cuidadoractualizado.Direccion;
            cuidador.SalarioAnual = Cuidadoractualizado.SalarioAnual;
            cuidador.Especie = Cuidadoractualizado.Especie;
            cuidador.Responsable = Cuidadoractualizado.Responsable;

            db.SaveChanges();
        }
        #endregion

        /// <summary>
        /// Gestion de Animales.
        /// </summary>
        /// <returns></returns>
        #region

        //
        // Obtiene una lista de todos los animales.
        //
        public List<Animal> ObtenerAnimales()
        {
            ZoocanBD db = this.contexto;
            return db.Animales.ToList();
        }

        //
        // Obtiene una lista de todos los animales asignados a un cuidador por un id pasado como parámetro.
        //
        public List<Animal> ObtenerAnimalesPorRefugio(int refugioId)
        {
            ZoocanBD db = this.contexto;
            return db.Animales.Where(x => x.RefugioId == refugioId).ToList();
        }

        //
        // Obtiene un animal concreto a través de su id pasado como parámetro.
        //
        public Animal ObtenerAnimale(int animaleId)
        {
            ZoocanBD db = this.contexto;
            return db.Animales.FirstOrDefault(x => x.AnimalId == animaleId);
        }

        //
        // Crea un animal en la base de datos que se manda por parámetro.
        //
        public void CrearAnimale(Animal animalecreado)
        {
            ZoocanBD db = this.contexto;
            if (animalecreado == null)
            {
                throw new ZoocanException("No se puede crear un animal nulo.");
            }
            if (!ObtenerEspecieDeRefugioPorId(animalecreado.RefugioId).Equals(animalecreado.Especie))
            {
                throw new ZoocanException("No se puede meter un animal de una especie distinta a la especialidad del refugio.");
            }
            if (animalecreado.Nacimiento != null && DateTime.Compare((DateTime)animalecreado.Nacimiento, animalecreado.Entrada) >= 0)
            {
                throw new ZoocanException("No se puede crear un animal que nace después de entrar al refugio.");
            }
            if (ObtenerAnimalesPorRefugio(animalecreado.RefugioId).Count() >= ObtenerRefugioPorId(animalecreado.RefugioId).MaxAnimales)
            {
                throw new ZoocanException("No se puede crear un animal más en este refugio.");
            }

            db.Animales.Add(animalecreado);
            db.SaveChanges();
        }

        //
        // Borra el animal de la base de datos que tenga el mismo id que el parámetro pasado.
        //
        public void BorrarAnimale(int animaleId)
        {
            ZoocanBD db = this.contexto;
            Animal animalborrado = db.Animales.FirstOrDefault(x => x.AnimalId == animaleId);

            if (animalborrado == null)
            {
                throw new ZoocanException("No se puede crear un animal nulo");
            }

            db.Animales.Remove(animalborrado);
            db.SaveChanges();
        }

        //
        // Actualiza el animal de la base de datos con los datos del animal pasado por parámetro.
        //
        public void ActualizarAnimale(Animal animalactualizado)
        {
            ZoocanBD db = this.contexto;

            if (animalactualizado == null)
            {
                throw new ZoocanException("No se puede crear un animal nulo");
            }
            if (animalactualizado.Nacimiento != null && DateTime.Compare((DateTime)animalactualizado.Nacimiento, animalactualizado.Entrada) >= 0)
            {
                throw new ZoocanException("No se puede crear un animal que nace después de entrar al refugio.");
            }
            if (ObtenerAnimalesPorRefugio(animalactualizado.RefugioId).Count() >= ObtenerRefugioPorId(animalactualizado.RefugioId).MaxAnimales)
            {
                throw new ZoocanException("No se puede crear un animal más en este refugio.");
            }
            if (!ObtenerEspecieDeRefugioPorId(animalactualizado.RefugioId).Equals(animalactualizado.Especie))
            {
                throw new ZoocanException("No se puede meter un animal de una especie distinta a la especialidad del refugio");
            }

            //db.Entry(db.Animales.FirstOrDefault(x => x.AnimalId == animalactualizado.AnimalId)).CurrentValues.SetValues(animalactualizado);
            
            Animal animal = db.Animales.FirstOrDefault(x => x.AnimalId == animalactualizado.AnimalId);

            animal.AnimalId = animalactualizado.AnimalId;
            animal.RefugioId = animalactualizado.RefugioId;
            animal.Nacimiento = animalactualizado.Nacimiento;
            animal.Entrada = animalactualizado.Entrada;
            animal.Especie = animalactualizado.Especie;
            animal.Raza = animalactualizado.Raza;
            animal.Peso = animalactualizado.Peso;
            animal.EspacioMin = animalactualizado.EspacioMin;
            
            db.SaveChanges();
        }
        #endregion
    }
}
