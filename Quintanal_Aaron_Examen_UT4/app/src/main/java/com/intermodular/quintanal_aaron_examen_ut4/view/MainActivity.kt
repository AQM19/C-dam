package com.intermodular.quintanal_aaron_examen_ut4.view

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import androidx.navigation.NavController
import androidx.navigation.fragment.NavHostFragment
import com.intermodular.quintanal_aaron_examen_ut4.R
import com.intermodular.quintanal_aaron_examen_ut4.databinding.ActivityMainBinding

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
                R.id.casas -> navController.navigate(R.id.fragmentCasas)
                R.id.personajes -> navController.navigate(R.id.fragmentPersonajesVivos)
            }
            true
        }
    }

}