package com.intermodular.quintanal_aaron_examen_ut4.data

import androidx.lifecycle.LiveData
import com.intermodular.quintanal_aaron_examen_ut4.data.database.CasaDAO
import com.intermodular.quintanal_aaron_examen_ut4.model.Casa
import com.intermodular.quintanal_aaron_examen_ut4.model.Personaje

class DataRepository(private val casaDAO: CasaDAO) {
    fun getCasas(): LiveData<List<Casa>> = casaDAO.getCasas()
    fun getPersonajesCasa(casaId: Long): LiveData<List<Personaje>> = casaDAO.getPersonajesCasa(casaId)
    fun getPersonajesVivos(): LiveData<List<Personaje>> = casaDAO.getPersonajesVivos()

    suspend fun borrarCasaPersonajes(casaId: Long){
        casaDAO.borrarCasaPersonajes(casaId)
    }

    suspend fun borrarCasa(casa: Casa){
        casaDAO.borrarCasa(casa)
    }

    suspend fun hacerseUnRRMartin(personajeId: Long){
        casaDAO.hacerseUnRRMartin(personajeId)
    }
}