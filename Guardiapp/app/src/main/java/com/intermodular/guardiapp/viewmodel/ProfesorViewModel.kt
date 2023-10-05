package com.intermodular.guardiapp.viewmodel

import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import com.intermodular.guardiapp.model.*
import kotlinx.coroutines.launch
import retrofit2.HttpException

class ProfesorViewModel : ViewModel()
{
    val profesorLiveData = MutableLiveData<Profesor?>()
    val guardiasLiveData = MutableLiveData<List<Guardia>>()
    val horariosLiveData = MutableLiveData<List<Horario>>()
    val avisosLiveData = MutableLiveData<List<AvisoGuardia>>()
    private val repository = IntermodularRepository()
    fun cargarGuardias(){

        viewModelScope.launch {
            guardiasLiveData.postValue(repository.getGuardias())
        }
    }
    fun guardarProfe(profesor: Profesor) = profesorLiveData.postValue(profesor)
    suspend fun cargarProfe(user: String, password: String) = repository.getProfesor(user,password)
    suspend fun getProfeFalta(id: Int): Profesor? = repository.getProfeFalta(id)
    suspend fun setGuardiaConfirmada(id: Int, guardia: Guardia) {
        repository.setGuardiaConfirmada(id, guardia)
        cargarGuardias()
    }
    fun getHorarioProfesor(id: Int){
        viewModelScope.launch {
            horariosLiveData.postValue(repository.getHorarioProfesor(id))
        }
    }
    fun getAvisos(id: Int){
        viewModelScope.launch {
            avisosLiveData.postValue(repository.getAviso(id))
        }
    }
}