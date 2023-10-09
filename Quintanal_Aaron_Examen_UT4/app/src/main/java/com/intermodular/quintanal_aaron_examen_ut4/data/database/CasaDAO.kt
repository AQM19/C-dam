package com.intermodular.quintanal_aaron_examen_ut4.data.database

import androidx.lifecycle.LiveData
import androidx.room.Dao
import androidx.room.Delete
import androidx.room.Query
import androidx.room.Transaction
import com.intermodular.quintanal_aaron_examen_ut4.model.Casa
import com.intermodular.quintanal_aaron_examen_ut4.model.Personaje

@Dao
interface CasaDAO {
    @Query("SELECT * FROM casas ORDER BY nombre ASC")
    fun getCasas(): LiveData<List<Casa>>

    @Transaction
    @Query("SELECT * FROM personajes p INNER JOIN casas_personajes cp ON p.personajeId = cp.personajeId WHERE cp.casaId = :casaId")
    fun getPersonajesCasa(casaId: Long): LiveData<List<Personaje>>

    @Query("DELETE FROM casas_personajes WHERE casaId = :casaId")
    suspend fun borrarCasaPersonajes(casaId: Long)

    @Delete
    suspend fun borrarCasa(casa:Casa)

    @Query("SELECT * FROM personajes p WHERE p.estado = 'Vivo' OR p.estado = 'Viva' ORDER BY p.nombre ASC")
    fun getPersonajesVivos(): LiveData<List<Personaje>>

    @Query("UPDATE personajes SET estado = 'Muerto' WHERE personajeId = :personajeId")
    suspend fun hacerseUnRRMartin(personajeId: Long)
}