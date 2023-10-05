package com.example.btells.viewmodel

import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import com.example.btells.model.Escarabajo
import com.example.btells.model.EscarabajosRepository
import kotlinx.coroutines.launch

class EscarabajosViewModel : ViewModel()
{
    val escarabajosLiveData = MutableLiveData<List<Escarabajo>>()
    private val repository = EscarabajosRepository()

    fun cargarDatos() {
        viewModelScope.launch {
            escarabajosLiveData.postValue(repository.get())
        }
    }
}