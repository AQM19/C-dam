package es.intermodular.app_04_03.view

import android.app.NotificationChannel
import android.app.NotificationManager
import android.content.Context.NOTIFICATION_SERVICE
import android.graphics.Color
import android.os.Build
import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.core.app.NotificationCompat
import androidx.core.os.bundleOf
import androidx.fragment.app.activityViewModels
import androidx.navigation.NavController
import androidx.navigation.NavDeepLinkBuilder
import androidx.navigation.findNavController
import androidx.recyclerview.widget.LinearLayoutManager
import es.intermodular.app_04_03.R
import es.intermodular.app_04_03.databinding.FragmentListaFavoritasBinding
import es.intermodular.app_04_03.databinding.FragmentListaPeliculasBinding
import es.intermodular.app_04_03.model.Pelicula
import es.intermodular.app_04_03.viewmodel.PeliculasViewModel

class FragmentListaFavoritas : Fragment() {

    private val peliculasViewModel: PeliculasViewModel by activityViewModels { PeliculasViewModel.Factory}
    private lateinit var binding: FragmentListaFavoritasBinding
    private lateinit var navController: NavController

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View? {
        binding = FragmentListaFavoritasBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        navController = view.findNavController()

        peliculasViewModel.peliculasFavoritas.observe(viewLifecycleOwner){
            binding.recyclerViewListaFavoritas.apply {
                adapter = PeliculasAdapter(it, { pelicula -> onClickPelicula(pelicula)},{ pelicula -> cambiarFavorita(pelicula)})
                layoutManager = LinearLayoutManager(context)
            }
        }
    }

    private fun onClickPelicula(pelicula: Pelicula){
        navController.navigate(FragmentListaFavoritasDirections.actionFragmentListaFavoritasToFragmentDetalle(pelicula))
    }
    private fun cambiarFavorita(pelicula: Pelicula){

    }


}