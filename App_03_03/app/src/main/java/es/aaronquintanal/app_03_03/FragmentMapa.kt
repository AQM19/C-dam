package es.aaronquintanal.app_03_03

import android.annotation.SuppressLint
import androidx.fragment.app.Fragment

import android.os.Bundle
import android.os.Looper
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import com.google.android.gms.location.*

import com.google.android.gms.maps.CameraUpdateFactory
import com.google.android.gms.maps.GoogleMap
import com.google.android.gms.maps.OnMapReadyCallback
import com.google.android.gms.maps.SupportMapFragment
import com.google.android.gms.maps.model.LatLng
import com.google.android.gms.maps.model.MarkerOptions

class FragmentMapa : Fragment() {

    private lateinit var miMapa: GoogleMap
    private lateinit var fusedLocationClient: FusedLocationProviderClient
    private lateinit var locationCallback: LocationCallback

    private val callback = OnMapReadyCallback { googleMap ->
        miMapa = googleMap
    }

    override fun onStart() {
        super.onStart()
        actualizarMapa()
    }

    override fun onCreateView(
        inflater: LayoutInflater,
        container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        return inflater.inflate(R.layout.fragment_mapa, container, false)
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        val mapFragment = childFragmentManager.findFragmentById(R.id.map) as SupportMapFragment?
        mapFragment?.getMapAsync(callback)
    }

    @SuppressLint("MissingPermission")
    private fun actualizarMapa()
    {
        fusedLocationClient = LocationServices.getFusedLocationProviderClient(requireContext())
        val locationRequest = LocationRequest.Builder(
            Priority.PRIORITY_HIGH_ACCURACY,
            1000).build()
        locationCallback = object : LocationCallback()
        {
            override fun onLocationResult(locationResult: LocationResult) {
                for(location in locationResult.locations){
                    val coordenadas = LatLng(location.latitude, location.longitude)
                    miMapa.clear()
                    miMapa.addMarker(MarkerOptions().position(coordenadas).title("Estoy aquñi"))
                    miMapa.moveCamera(CameraUpdateFactory.newLatLngZoom(coordenadas, 16f))
                }
            }
        }
        fusedLocationClient.requestLocationUpdates(
            locationRequest,
            locationCallback, Looper.getMainLooper()
        )
    }
}