package es.aaronquintanal.app_ut2_04

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.text.method.ScrollingMovementMethod
import android.widget.Button
import android.widget.ImageView
import android.widget.TextView
import es.aaronquintanal.app_ut2_04.databinding.ActivityDetallleAnimalBinding
import es.aaronquintanal.app_ut2_04.datos.Animal

class DetalleAnimalActivity : AppCompatActivity() {

    private lateinit var binding : ActivityDetallleAnimalBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityDetallleAnimalBinding.inflate(layoutInflater)
        setContentView(binding.root)

        val animal = intent.extras?.get("animal") as Animal

        val activityimage = binding.descriptionImage
        val activitytitle = binding.descriptionTitle
        val activitydescr = binding.redundantDescription
        val botonpositivo = binding.botonpositivo
        val botonnegativo = binding.botonnegativo

        activityimage.setImageResource(animal.imagenId)
        activitytitle.text = animal.nombre
        activitydescr.text = animal.descripcion
        activitydescr.movementMethod = ScrollingMovementMethod()

        botonpositivo.setOnClickListener {
            crearIntentAMain(animal, 1)
        }

        botonnegativo.setOnClickListener {
            crearIntentAMain(animal, -1)
        }
    }

    fun crearIntentAMain(animal: Animal, voto: Int){
        val intentDevuelto = Intent()
        intentDevuelto.putExtra("voto", voto)
        intentDevuelto.putExtra("animal", animal.nombre)
        setResult(RESULT_OK, intentDevuelto)
        finish()
    }
}