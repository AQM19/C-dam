package com.intermodular.guardiapp.view

import android.annotation.SuppressLint
import android.app.AlertDialog
import android.content.Context
import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Toast
import androidx.lifecycle.viewModelScope
import androidx.recyclerview.widget.RecyclerView
import com.intermodular.guardiapp.R
import com.intermodular.guardiapp.databinding.FragmentAvisoAdapterBinding
import com.intermodular.guardiapp.model.AvisoGuardia
import com.intermodular.guardiapp.viewmodel.AvisoGuardiaViewModel
import com.intermodular.guardiapp.viewmodel.Estado
import kotlinx.coroutines.launch

class AvisoAdapter(
    private val avisos: List<AvisoGuardia>,
    private val guardiaViewModel: AvisoGuardiaViewModel
): RecyclerView.Adapter<AvisoAdapter.AvisoViewHolder>(){

    class AvisoViewHolder(
        val view: View,
        private val guardiaViewModel: AvisoGuardiaViewModel,
        private val contexto: Context): RecyclerView.ViewHolder(view) {
        private val binding = FragmentAvisoAdapterBinding.bind(view)

        @SuppressLint("SetTextI18n")
        fun bind(aviso: AvisoGuardia){
            binding.textViewMotivo.text = aviso.motivo
            binding.textViewFecha.text = aviso.fecha_aviso.toString()
            binding.checkConfirmado.isChecked = aviso.confirmado!!
            binding.checkAnulado.isChecked = aviso.anulado!!
            binding.textViewHora.text = "${aviso.fecha_aviso}"
            binding.checkConfirmado.setOnClickListener {
                AlertDialog.Builder(contexto)
                    .setTitle("¿Confirmar guardia?")
                    .setMessage("¿Está seguro que desea confirmar el aviso?")
                    .setNegativeButton("No") { _,_ ->
                        Toast.makeText(contexto, "No ha realizado el aviso", Toast.LENGTH_LONG).show()
                        binding.checkConfirmado.isChecked = false
                    }
                    .setPositiveButton("Si") { _,_ ->
                        Toast.makeText(contexto, "Aviso confirmado", Toast.LENGTH_LONG).show()
                        binding.checkConfirmado.isChecked = true
                        binding.checkAnulado.isChecked = false

                        aviso.confirmado = true
                        aviso.anulado = false

                        guardiaViewModel.viewModelScope.launch {
                            guardiaViewModel.setAvisoConfirmado(aviso.id_aviso, aviso)
                        }
                    }.show()
            }
            binding.checkAnulado.setOnClickListener {
                AlertDialog.Builder(contexto)
                    .setTitle("¿Anular guardia?")
                    .setMessage("¿Está seguro que desea anular el aviso?")
                    .setNegativeButton("No") { _,_ ->
                        Toast.makeText(contexto, "No ha realizado el aviso", Toast.LENGTH_LONG).show()
                        binding.checkAnulado.isChecked = false
                    }
                    .setPositiveButton("Si") { _,_ ->
                        Toast.makeText(contexto, "Aviso confirmado", Toast.LENGTH_LONG).show()
                        binding.checkAnulado.isChecked = true
                        binding.checkConfirmado.isChecked = false

                        aviso.confirmado = false
                        aviso.anulado = true

                        guardiaViewModel.viewModelScope.launch {
                            guardiaViewModel.setAvisoAnulado(aviso.id_aviso, aviso)
                        }
                    }.show()
            }
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): AvisoViewHolder {
        val adapterLayout = LayoutInflater.from(parent.context)
            .inflate(R.layout.fragment_aviso_adapter, parent, false)
        return AvisoViewHolder(adapterLayout, guardiaViewModel, parent.context)
    }

    override fun onBindViewHolder(holder: AvisoViewHolder, position: Int) {
        val aviso = avisos[position]
        holder.bind(aviso)
    }

    override fun getItemCount(): Int = avisos.size
}