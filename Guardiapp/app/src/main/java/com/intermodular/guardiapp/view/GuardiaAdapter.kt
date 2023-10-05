package com.intermodular.guardiapp.view

import android.annotation.SuppressLint
import android.app.AlertDialog
import android.content.Context
import android.util.Log
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Toast
import androidx.lifecycle.LifecycleOwner
import androidx.lifecycle.lifecycleScope
import androidx.lifecycle.viewModelScope
import androidx.recyclerview.widget.RecyclerView
import com.intermodular.guardiapp.R
import com.intermodular.guardiapp.databinding.FragmentGuardiaAdapterBinding
import com.intermodular.guardiapp.model.Guardia
import com.intermodular.guardiapp.viewmodel.Estado
import com.intermodular.guardiapp.viewmodel.ProfesorViewModel
import kotlinx.coroutines.launch

class GuardiaAdapter(
    private val guardias: List<Guardia>,
    private val profesorViewModel: ProfesorViewModel
    ) : RecyclerView.Adapter<GuardiaAdapter.GuardiaViewHolder>() {

    class GuardiaViewHolder(val view: View, private val profesorViewModel: ProfesorViewModel, private val contexto: Context) : RecyclerView.ViewHolder(view) {
        private val binding = FragmentGuardiaAdapterBinding.bind(view)

        @SuppressLint("ResourceAsColor", "SetTextI18n")
        fun bind(guardia: Guardia) {

            (itemView.context as LifecycleOwner).lifecycleScope.launch{
                val profesor = profesorViewModel.getProfeFalta(guardia.prof_falta)!!
                binding.textViewProfeFalta.text = "Falta: ${profesor.nombre} ${profesor.ape1} ${profesor.ape2}"
            }
            binding.textViewHora.text = "${guardia.hora.toString()}ª hora"
            binding.textViewGrupo.text = guardia.grupo
            binding.textViewAula.text = guardia.aula

            binding.checkBoxConfirmar.setOnClickListener{
                confirmarGuardia(guardia)
            }
        }

        private fun confirmarGuardia(guardia: Guardia) {
            AlertDialog.Builder(contexto)
                .setTitle("¿Confirmar guardia?")
                .setMessage("¿Está seguro que desea confirmar la realización de la guardia?")
                .setNegativeButton("No") { _,_ ->
                    Toast.makeText(contexto, "No ha realizado la guardia", Toast.LENGTH_LONG).show()
                    binding.checkBoxConfirmar.isChecked = false
                }
                .setPositiveButton("Si") { _,_ ->
                    guardia.estado = Estado.R
                    guardia.prof_hace_guardia = profesorViewModel.profesorLiveData.value!!.id

                    profesorViewModel.viewModelScope.launch {
                        profesorViewModel.setGuardiaConfirmada(guardia.id, guardia)
                        Toast.makeText(contexto, "Se ha realizado la guardia", Toast.LENGTH_LONG).show()
                    }
                }.show()
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): GuardiaViewHolder {
        val adapterLayout = LayoutInflater.from(parent.context)
            .inflate(R.layout.fragment_guardia_adapter, parent, false)
        return GuardiaViewHolder(adapterLayout, profesorViewModel, parent.context)
    }

    override fun onBindViewHolder(holder: GuardiaViewHolder, position: Int) {
        val guardia = guardias[position]
        holder.bind(guardia)
    }

    override fun getItemCount(): Int = guardias.size
}