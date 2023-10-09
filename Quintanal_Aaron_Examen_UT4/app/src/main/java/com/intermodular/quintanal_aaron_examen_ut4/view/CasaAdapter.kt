package com.intermodular.quintanal_aaron_examen_ut4.view

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import coil.load
import com.intermodular.quintanal_aaron_examen_ut4.R
import com.intermodular.quintanal_aaron_examen_ut4.databinding.CasaAdapterBinding
import com.intermodular.quintanal_aaron_examen_ut4.model.Casa

class CasaAdapter(private val listaEntities: List<Casa>, private val onClickCasa: (Casa) -> Unit): RecyclerView.Adapter<CasaAdapter.EntityViewHolder>()
{
    class EntityViewHolder(view: View): RecyclerView.ViewHolder(view){
        private val binding = CasaAdapterBinding.bind(view)

        fun bind(casa: Casa, onClickCasa: (Casa) -> Unit){
            val userAgent = "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko)Chrome/108.0.0.0 Safari/537.36"
            val url = casa.imagen
            binding.imageCasa.load(url){addHeader("User-Agent", userAgent)}
            binding.textViewNameCasa.text = casa.titulo

            binding.layoutCasa.setOnClickListener { onClickCasa(casa) }
        }

    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): EntityViewHolder {
        val adapterLayout = LayoutInflater.from(parent.context)
            .inflate(R.layout.casa_adapter, parent, false)
        return EntityViewHolder(adapterLayout)
    }
    override fun onBindViewHolder(holder: EntityViewHolder, position: Int) {
        val entity = listaEntities[position]
        holder.bind(entity, onClickCasa)
    }

    override fun getItemCount(): Int = listaEntities.size
}