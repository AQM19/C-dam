package com.intermodular.quintanal_aaron_examen_ut4.viewmodel

import android.content.Context
import androidx.lifecycle.LiveData
import androidx.lifecycle.ViewModel
import androidx.lifecycle.ViewModelProvider
import androidx.lifecycle.viewModelScope
import androidx.lifecycle.viewmodel.initializer
import androidx.lifecycle.viewmodel.viewModelFactory
import com.intermodular.quintanal_aaron_examen_ut4.data.DataRepository
import com.intermodular.quintanal_aaron_examen_ut4.model.EntitiesDatabase
import com.intermodular.quintanal_aaron_examen_ut4.model.Casa
import com.intermodular.quintanal_aaron_examen_ut4.model.Personaje
import kotlinx.coroutines.launch

class JuegoTronosViewModel(context: Context): ViewModel()
{
    private val repository: DataRepository
    val casas: LiveData<List<Casa>>
    val personajesVivos: LiveData<List<Personaje>>

    init {
        val casaDAO = EntitiesDatabase.getDatabase(context).CasaDAO()
        repository = DataRepository(casaDAO)
        casas = repository.getCasas()
        personajesVivos = repository.getPersonajesVivos()
    }

    fun getPersonajesCasa(casaId: Long): LiveData<List<Personaje>>{
        return repository.getPersonajesCasa(casaId)
    }

    fun borrarCasaPersonajes(casaId: Long){
        viewModelScope.launch {
            repository.borrarCasaPersonajes(casaId)
        }
    }

    fun borrarCasa(casa: Casa){
        viewModelScope.launch {
            repository.borrarCasa(casa)
        }
    }

    fun hacerseUnRRMartin(personajeId: Long){
        viewModelScope.launch {
            repository.hacerseUnRRMartin(personajeId)
        }
    }


    companion object {
        val Factory: ViewModelProvider.Factory = viewModelFactory {
            initializer {
                val contexto = (this[ViewModelProvider.AndroidViewModelFactory.APPLICATION_KEY] as Context)
                JuegoTronosViewModel(
                    context = contexto
                )
            }
        }
    }

}