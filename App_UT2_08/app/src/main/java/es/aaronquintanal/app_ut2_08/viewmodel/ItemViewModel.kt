package es.aaronquintanal.app_ut2_08.viewmodel

import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import com.example.app_ut2_08.Producto
import es.aaronquintanal.app_ut2_08.model.data.Datos

class ItemViewModel : ViewModel(){

    private val _listaCategorias = MutableLiveData<List<String>>()
    private val _listaItems = MutableLiveData<List<Producto>>()
    private val _listaCompra = MutableLiveData<List<Producto>>()

    val listaCategorias = _listaCategorias
    val listaItems = _listaItems
    val listaCompra = _listaCompra

    fun cargarCategorias(){
        _listaCategorias.postValue(Datos.nombresCategorias())
    }

    fun cargarItems(categoria: String){
        _listaItems.postValue(Datos.getProductosCategorias(categoria))
    }

    fun insertarCesta(producto: Producto){
        _listaCompra.value = _listaCompra.value?.plus(producto) ?: listOf(producto)
    }

}