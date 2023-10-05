package es.aaronquintanal.digiactivity.view

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import androidx.recyclerview.widget.DividerItemDecoration
import androidx.recyclerview.widget.LinearLayoutManager
import es.aaronquintanal.digiactivity.databinding.ActivityLinearEvolutionsBinding
import es.aaronquintanal.digiactivity.model.Digi
import es.aaronquintanal.digiactivity.model.Digimon

class LinearEvolutions : AppCompatActivity() {

    private lateinit var binding: ActivityLinearEvolutionsBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityLinearEvolutionsBinding.inflate(layoutInflater)
        setContentView(binding.root)

        val evolutions = intent.extras?.get("evolutions") as Digi
        val pre = intent.extras?.get("pre") as Boolean

        binding.recyclerEvolutions.apply {
            when(pre){
                false -> adapter = EvolutionAdapter(evolutions.nextEvolutions) { digimon -> onClickDigimon(digimon) }
                true -> adapter = EvolutionAdapter(evolutions.priorEvolutions){ digimon -> onClickDigimon(digimon) }
            }
            layoutManager = LinearLayoutManager(context)
            addItemDecoration(DividerItemDecoration(context,DividerItemDecoration.VERTICAL))
        }
    }

    private fun onClickDigimon(digimon: Digimon){
        val intentDevuelto = Intent()
        intentDevuelto.putExtra("id", digimon.id.toString())
        setResult(RESULT_OK, intentDevuelto)
        finish()
    }
}