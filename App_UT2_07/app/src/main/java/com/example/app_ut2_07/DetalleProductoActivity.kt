package com.example.app_ut2_07

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import com.example.app_ut2_07.databinding.ActivityDetalleProductoBinding

class DetalleProductoActivity : AppCompatActivity() {

    private lateinit var binding : ActivityDetalleProductoBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityDetalleProductoBinding.inflate(layoutInflater)
        setContentView(binding.root)

        val producto = intent.extras?.get("producto") as Producto //Obtener el producto pasado por intent.putExtra

        val detalleImagen = binding.imageViewDetail
        val detalleTitulo = binding.textViewTitle
        val detalleDescription = binding.textViewDescription

        detalleImagen.setImageResource(producto.imagenId)
        detalleTitulo.text = producto.nombre
        detalleDescription.text = producto.nombre
    }
}