package es.aaronquintanal.tarea_ut02_01

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import android.widget.Button
import android.widget.ImageView
import android.widget.TextView
import android.widget.Toast
import es.aaronquintanal.tarea_ut02_01.databinding.ActivityMainBinding

class MainActivity : AppCompatActivity() {

    private lateinit var binding : ActivityMainBinding

    private val datos = linkedMapOf<String, Int>(
        "Iván" to R.drawable.avatar3,
        "María" to R.drawable.avatar1,
        "Rosa" to R.drawable.avatar2,
        "Pepe" to R.drawable.avatar4)
    private var cont = 0;

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)

        val btnCambiar = binding.btnCambiar
        val txtName = binding.textView
        val imgAvatar = binding.imageView

        btnCambiar.text = "Cambiar"


        btnCambiar.setOnClickListener {
            cambiarImagenYTexto(txtName, imgAvatar)
        }
    }

    private fun cambiarImagenYTexto(txtName: TextView, imgAvatar: ImageView){
        cont %= datos.size
        val texto = datos.keys.elementAt(cont++)

        txtName.text = texto
        imgAvatar.setImageResource(datos[texto]!!)

        Toast.makeText(this, "Has cambiado a $texto", Toast.LENGTH_SHORT).show()
    }
}