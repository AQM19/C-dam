package com.example.btells.view

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.LinearLayout
import android.widget.Toast
import androidx.activity.viewModels
import androidx.recyclerview.widget.DividerItemDecoration
import androidx.recyclerview.widget.LinearLayoutManager
import com.example.btells.R
import com.example.btells.databinding.ActivityMainBinding
import com.example.btells.model.Escarabajo
import com.example.btells.viewmodel.EscarabajosViewModel

class MainActivity : AppCompatActivity() {

    private lateinit var binding: ActivityMainBinding
    private val escarabajosViewModel: EscarabajosViewModel by viewModels()

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)

        escarabajosViewModel.cargarDatos()

        escarabajosViewModel.escarabajosLiveData.observe(this) { escarabajos ->
            with(binding.recyclerListaEscarabajos){
                adapter = EscarabajoAdapter(escarabajos)
                layoutManager = LinearLayoutManager(context)
                addItemDecoration(DividerItemDecoration(context, DividerItemDecoration.VERTICAL))
            }
        }
    }

    private fun onClickEscarabajo(escarabajo: Escarabajo){
        Toast.makeText(this, "Has seleccionado el bicho ${escarabajo.commonname}.", Toast.LENGTH_SHORT).show()
    }
}