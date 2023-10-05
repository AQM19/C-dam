package es.aaronquintanal.quintanal_aaron.view

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Toast
import androidx.activity.viewModels
import androidx.fragment.app.activityViewModels
import androidx.fragment.app.viewModels
import androidx.navigation.NavController
import androidx.navigation.fragment.NavHostFragment
import es.aaronquintanal.quintanal_aaron.R
import es.aaronquintanal.quintanal_aaron.databinding.ActivityMainBinding
import es.aaronquintanal.quintanal_aaron.viewmodel.DinosauriosViewModel

class MainActivity : AppCompatActivity()
{
    private lateinit var binding: ActivityMainBinding
    private lateinit var navController: NavController

    override fun onCreate(savedInstanceState: Bundle?)
    {
        super.onCreate(savedInstanceState)
        binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)

        val navHostFragment = supportFragmentManager
            .findFragmentById(R.id.layoutFragmentHolder) as NavHostFragment
        navController = navHostFragment.navController

        opcionesMenu()
    }

    private fun opcionesMenu() {
        binding.viewBottomNavigation.setOnItemSelectedListener {
            when (it.itemId) {
                R.id.dinosaurios -> navController.navigate(R.id.fragmentLista)
                R.id.yacimientos -> navController.navigate(R.id.fragmentYacimientos)
            }
            true
        }
    }
}