package es.intermodular.app_04_03.data.database

import androidx.lifecycle.LiveData
import androidx.room.*
import es.intermodular.app_04_03.model.Pelicula

@Dao
interface PeliculaDao {
    @Query("SELECT * FROM peliculas WHERE favorita = 0")
    fun getPeliculas(): LiveData<List<Pelicula>>

    @Query("SELECT * FROM peliculas WHERE favorita = 1")
    fun getFavoritas(): LiveData<List<Pelicula>>

    @Insert(onConflict = OnConflictStrategy.REPLACE)
    suspend fun insert(pelicula: Pelicula)

    @Query("DELETE FROM peliculas WHERE id = :peliculaId")
    suspend fun deleteById(peliculaId: Long)

    @Query("UPDATE peliculas SET favorita = NOT favorita WHERE id = :peliculaId")
    suspend fun cambiarFavorita(peliculaId: Long)

}