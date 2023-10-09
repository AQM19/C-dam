package com.example.digifragment.viewmodel

import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import com.example.digifragment.model.Digi
import com.example.digifragment.model.DigiRepository
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
}