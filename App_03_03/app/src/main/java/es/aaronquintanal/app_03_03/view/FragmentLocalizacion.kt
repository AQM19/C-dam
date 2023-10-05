package es.aaronquintanal.app_03_03.view

import android.Manifest
import android.annotation.SuppressLint
import android.content.pm.PackageManager
import android.location.Geocoder
import android.location.Location
import android.os.Bundle
import android.os.Looper
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Toast
import androidx.activity.result.contract.ActivityResultContracts
import androidx.core.content.ContextCompat
import com.google.android.gms.location.*
import es.aaronquintanal.app_03_03.R
import es.aaronquintanal.app_03_03.databinding.FragmentLocalizacionBinding
import java.util.*

class FragmentLocalizacion : Fragment() {

    private lateinit var binding: FragmentLocalizacionBinding
    private lateinit var fusedLocationClient: FusedLocationProviderClient
    private lateinit var locationCallback: LocationCallback

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        binding.localizacionButton.setOnClickListener {
            geolocalizacionConstante()
        }
    }

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View? {
        binding = FragmentLocalizacionBinding.inflate(layoutInflater)
        return binding.root
    }

    @SuppressLint("MissingPermission")
// Hasta aquí sabemos que los permisos ya están concedidos, por eso añado la anotación
    private fun geolocalizar() {
        fusedLocationClient = LocationServices.getFusedLocationProviderClient(requireContext())
        fusedLocationClient.lastLocation.addOnSuccessListener {
            if (it != null)
                imprimirUbicacion(it)
        }
    }

    private fun imprimirUbicacion(ubicacion: Location) {
        Toast.makeText(context, "${ubicacion.latitude}, ${ubicacion.longitude}",
            Toast.LENGTH_SHORT).show()
        binding.latitudTextView.text = getString(R.string.latitud, ubicacion.latitude)
        binding.longitudTextView.text = getString(R.string.longitud, ubicacion.longitude)
        binding.direccionTextView.text = "Direccion: ${buscarDireccion(ubicacion)}"
    }

    private fun buscarDireccion(ubicacion: Location): String
    {
        val geocoder = Geocoder(context, Locale.getDefault())
        val direcciones = geocoder.getFromLocation(
            ubicacion.latitude, ubicacion.longitude, 1
        )
        if (direcciones.isNotEmpty())
        {
            val direccion = direcciones.first()
            val textoDireccion =
                (0..direccion.maxAddressLineIndex)
                    .joinToString("\n") { i -> direccion.getAddressLine(i)}
            return textoDireccion
        }
        return ""
    }

    @SuppressLint("MissingPermission")
    private fun geolocalizacionConstante()
    {
        fusedLocationClient = LocationServices.getFusedLocationProviderClient(requireContext())
        val locationRequest = LocationRequest.Builder(
            Priority.PRIORITY_HIGH_ACCURACY,
            10000).build()
        locationCallback = object : LocationCallback()
        {
            override fun onLocationResult(locationResult: LocationResult)
            {
                for (location in locationResult.locations)
                    imprimirUbicacion(location)
            }
        }
        fusedLocationClient.requestLocationUpdates(
            locationRequest,
            locationCallback, Looper.getMainLooper()
        )
    }

    override fun onPause() {
        super.onPause()
        if(this::fusedLocationClient.isInitialized)
            fusedLocationClient.removeLocationUpdates(locationCallback)
    }
}