package es.intermodular.app_04_03.data

import androidx.lifecycle.LiveData
import es.intermodular.app_04_03.data.database.CriticaDao
import es.intermodular.app_04_03.data.database.PeliculaDao
import es.intermodular.app_04_03.model.Critica
import es.intermodular.app_04_03.model.Pelicula
import es.intermodular.app_04_03.model.PeliculaConCriticas

class PeliculaRepository(private val peliculaDao: PeliculaDao, private val criticaDao: CriticaDao) {
    fun get(): LiveData<List<Pelicula>> = peliculaDao.getPeliculas()
    fun getFavoritas(): LiveData<List<Pelicula>> = peliculaDao.getFavoritas()

    suspend fun insertar(pelicula: Pelicula) {
        peliculaDao.insert(pelicula)
    }

    suspend fun delete(pelicula: Pelicula){
        peliculaDao.deleteById(pelicula.id)
    }

    suspend fun cambiarFavorita(peliculaId: Long){
        peliculaDao.cambiarFavorita(peliculaId)
    }

    fun getCriticas(peliculaId: Long): LiveData<List<Critica>>
    {
        return criticaDao.getCriticas(peliculaId)
    }
    suspend fun insertar(pelicula: PeliculaConCriticas) {
        peliculaDao.insert(pelicula.pelicula)
        criticaDao.insertCriticas(pelicula.criticas)
    }

}