package es.intermodular.app_04_03.view

import android.app.AlertDialog
import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Toast
import androidx.fragment.app.activityViewModels
import androidx.navigation.findNavController
import androidx.navigation.fragment.findNavController
import coil.load
import es.intermodular.app_04_03.R
import es.intermodular.app_04_03.databinding.FragmentDetalleBinding
import es.intermodular.app_04_03.model.Pelicula
import es.intermodular.app_04_03.viewmodel.PeliculasViewModel

class FragmentDetalle : Fragment() {

    private val peliculasViewModel: PeliculasViewModel by activityViewModels {PeliculasViewModel.Factory}
    private lateinit var pelicula: Pelicula
    private lateinit var binding: FragmentDetalleBinding

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View? {
        binding = FragmentDetalleBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        arguments?.let {
            pelicula = it.get("pelicula") as Pelicula
        }
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        val userAgent = "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko)Chrome/108.0.0.0 Safari/537.36"
        val url = pelicula.imagen
        binding.imageViewPortadaDetalle.load(url){addHeader("User-Agent", userAgent)}
        if(pelicula.favorita) binding.imageViewFavoritoDetalle.setImageResource(R.drawable.ic_favorito)

        binding.textViewTituloDetalle.text = pelicula.titulo
        binding.textViewDirectorDetalle.text = pelicula.director
        binding.textViewSinopsis.text = pelicula.sinopsis

        binding.imageViewCritica.setOnClickListener {
            findNavController().navigate(FragmentDetalleDirections.actionFragmentDetalleToFragmentCriticas(pelicula.id))
        }
        binding.imageViewBorrar.setOnClickListener {
            AlertDialog.Builder(context)
                .setTitle("¿Borrar película?")
                .setMessage("¿Está seguro que desea borrar la película ${pelicula.titulo}?")
                .setNegativeButton("No") { _,_ ->
                    Toast.makeText(context, "No se ha conseguido borrar la película ${pelicula.titulo}", Toast.LENGTH_LONG).show()
                }
                .setPositiveButton("Si") { _,_ ->
                    //peliculasViewModel.borrarPelicula(pelicula)
                    view.findNavController().navigate(R.id.fragmentListaPeliculas)
                }.show()
        }
    }

}