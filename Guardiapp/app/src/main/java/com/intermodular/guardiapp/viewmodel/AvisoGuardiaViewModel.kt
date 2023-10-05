package com.intermodular.guardiapp.viewmodel

import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import com.intermodular.guardiapp.model.AvisoGuardia
import com.intermodular.guardiapp.model.Horario
import com.intermodular.guardiapp.model.IntermodularRepository
import com.intermodular.guardiapp.model.Profesor
import java.sql.Time
import java.time.LocalDate
import java.time.LocalDateTime
import java.util.*

class AvisoGuardiaViewModel: ViewModel() {

    private val _profesor = MutableLiveData<Profesor>()
    private val _horario = MutableLiveData<List<Horario>>()
    private val _motivo = MutableLiveData<String>()
    private val _observaciones = MutableLiveData<String>()
    private val _confirmado = MutableLiveData<Boolean>()
    private val _anulado = MutableLiveData<Boolean>()
    private val _fecha_aviso = MutableLiveData<String>()
    private val _hora_aviso = MutableLiveData<String>()
    private val repository = IntermodularRepository()

    val profesor: LiveData<Profesor> = _profesor
    val horario: LiveData<List<Horario>> = _horario
    val motivo: LiveData<String> = _motivo
    val observaciones: LiveData<String> = _observaciones
    val confirmado: LiveData<Boolean> = _confirmado
    val anulado: LiveData<Boolean> = _anulado
    val fechaAviso: LiveData<String> = _fecha_aviso
    val horaAviso: LiveData<String> = _hora_aviso

    fun setProfesor(param: Profesor){
        _profesor.value = param
    }
    fun setHorario(param: List<Horario>){
        _horario.value = param
    }
    fun setMotivo(param: String){
        _motivo.value = param
    }
    fun setObservaciones(param: String){
        _observaciones.value = param
    }
    fun setConfirmado(param: Boolean){
        _confirmado.value = param
    }
    fun setAnulado(param: Boolean){
        _anulado.value = param
    }
    fun setFechaAviso(param: String){
        _fecha_aviso.value = param
    }
    fun setHoraAviso(param: String){
        _hora_aviso.value = param
    }
    suspend fun crearAviso(avisoGuardia: AvisoGuardia): AvisoGuardia? = repository.crearAviso(avisoGuardia)
    suspend fun setAvisoConfirmado(id: Int, aviso: AvisoGuardia): AvisoGuardia? = repository.setAvisoConfirmado(id, aviso)
    suspend fun setAvisoAnulado(id: Int, aviso: AvisoGuardia): AvisoGuardia? = repository.setAvisoConfirmado(id, aviso)
}