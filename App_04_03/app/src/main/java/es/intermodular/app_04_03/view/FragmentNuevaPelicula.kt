package es.intermodular.app_04_03.view

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Toast
import androidx.fragment.app.activityViewModels
import androidx.navigation.fragment.findNavController
import coil.load
import es.intermodular.app_04_03.R
import es.intermodular.app_04_03.databinding.FragmentNuevaPeliculaBinding
import es.intermodular.app_04_03.model.Pelicula
import es.intermodular.app_04_03.viewmodel.PeliculasViewModel
import java.lang.NumberFormatException

class FragmentNuevaPelicula : Fragment() {

    private val peliculasViewModel: PeliculasViewModel by activityViewModels { PeliculasViewModel.Factory}
    private lateinit var binding: FragmentNuevaPeliculaBinding

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View? {
        binding = FragmentNuevaPeliculaBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        binding.editTextImagenPelicula.setOnFocusChangeListener{ _,foco ->
            if(!foco && binding.editTextImagenPelicula.text.toString().isNotEmpty()){
                val userAgent = "Mozilla/5.0 (X11; Linux x86_64)AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.0.0Safari/537.36"
                val url = binding.editTextImagenPelicula.text.toString()
                binding.imageViewImagenNuevaPelicula.load(url)
                {
                    addHeader("User-Agent", userAgent)
                }
            }
        }

        binding.buttonCrearPelicula.setOnClickListener {
            if(validarDatos()){
                val titulo: String = binding.editTextTituloPelicula.text.toString()
                val anyo: Int = binding.editTextAnyoPelicula.text.toString().toInt()
                val director: String = binding.editTextDirectorPelicula.text.toString()
                val puntuacion: Float = binding.editTextPuntuacionPelicula.text.toString().toFloat()
                val imagen: String = binding.editTextImagenPelicula.text.toString()
                val sinopsis: String = binding.editTextSinopsisPelicula.text.toString()

                peliculasViewModel.insertarPelicula(
                    Pelicula(0, titulo, anyo, director, puntuacion, imagen, sinopsis, false)
                )

                findNavController().navigate(R.id.fragmentListaPeliculas)
            }
        }
    }

    private fun validarDatos(): Boolean{
        if(!isNumeric(binding.editTextAnyoPelicula.text.toString())){
            Toast.makeText(context, "El año de la película debe ser un número", Toast.LENGTH_SHORT)
            return false
        }
        if(!isNumeric(binding.editTextPuntuacionPelicula.text.toString())){
            Toast.makeText(context, "La puntuación de la película debe ser un número", Toast.LENGTH_SHORT)
            return false
        }
        return true
    }

    private fun isNumeric(param: String): Boolean{
        return try {
            param.toFloat()
            true
        } catch (e: NumberFormatException){
            false
        }
    }

}