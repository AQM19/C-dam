package es.intermodular.app_04_03.viewmodel

import android.content.Context
import androidx.lifecycle.LiveData
import androidx.lifecycle.ViewModel
import androidx.lifecycle.ViewModelProvider
import androidx.lifecycle.ViewModelProvider.AndroidViewModelFactory.Companion.APPLICATION_KEY
import androidx.lifecycle.viewModelScope
import androidx.lifecycle.viewmodel.initializer
import androidx.lifecycle.viewmodel.viewModelFactory
import es.intermodular.app_04_03.data.PeliculaRepository
import es.intermodular.app_04_03.model.Critica
import es.intermodular.app_04_03.model.Pelicula
import es.intermodular.app_04_03.model.PeliculaConCriticas
import es.intermodular.app_04_03.model.PeliculaDatabase
import kotlinx.coroutines.launch

class PeliculasViewModel(context: Context): ViewModel()
{
    private val repositorio : PeliculaRepository
    val peliculas: LiveData<List<Pelicula>>
    val peliculasFavoritas: LiveData<List<Pelicula>>

    init
    {
        val peliculaDao = PeliculaDatabase.getDatabase(context).peliculaDao()
        val criticaDao = PeliculaDatabase.getDatabase(context).criticaDao()
        repositorio = PeliculaRepository(peliculaDao, criticaDao)
        peliculas = repositorio.get()
        peliculasFavoritas = repositorio.getFavoritas()
    }

    fun insertarPelicula(pelicula: Pelicula)
    {
        viewModelScope.launch {
            repositorio.insertar(pelicula)
        }
    }

    fun borrarPelicula(pelicula: Pelicula)
    {
        viewModelScope.launch {
            repositorio.delete(pelicula)
        }
    }

    fun cambiarFavorita(peliculaId: Long)
    {
        viewModelScope.launch {
            repositorio.cambiarFavorita(peliculaId)
        }
    }

    fun getCriticas(peliculaId: Long): LiveData<List<Critica>>
    {
        return repositorio.getCriticas(peliculaId)
    }
    fun insertarPeliculaConCriticas(pelicula: PeliculaConCriticas)
    {
        viewModelScope.launch {
            repositorio.insertar(pelicula)
        }
    }

    // Define ViewModel factory in a companion object
    companion object {
        val Factory: ViewModelProvider.Factory = viewModelFactory {
            initializer {
                val contexto = (this[APPLICATION_KEY] as Context)
                PeliculasViewModel(
                    context = contexto
                )
            }
        }
    }
}