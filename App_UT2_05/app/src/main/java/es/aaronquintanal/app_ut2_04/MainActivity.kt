package es.aaronquintanal.app_ut2_04

import android.app.Activity
import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.EditText
import androidx.activity.result.contract.ActivityResultContracts
import androidx.recyclerview.widget.DividerItemDecoration
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import com.google.android.material.dialog.MaterialAlertDialogBuilder
import com.google.android.material.floatingactionbutton.FloatingActionButton
import es.aaronquintanal.app_ut2_04.databinding.ActivityMainBinding
import es.aaronquintanal.app_ut2_04.datos.Animal
import es.aaronquintanal.app_ut2_04.modelo.AnimalAdapter

class MainActivity : AppCompatActivity()
{
    // creación de asignación tardía
    private lateinit var binding : ActivityMainBinding
    private lateinit var recyclerView: RecyclerView

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)

        recyclerView = binding.recyclerView
        recyclerView.adapter = AnimalAdapter(){animal -> onClickAnimal(animal)}
        recyclerView.layoutManager = LinearLayoutManager(this)

        recyclerView.addItemDecoration(
            DividerItemDecoration(this,
            DividerItemDecoration.VERTICAL)
        )

        val botonAnadir = findViewById<FloatingActionButton>(R.id.floatingActionButton)
        botonAnadir.setOnClickListener{
            dialogoNuevoAnimal()
        }
    }

    private val segundaActivityLauncher = registerForActivityResult(ActivityResultContracts.StartActivityForResult())
        {
            if(it.resultCode == Activity.RESULT_OK){
                val voto = it.data?.getIntExtra("voto", 0)?:0
                val nombre = it.data?.getStringExtra("animal")?:""
                (recyclerView.adapter as AnimalAdapter).cambiarVoto(nombre, voto)
                recyclerView.adapter?.notifyDataSetChanged()
            }
        }

    private fun dialogoNuevoAnimal()
    {
        val inputEditTextField = EditText(this)
        val dialog = MaterialAlertDialogBuilder(this)
            .setTitle("Nuevo animal")
            .setMessage("Introduce el nombre de un nuevo animal")
            .setView(inputEditTextField)
            .setPositiveButton("Añadir") { _, _ ->
                val nuevoAnimal = inputEditTextField .text.toString()
                (recyclerView.adapter as AnimalAdapter).addAnimal(Animal(nuevoAnimal, R.drawable.desconocido, "", 0))
            }
            .setNegativeButton("Cancelar", null)
            .create()
        dialog.show()
    }

    private fun onClickAnimal(animal: Animal) {
        val intent = Intent(applicationContext, DetalleAnimalActivity::class.java)
        intent.putExtra("animal", animal)
        //startActivity(intent)
        segundaActivityLauncher.launch(intent)
    }
}