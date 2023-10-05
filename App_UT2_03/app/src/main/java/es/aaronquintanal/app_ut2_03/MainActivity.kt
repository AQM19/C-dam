package es.aaronquintanal.app_ut2_03

import android.graphics.Color
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.os.Message
import android.widget.*
import es.aaronquintanal.app_ut2_03.databinding.ActivityMainBinding
import java.io.Console

class MainActivity : AppCompatActivity() {

    private lateinit var binding : ActivityMainBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)

        val botonMostrar = binding.botonMostrar
        val iva = binding.switchIva
        val radioGroup = binding.opcionViaje


        radioGroup.setOnCheckedChangeListener { radioGroup, i ->
            val precio = calcularPrecio(i, iva.isChecked)

            establecerPrecio(precio)
        }

        iva.setOnCheckedChangeListener { compoundButton, b ->
            val precio = calcularPrecio(radioGroup.checkedRadioButtonId, iva.isChecked)

            establecerPrecio(precio)
        }


        botonMostrar.setOnClickListener {
            // Not implemented yet
        }

        calcularPrecio(radioGroup.checkedRadioButtonId, iva.isChecked)
    }

    private fun establecerPrecio(prize : Double){
        val presupuesto = binding.presupuesto
        val precioFinal = binding.precioFinal

        if(prize > Integer.parseInt(presupuesto.text.toString()).toDouble()) {
            precioFinal.setTextColor(
                Color.RED)
        } else {
            precioFinal.setTextColor(Color.BLACK)
        }
    }

    private fun calcularPrecio(radioButtonId: Int, iva: Boolean): Double {

        val radio = findViewById<RadioButton>(radioButtonId)
        var prize : Double = Integer.parseInt(radio.tag.toString()).toDouble()
        val imagen = binding.imageView
        if(iva) prize *= 1.21

        when(radioButtonId){
            R.id.opcion_interior -> imagen.setBackgroundResource(R.drawable.peninsular)
            R.id.opcion_islas -> imagen.setBackgroundResource(R.drawable.insular)
            R.id.opcion_interior -> imagen.setBackgroundResource(R.drawable.interior)
        }

        return prize
    }
}