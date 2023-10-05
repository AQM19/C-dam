package es.aaronquintanal.digiactivity.viewmodel

import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import es.aaronquintanal.digiactivity.model.Digi
import es.aaronquintanal.digiactivity.model.DigiRepository
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