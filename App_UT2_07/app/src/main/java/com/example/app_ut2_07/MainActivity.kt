package com.example.app_ut2_07

import android.app.Activity
import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import android.view.ViewParent
import android.widget.AdapterView
import android.widget.AdapterView.OnItemSelectedListener
import android.widget.ArrayAdapter
import android.widget.Toast
import androidx.activity.result.contract.ActivityResultContract
import androidx.activity.result.contract.ActivityResultContracts
import androidx.recyclerview.widget.DividerItemDecoration
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import com.example.app_ut2_07.databinding.ActivityMainBinding
import java.text.FieldPosition

class MainActivity : AppCompatActivity() {

    private lateinit var binding: ActivityMainBinding
    private lateinit var recyclerView: RecyclerView

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)

        val spinner = binding.spinner
        val adapter = ArrayAdapter(this, android.R.layout.simple_spinner_item, Datos.nombresCategorias())
        spinner.setAdapter(adapter)

        spinner.onItemSelectedListener = object : AdapterView.OnItemSelectedListener {
            override fun onItemSelected(parent: AdapterView<*>?, view: View?, position: Int, id: Long) {
                Toast.makeText(applicationContext, Datos.nombresCategorias()[position], Toast.LENGTH_LONG).show()

                recyclerView = binding.recyclerView
                recyclerView.adapter = FoodAdapter(Datos.nombresCategorias()[position]){producto -> onClickProducto(producto) }
                recyclerView.layoutManager = LinearLayoutManager(this@MainActivity)

                recyclerView.addItemDecoration(
                    DividerItemDecoration(this@MainActivity,
                    DividerItemDecoration.VERTICAL)
                )

            }

            override fun onNothingSelected(parent: AdapterView<*>?) {}
        }
    }

    private fun onClickProducto(producto : Producto) {
        val intent = Intent(applicationContext, DetalleProductoActivity::class.java)
        intent.putExtra("producto", producto) // Necesita saber que es serializable : Serializable
        startActivity(intent)
    }
}