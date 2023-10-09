package es.sergiogonzalezvelez.app_03_api.viewmodel

import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import es.sergiogonzalezvelez.app_03_api.SingleLiveEvent
import es.sergiogonzalezvelez.app_03_api.model.Pokemon
import es.sergiogonzalezvelez.app_03_api.model.PokemonRepository
import es.sergiogonzalezvelez.app_03_api.model.ataque.Ataque
import es.sergiogonzalezvelez.app_03_api.model.habilidad.Habilidad
import kotlinx.coroutines.launch

class PokemonViewModel : ViewModel() {
    val pokeLiveData = MutableLiveData<Pokemon>()
    val ataqueLiveData = MutableLiveData<Ataque>()
    val habilidadLiveData = SingleLiveEvent<Habilidad>()
    private val repository = PokemonRepository()

    fun cargarDatos() {
        viewModelScope.launch {
            pokeLiveData.postValue(repository.getPoke())
        }
    }

    fun cargarAtaque(path: String) {
        viewModelScope.launch {
            ataqueLiveData.postValue(repository.getAtaque(path))
        }
    }

    fun cargarHabilidad(path: String) {
        viewModelScope.launch {
            habilidadLiveData.value = repository.getHabilidad(path)
        }
    }

    fun cargarNombre() {
        viewModelScope.launch {
            pokeLiveData.value!!.nombre = "Pepe"
            pokeLiveData.value = pokeLiveData.value
        }
    }

    fun datosSiguientes() {
        repository.next()
        cargarDatos()
    }

    fun datosAleatorios() {
        repository.rand()
        cargarDatos()
    }

    fun datosAnteriores() {
        repository.back()
        cargarDatos()
    }
}