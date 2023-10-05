package es.aaronquintanal.digiactivity.view

import android.app.Activity
import android.content.Intent
import android.graphics.drawable.ColorDrawable
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import androidx.activity.result.contract.ActivityResultContracts
import androidx.recyclerview.widget.DividerItemDecoration
import androidx.recyclerview.widget.LinearLayoutManager
import coil.load
import es.aaronquintanal.digiactivity.databinding.ActivityDigiDetailsBinding
import es.aaronquintanal.digiactivity.model.Digi
import es.aaronquintanal.digiactivity.model.Digimon

class DigiDetails : AppCompatActivity() {

    private lateinit var binding: ActivityDigiDetailsBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityDigiDetailsBinding.inflate(layoutInflater)
        setContentView(binding.root)

        val digimon = intent.extras?.get("digimon") as Digi

        binding.digiDetailsName.text = digimon.name
        binding.digimonDetailsImage.load(digimon.images[0].href)

        binding.recyclerDetails.apply {
            adapter = SkillAdapter(digimon.skills)
            layoutManager = LinearLayoutManager(context)
            val itemDecoration = DividerItemDecoration(context, DividerItemDecoration.VERTICAL)
            itemDecoration.setDrawable(ColorDrawable())
            addItemDecoration(itemDecoration)
        }

        binding.buttonPostEvolutions.setOnClickListener {
            val intent = Intent(applicationContext, LinearEvolutions::class.java)
            intent.putExtra("evolutions", digimon)
            intent.putExtra("pre", false)
            segundaActivityLauncher.launch(intent)
        }
        binding.buttonPreEvolutions.setOnClickListener {
            val intent = Intent(applicationContext, LinearEvolutions::class.java)
            intent.putExtra("evolutions", digimon)
            intent.putExtra("pre", true)
            segundaActivityLauncher.launch(intent)
        }
    }

    private val segundaActivityLauncher = registerForActivityResult(ActivityResultContracts.StartActivityForResult()){
        if(it.resultCode == Activity.RESULT_OK){
            val id = it.data?.getStringExtra("id")?:"";
            val intentDevuelto = Intent()
            intentDevuelto.putExtra("id", id)
            setResult(RESULT_OK, intentDevuelto)
            finish()
        }
    }
}
