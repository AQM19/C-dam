package es.aaronquintanal.app_ut3_02.viewmodel

import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import es.aaronquintanal.app_ut3_02.model.Centro
import es.aaronquintanal.app_ut3_02.model.CentroRepository
import kotlinx.coroutines.launch

class CentrosViewModel : ViewModel()
{
    val centrosLiveData = MutableLiveData<List<Centro>>()
    private val repository = CentroRepository()

    fun CargarDatos(){
        viewModelScope.launch{
            centrosLiveData.postValue(repository.get())
        }
    }
}