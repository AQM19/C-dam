package es.aaronquintanal.digiactivity.view

import android.annotation.SuppressLint
import android.app.Activity
import android.content.Intent
import android.graphics.drawable.ColorDrawable
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.LinearLayout
import androidx.activity.result.contract.ActivityResultContracts
import androidx.activity.viewModels
import androidx.recyclerview.widget.DividerItemDecoration
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import coil.load
import es.aaronquintanal.digiactivity.R
import es.aaronquintanal.digiactivity.databinding.ActivityMainBinding
import es.aaronquintanal.digiactivity.viewmodel.DigiViewModel

class MainActivity : AppCompatActivity() {

    private lateinit var binding: ActivityMainBinding
    private val digiViewModel: DigiViewModel by viewModels()

    @SuppressLint("ResourceAsColor")
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)

        digiViewModel.cargarDatos()

        binding.buttonSearch.setOnClickListener {
            val busqueda = binding.editTextTextDigiNameOrId.text.toString()
            buscarDigimon(busqueda)
        }
        digiViewModel.digiLiveData.observe(this) {digimon ->
            binding.digiName.text = digimon.name
            binding.digimonImage.load(digimon.images[0].href)
            binding.digimonLevels.apply {
                adapter = LevelAdapter(digimon.levels)
                layoutManager = LinearLayoutManager(context)
                val itemDecoration = DividerItemDecoration(context, DividerItemDecoration.VERTICAL)
                itemDecoration.setDrawable(ColorDrawable())
                addItemDecoration(itemDecoration)
            }
            binding.digimonAttributes.apply{
                adapter = AttributeAdapter(digimon.attributes)
                layoutManager = LinearLayoutManager(context)
                val itemDecoration = DividerItemDecoration(context, DividerItemDecoration.VERTICAL)
                itemDecoration.setDrawable(ColorDrawable())
                addItemDecoration(itemDecoration)
            }
            binding.digimonTypes.apply{
                adapter = TypeAdapter(digimon.types)
                layoutManager = LinearLayoutManager(context)
                val itemDecoration = DividerItemDecoration(context, DividerItemDecoration.VERTICAL)
                itemDecoration.setDrawable(ColorDrawable())
                addItemDecoration(itemDecoration)
            }
            binding.digimonFields.apply {
                adapter = FieldAdapter(digimon.fields)
                layoutManager = LinearLayoutManager(context, RecyclerView.HORIZONTAL, false)
                val itemDecoration = DividerItemDecoration(context, DividerItemDecoration.HORIZONTAL)
                itemDecoration.setDrawable(ColorDrawable())
                addItemDecoration(itemDecoration)
            }
            binding.digimonImage.setOnClickListener {
                val intent = Intent(applicationContext, DigiDetails::class.java)
                intent.putExtra("digimon", digimon)
                segundaActivityLauncher.launch(intent)
            }
        }
    }

    private val segundaActivityLauncher = registerForActivityResult(ActivityResultContracts.StartActivityForResult()){
        if(it.resultCode == Activity.RESULT_OK){
            val id = it.data?.getStringExtra("id")?:"";
            buscarDigimon(id)
        }
    }

    private fun buscarDigimon(param: String){
        if(!param.isBlank()){
            digiViewModel.buscarDigimon(param)
        }
    }

}