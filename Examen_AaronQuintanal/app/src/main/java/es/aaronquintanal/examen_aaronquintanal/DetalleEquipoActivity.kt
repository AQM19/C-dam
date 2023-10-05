package es.aaronquintanal.examen_aaronquintanal

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import es.aaronquintanal.examen_aaronquintanal.databinding.ActivityDetalleEquipoBinding
import es.aaronquintanal.examen_aaronquintanal.modelo.Equipo

class DetalleEquipoActivity : AppCompatActivity() {

    private lateinit var binding : ActivityDetalleEquipoBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityDetalleEquipoBinding.inflate(layoutInflater)
        setContentView(binding.root)

        val equipo = intent.extras?.get("equipo") as Equipo

        val nombre = binding.textViewDetalleEquipo
        val favorito = binding.toggleButton
        val imagen = binding.imageViewDetalleEquipo
        val descripcion = binding.textViewDetalleDescripcion

        nombre.text = equipo.pais
        favorito.isChecked = equipo.pasa
        imagen.setImageResource(equipo.imagen)
        descripcion.text = equipo.descripcion

        favorito.setOnClickListener{
            equipo.pasa = favorito.isChecked
            HacerFavorito(equipo)
        }
    }

    private fun HacerFavorito(equipo : Equipo){
        val intentDevuelto = Intent()
        intentDevuelto.putExtra("equipo", equipo)
        intentDevuelto.putExtra("fav", equipo.pasa)
        setResult(RESULT_OK, intentDevuelto)
        finish()
    }
}