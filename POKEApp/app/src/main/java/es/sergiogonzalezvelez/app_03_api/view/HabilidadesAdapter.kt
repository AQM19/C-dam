package es.sergiogonzalezvelez.app_03_api.view

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import es.sergiogonzalezvelez.app_03_api.R
import es.sergiogonzalezvelez.app_03_api.databinding.RecyclerItemBinding
import es.sergiogonzalezvelez.app_03_api.model.poke.Habilidades

class HabilidadesAdapter(private val habilidades: List<Habilidades>, private val onClickItem: (Habilidades) -> Unit): RecyclerView.Adapter<HabilidadesAdapter.HabilidadViewHolder>() {

    class HabilidadViewHolder(view: View) : RecyclerView.ViewHolder(view) {
        private val binding = RecyclerItemBinding.bind(view)

        fun bind(habilidad: Habilidades, onClickItem: (Habilidades) -> Unit) {
            binding.itemName.text = habilidad.habilidad.get("name")

            binding.itemName.setOnClickListener { onClickItem(habilidad) }
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): HabilidadViewHolder {
        val adapterLayout = LayoutInflater.from(parent.context)
            .inflate(R.layout.recycler_item, parent, false)

        return HabilidadViewHolder(adapterLayout)
    }

    override fun onBindViewHolder(holder: HabilidadViewHolder, position: Int) {
        holder.bind(habilidades[position], onClickItem)
    }

    override fun getItemCount() = habilidades.size
}