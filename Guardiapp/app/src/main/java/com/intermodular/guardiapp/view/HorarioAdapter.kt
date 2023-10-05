package com.intermodular.guardiapp.view

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import com.intermodular.guardiapp.R
import com.intermodular.guardiapp.databinding.FragmentHorarioAdapterBinding
import com.intermodular.guardiapp.model.Horario

class HorarioAdapter(
    private val horarios: List<Horario>
): RecyclerView.Adapter<HorarioAdapter.HorarioViewHolder>() {

    class HorarioViewHolder(val view: View): RecyclerView.ViewHolder(view) {
        val binding = FragmentHorarioAdapterBinding.bind(view)

        fun bind(horario: Horario){
            binding.textViewHora.text = "${horario.hora.toString()}ª hora"
            binding.textViewAula.text = horario.aula
            binding.textViewGrupo.text = horario.grupo
            binding.textViewMateria.text = horario.materia
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): HorarioViewHolder {
        val adapterLayout = LayoutInflater.from(parent.context)
            .inflate(R.layout.fragment_horario_adapter, parent, false)
        return HorarioViewHolder(adapterLayout)
    }

    override fun onBindViewHolder(holder: HorarioViewHolder, position: Int) {
        val horario = horarios[position]
        holder.bind(horario)
    }

    override fun getItemCount(): Int = horarios.size

    fun getItem(i: Int): Horario = horarios[i]
}