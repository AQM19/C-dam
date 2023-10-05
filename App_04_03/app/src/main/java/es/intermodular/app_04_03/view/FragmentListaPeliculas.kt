package es.intermodular.app_04_03.view

import android.app.NotificationChannel
import android.app.NotificationManager
import android.content.Context
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
import androidx.navigation.fragment.findNavController
import androidx.recyclerview.widget.LinearLayoutManager
import es.intermodular.app_04_03.R
import es.intermodular.app_04_03.databinding.FragmentListaPeliculasBinding
import es.intermodular.app_04_03.model.Pelicula
import es.intermodular.app_04_03.viewmodel.PeliculasViewModel
import okhttp3.internal.notifyAll

class FragmentListaPeliculas : Fragment() {

    private val peliculasViewModel: PeliculasViewModel by activityViewModels { PeliculasViewModel.Factory}
    private lateinit var binding: FragmentListaPeliculasBinding
    private lateinit var navController: NavController

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View? {
        binding = FragmentListaPeliculasBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        navController = view.findNavController()

        peliculasViewModel.peliculas.observe(viewLifecycleOwner){
            binding.recyclerViewListaPeliculas.apply {
                adapter = PeliculasAdapter(it, { pelicula -> onClickPelicula(pelicula)},{ pelicula -> cambiarFavorita(pelicula)})
                layoutManager = LinearLayoutManager(context)
            }
        }
    }

    private fun onClickPelicula(pelicula: Pelicula){
        navController.navigate(FragmentListaPeliculasDirections.actionFragmentListaPeliculasToFragmentDetalle(pelicula))
    }
    private fun cambiarFavorita(pelicula: Pelicula){
        peliculasViewModel.cambiarFavorita(pelicula.id)
        crearNotificacion(pelicula)
    }

    private fun crearNotificacion(pelicula: Pelicula)
    {
        val notificationManager = activity?.getSystemService(Context.NOTIFICATION_SERVICE) as NotificationManager

        val pendingIntent = NavDeepLinkBuilder(requireContext())
            .setComponentName(MainActivity::class.java)
            .setGraph(R.navigation.nav_graph)
            .setDestination(R.id.fragmentDetalle, bundleOf("pelicula" to pelicula) )
            .createPendingIntent()

        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.O) {
            val notificationChannel = NotificationChannel("1234", getString(R.string.nombre_canal),
                NotificationManager.IMPORTANCE_HIGH)
            notificationChannel.enableLights(true)
            notificationChannel.lightColor = Color.GREEN
            notificationChannel.enableVibration(true)
            notificationManager.createNotificationChannel(notificationChannel)
        }
        val notificacion = NotificationCompat.Builder(requireContext(), "1234")
            .setContentTitle(pelicula.titulo)
            .setContentText("Se ha añadido a favorita")
            .setSmallIcon(R.drawable.ic_pelicula)
            .setPriority(NotificationCompat.PRIORITY_HIGH)
            .setContentIntent(pendingIntent).build()

        notificationManager.notify(1234, notificacion)
    }
}