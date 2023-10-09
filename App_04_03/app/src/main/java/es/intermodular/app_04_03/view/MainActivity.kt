package es.intermodular.app_04_03.view

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.MenuItem
import androidx.annotation.GravityInt
import androidx.appcompat.app.ActionBarDrawerToggle
import androidx.core.view.GravityCompat
import androidx.navigation.NavController
import androidx.navigation.fragment.NavHostFragment
import es.intermodular.app_04_03.R
import es.intermodular.app_04_03.databinding.ActivityMainBinding

class MainActivity : AppCompatActivity() {

    private lateinit var binding: ActivityMainBinding
    private lateinit var toggle: ActionBarDrawerToggle
    private lateinit var navController: NavController

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)

        binding.apply {
            toggle = ActionBarDrawerToggle(this@MainActivity, drawerLayout, R.string.open, R.string.close)
            drawerLayout.addDrawerListener(toggle)
            toggle.syncState()

            supportActionBar?.setDisplayHomeAsUpEnabled(true)

            //id del NavigationView de activity_main.xml
            viewSideNavigation.setCheckedItem(R.id.listadoPeliculas) // primer item del menu lateral
            viewSideNavigation.setNavigationItemSelectedListener {
                when(it.itemId){
                    R.id.listadoPeliculas -> navController.navigate(R.id.fragmentListaPeliculas)
                    R.id.addPeliculas -> navController.navigate(R.id.fragmentNuevaPelicula)
                    R.id.informacionPeliculas -> TODO()
                    else -> TODO()
                }
                drawerLayout.closeDrawer(GravityCompat.START)
                true
            }
        }
        val navHostFragment = supportFragmentManager
            .findFragmentById(R.id.fragmentContainerView) as NavHostFragment
        navController = navHostFragment.navController

        opcionesMenu()
    }

    override fun onOptionsItemSelected(item: MenuItem): Boolean {
        if(toggle.onOptionsItemSelected(item)){
            return true
        }
        return super.onOptionsItemSelected(item)
    }

    override fun onBackPressed() {
        if(binding.drawerLayout.isDrawerOpen(GravityCompat.START)) {
            binding.drawerLayout.closeDrawer(GravityCompat.START)
        } else {
            super.onBackPressed()
        }
    }

    private fun opcionesMenu() {
        binding.viewBottomNavigation.setOnItemSelectedListener {
            when (it.itemId) {
                R.id.peliculas -> navController.navigate(R.id.fragmentListaPeliculas)
                R.id.favoritos -> navController.navigate(R.id.fragmentListaFavoritas)
            }
            true
        }
    }
}