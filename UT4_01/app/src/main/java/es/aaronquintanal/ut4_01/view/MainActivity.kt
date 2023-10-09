package es.aaronquintanal.ut4_01.view

import android.content.Intent
import android.content.SharedPreferences
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.Menu
import android.view.MenuItem
import androidx.preference.PreferenceManager
import es.aaronquintanal.ut4_01.R
import es.aaronquintanal.ut4_01.databinding.ActivityMainBinding

class MainActivity : AppCompatActivity() {

    private lateinit var binding: ActivityMainBinding
    private lateinit var preferencias: SharedPreferences
    private lateinit var editor: SharedPreferences.Editor


    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)

        preferencias = PreferenceManager.getDefaultSharedPreferences(this)
        editor = preferencias.edit()

        CargarPreferencias()

        binding.buttonCargar.setOnClickListener { CargarPreferencias() }
        binding.buttonBorrar.setOnClickListener { BorrarPreferencias() }
    }

    override fun onCreateOptionsMenu(menu: Menu?): Boolean {
        menuInflater.inflate(R.menu.menu_preferencias, menu)
        return true
    }

    override fun onOptionsItemSelected(item: MenuItem): Boolean {
        if(item.itemId == R.id.preferencias)
        {
            val intent = Intent(this@MainActivity, PreferenciasActivity::class.java)
            startActivity(intent)
            return true
        }
        return super.onOptionsItemSelected(item)
    }

    override fun onResume() {
        super.onResume()
        CargarPreferencias()
    }

    fun CargarPreferencias(){
        val nombre = preferencias.getString("nombre", "Sin datos")
        val edad = preferencias.getBoolean("mayoria_edad", false)
        val email = preferencias.getString("email", "Sin datos")

        binding.textViewNombre.text = nombre
        binding.textViewMayorEdad.text = if(edad) "Mayor de edad" else "Menor de edad"
        binding.textViewEmail.text = email
    }
    fun BorrarPreferencias(){
        editor.clear()
        editor.apply()
        CargarPreferencias()
    }
}