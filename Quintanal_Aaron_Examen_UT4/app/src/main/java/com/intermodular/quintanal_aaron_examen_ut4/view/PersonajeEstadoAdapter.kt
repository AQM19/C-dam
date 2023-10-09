package com.intermodular.quintanal_aaron_examen_ut4.view

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import coil.load
import com.intermodular.quintanal_aaron_examen_ut4.R
import com.intermodular.quintanal_aaron_examen_ut4.databinding.CasaAdapterBinding
import com.intermodular.quintanal_aaron_examen_ut4.databinding.PersonajeEstadoAdapterBinding
import com.intermodular.quintanal_aaron_examen_ut4.model.Casa
import com.intermodular.quintanal_aaron_examen_ut4.model.Personaje

class PersonajeEstadoAdapter(
    private val listaPersonajesVivos: List<Personaje>,
    private val onClickMuerte: (Personaje) -> Unit ): RecyclerView.Adapter<PersonajeEstadoAdapter.EntityViewHolder>()
{
    class EntityViewHolder(view: View): RecyclerView.ViewHolder(view){
        private val binding = PersonajeEstadoAdapterBinding.bind(view)

        fun bind(personaje: Personaje, onClickMuerte: (Personaje) -> Unit){
            val userAgent = "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko)Chrome/108.0.0.0 Safari/537.36"
            val url = personaje.imagen
            binding.imagePersonaje.load(url){addHeader("User-Agent", userAgent)}
            binding.textViewNombre.text = personaje.nombre
            binding.imageViewMuerte.setOnClickListener { onClickMuerte(personaje) }
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): EntityViewHolder {
        val adapterLayout = LayoutInflater.from(parent.context).inflate(R.layout.personaje_estado_adapter, parent, false)
        return EntityViewHolder(adapterLayout)
    }
    override fun onBindViewHolder(holder: EntityViewHolder, position: Int) {
        val entity = listaPersonajesVivos[position]
        holder.bind(entity, onClickMuerte)
    }

    override fun getItemCount(): Int = listaPersonajesVivos.size
}