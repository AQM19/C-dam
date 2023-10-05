package com.intermodular.guardiapp.view

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import androidx.databinding.DataBindingUtil.setContentView
import androidx.navigation.NavController
import androidx.navigation.fragment.NavHostFragment
import androidx.navigation.ui.NavigationUI.setupActionBarWithNavController
import androidx.navigation.ui.setupActionBarWithNavController
import com.intermodular.guardiapp.R
import com.intermodular.guardiapp.databinding.ActivityMainBinding

class MainActivity : AppCompatActivity(), LoginFragment.LoginListener {

    private lateinit var binding: ActivityMainBinding
    private lateinit var navController: NavController
    private var logged : Boolean = false

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)

        val navHostFragment = supportFragmentManager
            .findFragmentById(R.id.navHostFragment) as NavHostFragment
        navController = navHostFragment.navController

        //setupActionBarWithNavController(navController)

        opcionesMenu()
    }

    override fun onSupportNavigateUp(): Boolean {
        swapLog(false)
        return navController.navigateUp() || super.onSupportNavigateUp()
    }

    private fun opcionesMenu(){
        swapLog(false)

        binding.viewBottomNavigation.setOnItemSelectedListener {
            when (it.itemId) {
                R.id.consumirGuardiaIcon -> navController.navigate(R.id.fragmentGuardiasLista)
                R.id.generarAvisoIcon -> navController.navigate(R.id.fragmentFecha)
                R.id.verAvisos -> navController.navigate(R.id.fragmentAvisos)
            }
            true
        }
    }

    override fun onLogin() {
        swapLog(true)
    }

    private fun swapLog(param:Boolean){
        logged = param
        binding.viewBottomNavigation.visibility = if(logged) View.VISIBLE else View.GONE
    }
}