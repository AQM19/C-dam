package es.intermodular.app_04_03.data.database

import androidx.lifecycle.LiveData
import androidx.room.Dao
import androidx.room.Delete
import androidx.room.Insert
import androidx.room.OnConflictStrategy
import androidx.room.Query
import es.intermodular.app_04_03.model.Critica

@Dao
interface CriticaDao {
    @Insert(onConflict = OnConflictStrategy.REPLACE)
    suspend fun insertCriticas(criticas: List<Critica>)
    @Delete
    suspend fun delete(critica: Critica)
    @Query("SELECT * FROM criticas WHERE pelicula_id = :peliculaId")
    fun getCriticas(peliculaId: Long): LiveData<List<Critica>>
}