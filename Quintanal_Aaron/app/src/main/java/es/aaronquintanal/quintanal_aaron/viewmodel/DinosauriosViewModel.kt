package es.aaronquintanal.quintanal_aaron.viewmodel

import androidx.lifecycle.*
import es.aaronquintanal.quintanal_aaron.model.Dino
import es.aaronquintanal.quintanal_aaron.model.DinoRepository
import kotlinx.coroutines.launch

class DinosauriosViewModel : ViewModel() {
    val dinoLiveData = MutableLiveData<MutableList<Dino>>()
    private val repository = DinoRepository()

    init {
        cargarDatos()
    }

    fun cargarDatos(){
        viewModelScope.launch {
            val datos = repository.get()
            datos.sortByDescending { it.dimensiones.peso }
            dinoLiveData.postValue(datos)
        }
    }

    fun borrarDino(nombre:String){
        dinoLiveData.value!!.removeAll{ it.nombre == nombre }
    }

    fun getYacimientos() : List<String>{
        val yacimientos = mutableSetOf<String>()
        dinoLiveData.value!!.forEach{
            yacimientos.addAll(it.yacimientos)
        }
        return yacimientos.sorted()
    }

    fun dinosariosDeYacimiento(yacimiento: String): LiveData<List<Dino>>{
        return dinoLiveData.map {
            it.filter { it.yacimientos.contains(yacimiento) }.sortedBy { it.nombre }
        }
    }
}
