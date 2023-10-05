package com.example.btells.view

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import com.example.btells.R
import com.example.btells.databinding.EscarabajoItemBinding
import com.example.btells.model.Escarabajo

class EscarabajoAdapter(private val listaEscarabajo: List<Escarabajo>): RecyclerView.Adapter<EscarabajoAdapter.EscarabajoViewHolder>() {

    class EscarabajoViewHolder(view: View): RecyclerView.ViewHolder(view) {
        private val binding = EscarabajoItemBinding.bind(view)

        fun bind(escarabajo: Escarabajo){
            binding.nombreEscarabajo.text = escarabajo.genus + " " + escarabajo.species
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): EscarabajoViewHolder {
        val adapterLayout = LayoutInflater.from(parent.context)
            .inflate(R.layout.escarabajo_item, parent, false)

        return EscarabajoViewHolder(adapterLayout)
    }

    override fun onBindViewHolder(holder: EscarabajoViewHolder, position: Int) {
        val escarabajo = listaEscarabajo[position]
        holder.bind(escarabajo)
    }

    override fun getItemCount(): Int = listaEscarabajo.size

}