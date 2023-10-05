using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UT2E9_SergioGonzalezVelez
{
    public class Negocio
    {
        public List<Pelicula> ObtenerPeliculas()
        {
            NegocioDatabase negociodatabase = new NegocioDatabase();
            return negociodatabase.Peliculas.ToList();
        }
        public void CrearPelicula(Pelicula nuevaPelicula)
        {
                NegocioDatabase negociodatabase = new NegocioDatabase();
                //nuevaPelicula.PeliculaId = -1;
                negociodatabase.Peliculas.Add(nuevaPelicula);
                negociodatabase.SaveChanges();
        }
        public Pelicula ObtenerPelicula(int peliculaId)
        {
            NegocioDatabase negociodatabase = new NegocioDatabase();
            return negociodatabase.Peliculas.Where(x => x.PeliculaId.Equals(peliculaId)).FirstOrDefault();
        }
        public void BorrarPelicula(int peliculaId)
        {
            NegocioDatabase negociodatabase = new NegocioDatabase();
            Pelicula peliculaborrada = negociodatabase.Peliculas.Where( x => x.PeliculaId.Equals(peliculaId)).FirstOrDefault();
            if(peliculaborrada != null)
            {
                negociodatabase.Peliculas.Remove(peliculaborrada);
                negociodatabase.SaveChanges();
            }
        }
        public void ActualizarPelicula(Pelicula peliculaactualizada)
        {
            NegocioDatabase negociodatabase = new NegocioDatabase();
            negociodatabase.Entry(negociodatabase.Peliculas.
                Where(x => x.PeliculaId == peliculaactualizada.PeliculaId).First())
                .CurrentValues.SetValues(peliculaactualizada);
            negociodatabase.SaveChanges();
        }
        public List<Libro> ObtenerLibros()
        {
            NegocioDatabase negociodatabase = new NegocioDatabase();
            return negociodatabase.Libros.ToList();
        }
        public void CrearLibro(Libro nuevoLibro)
        {
            if(nuevoLibro != null)
            {
                NegocioDatabase negociodatabase = new NegocioDatabase();
                negociodatabase.Libros.Add(nuevoLibro);
                negociodatabase.SaveChanges();
            }
        }
        public Libro ObtenerLibro(int libroId)
        {
            NegocioDatabase negociodatabase = new NegocioDatabase();
            return negociodatabase.Libros.Where(x => x.LibroId.Equals(libroId)).FirstOrDefault();
        }
        public void BorrarLibro(int libroId)
        {
            NegocioDatabase negociodatabase = new NegocioDatabase();
            Libro libroborrado = negociodatabase.Libros.Where( x => x.LibroId.Equals(libroId)).FirstOrDefault();
            if(libroborrado != null)
            {
                negociodatabase.Libros.Remove(libroborrado);
                negociodatabase.SaveChanges();
            }
        }
        public void ActualizarLibro(Libro libroactualizado)
        {
            NegocioDatabase negociodatabase = new NegocioDatabase();
            negociodatabase.Entry(negociodatabase.Libros.
                Where(x => x.LibroId == libroactualizado.LibroId).First())
                .CurrentValues.SetValues(libroactualizado);
            negociodatabase.SaveChanges();
        }
    }
}

