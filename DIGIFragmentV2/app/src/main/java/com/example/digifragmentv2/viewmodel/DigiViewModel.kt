package com.example.digifragmentv2.viewmodel

import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import com.example.digifragmentv2.model.Digi
import com.example.digifragmentv2.model.DigiRepository
import kotlinx.coroutines.launch

class DigiViewModel : ViewModel() {
    val digiLiveData = MutableLiveData<Digi>()
    private val repository = DigiRepository()

    fun cargarDatos() {
        viewModelScope.launch {
            digiLiveData.postValue(repository.get())
        }
    }

    fun buscarDigimon(param: String) {
        repository.setParam(param)
        cargarDatos()
    }

    fun cambiarNombre(){
        digiLiveData.value!!.name = "Antonio"
        digiLiveData.value = digiLiveData.value
    }
}