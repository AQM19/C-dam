package com.example.digifragmentv2.view

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import com.example.digifragmentv2.R
import com.example.digifragmentv2.databinding.FragmentEvolutionAdapterBinding
import com.example.digifragmentv2.model.Digimon

class EvolutionAdapter(private val evolutions: List<Digimon>, private val onClickDigimon: (Digimon) -> Unit): RecyclerView.Adapter<EvolutionAdapter.EvolutionViewHolder>() {

    class EvolutionViewHolder(view: View): RecyclerView.ViewHolder(view) {
        private val binding = FragmentEvolutionAdapterBinding.bind(view)

        fun bind(evolution: Digimon, onClickDigimon: (Digimon) -> Unit){
            binding.textViewName.text = evolution.digimon
            binding.textViewId.text = evolution.id.toString()
            binding.textViewCondition.text = evolution.condition
            binding.materialCard.setOnClickListener{ onClickDigimon(evolution) }
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): EvolutionViewHolder {
        val adapterLayout = LayoutInflater.from(parent.context)
            .inflate(R.layout.fragment_evolution_adapter, parent, false)
        return EvolutionViewHolder(adapterLayout)
    }

    override fun onBindViewHolder(holder: EvolutionViewHolder, position: Int) {
        val evolution = evolutions[position]
        holder.bind(evolution, onClickDigimon)
    }

    override fun getItemCount(): Int = evolutions.size
}