package es.aaronquintanal.app_03_03.view

import android.content.pm.PackageManager
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Toast
import androidx.activity.result.contract.ActivityResultContracts
import androidx.core.content.ContentProviderCompat.requireContext
import androidx.core.content.ContextCompat
import androidx.fragment.app.Fragment
import es.aaronquintanal.app_03_03.FragmentMapa
import es.aaronquintanal.app_03_03.R
import es.aaronquintanal.app_03_03.databinding.ActivityMainBinding
import java.util.jar.Manifest

class MainActivity : AppCompatActivity() {

    private lateinit var binding: ActivityMainBinding

    private val fragmentLocalizacion = FragmentLocalizacion()
    private val fragmentMapa = FragmentMapa()

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)

        setFragment(fragmentLocalizacion)
        opcionesMenu()
    }

    private fun setFragment(fragmentToChange: Fragment){
        supportFragmentManager.beginTransaction()
            .replace(R.id.layoutFragmentHolder, fragmentToChange)
            .commit()
    }

    private fun opcionesMenu() {
        binding.viewBottomNavigation.setOnItemSelectedListener {
            when (it.itemId){
                R.id.localizacion -> setFragment(fragmentLocalizacion)
                R.id.mapa -> setFragment(fragmentMapa)
            }
            true
        }
    }

    private fun comprobarPermisos() {
        val permisos = arrayOf(
            android.Manifest.permission.ACCESS_COARSE_LOCATION,
            android.Manifest.permission.ACCESS_FINE_LOCATION
        )
        if (!tienePermisos(permisos))
            solicitarPermisos(permisos)
    }

    private fun tienePermisos(permisos: Array<String>): Boolean {
        return permisos.all {
            return ContextCompat.checkSelfPermission(
                this,
                it
            ) == PackageManager.PERMISSION_GRANTED
        }
    }

    private val peticionPermisos =
        registerForActivityResult(ActivityResultContracts.RequestMultiplePermissions()) { permissions ->
            val aceptados = permissions.entries.all {
                Toast.makeText(this, "${it.key} = ${it.value}", Toast.LENGTH_SHORT).show()
                it.value
            }
            if (aceptados)
                finishAffinity()
        }

    private fun solicitarPermisos(permisos: Array<String>) {
        peticionPermisos.launch(permisos)
    }
}