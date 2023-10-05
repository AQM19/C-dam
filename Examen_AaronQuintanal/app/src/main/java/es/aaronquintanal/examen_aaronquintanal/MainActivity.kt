package es.aaronquintanal.examen_aaronquintanal

import android.app.Activity
import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import android.widget.AdapterView
import android.widget.ArrayAdapter
import android.widget.Toast
import androidx.activity.result.contract.ActivityResultContracts
import androidx.recyclerview.widget.DividerItemDecoration
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import es.aaronquintanal.examen_aaronquintanal.databinding.ActivityMainBinding
import es.aaronquintanal.examen_aaronquintanal.modelo.Equipo

class MainActivity : AppCompatActivity() {

    lateinit var binding : ActivityMainBinding
    private lateinit var recyclerView: RecyclerView

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)

        val spinner = binding.spinner
        val adapter = ArrayAdapter(this, android.R.layout.simple_spinner_item, DatosSelecciones.getNombreGrupos())
        spinner.setAdapter(adapter)
        spinner.setSelection(0, false) // para evitarlo, pero al seleccionar el grupo A no mandará nada.

        spinner.onItemSelectedListener = object : AdapterView.OnItemSelectedListener {
            override fun onItemSelected(parent: AdapterView<*>?, view: View?, position: Int, id: Long) {
                val intent = Intent(applicationContext, GrupoActivity::class.java)
                val grupo = adapter.getItem(position)?.let { DatosSelecciones.getGrupo(it) }
                intent.putExtra("grupo", grupo)
                startActivity(intent)
            }

            override fun onNothingSelected(parent: AdapterView<*>?) {}
        }

        recyclerView = binding.recyclerView
        recyclerView.adapter = FavoritosAdapter(){equipo -> onClickEquipo(equipo)}
        recyclerView.layoutManager = LinearLayoutManager(this@MainActivity)

        recyclerView.addItemDecoration(
            DividerItemDecoration(this@MainActivity,
                DividerItemDecoration.VERTICAL)
        )
    }

    private val segundaActivityLauncher = registerForActivityResult(ActivityResultContracts.StartActivityForResult()){
        if(it.resultCode == Activity.RESULT_OK){
            val equipo= it.data?.getStringExtra("equipo")?:""
            val fav = it.data?.getBooleanExtra("fav", true)?:false
            (recyclerView.adapter as FavoritosAdapter).HacerFavorito(equipo, fav)
            recyclerView.adapter?.notifyDataSetChanged()
        }
    }

    private fun onClickEquipo(equipo : Equipo) {
        val intent = Intent(applicationContext, DetalleEquipoActivity::class.java)
        intent.putExtra("equipo", equipo)
        segundaActivityLauncher.launch(intent)
    }
}