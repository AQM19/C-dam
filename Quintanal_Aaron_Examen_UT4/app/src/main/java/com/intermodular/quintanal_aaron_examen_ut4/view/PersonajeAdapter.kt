package com.intermodular.quintanal_aaron_examen_ut4.view

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import coil.load
import com.intermodular.quintanal_aaron_examen_ut4.R
import com.intermodular.quintanal_aaron_examen_ut4.databinding.PersonajeAdapterBinding
import com.intermodular.quintanal_aaron_examen_ut4.model.Casa
import com.intermodular.quintanal_aaron_examen_ut4.model.Personaje
import com.intermodular.quintanal_aaron_examen_ut4.view.PersonajeAdapter.EntityViewHolder

class PersonajeAdapter(
    private val listaPersonajes: List<Personaje>,
    private val onClickPersonaje: (Personaje) -> Unit
): RecyclerView.Adapter<PersonajeAdapter.EntityViewHolder>() {
    class EntityViewHolder(view:View): RecyclerView.ViewHolder(view) {
        private val binding = PersonajeAdapterBinding.bind(view)

        fun bind(personaje: Personaje, onClickPersonaje: (Personaje) -> Unit){
            val userAgent = "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko)Chrome/108.0.0.0 Safari/537.36"
            val url = personaje.imagen
            binding.imageViewImagen.load(url){addHeader("User-Agent", userAgent)}

            binding.textViewTitulo.text = personaje.titulo
            binding.textViewAlias.text = personaje.alias
            binding.textViewEstado.text = personaje.estado

            binding.personaje.setOnClickListener {
                onClickPersonaje(personaje)
            }
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): EntityViewHolder {
        val adapterLayout = LayoutInflater.from(parent.context).inflate(R.layout.personaje_adapter, parent, false)
        return EntityViewHolder(adapterLayout)
    }

    override fun onBindViewHolder(holder: EntityViewHolder, position: Int) {
        val entity = listaPersonajes[position]
        holder.bind(entity, onClickPersonaje)
    }

    override fun getItemCount(): Int = listaPersonajes.size

}