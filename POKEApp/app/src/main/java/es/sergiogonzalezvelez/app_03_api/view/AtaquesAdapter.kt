package es.sergiogonzalezvelez.app_03_api.view

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import es.sergiogonzalezvelez.app_03_api.R
import es.sergiogonzalezvelez.app_03_api.databinding.RecyclerItemBinding
import es.sergiogonzalezvelez.app_03_api.model.poke.Habilidades
import es.sergiogonzalezvelez.app_03_api.model.poke.Movimientos

class AtaquesAdapter(
    private val movimientos: List<Movimientos>,
    private val onClickItem: (Movimientos) -> Unit
) : RecyclerView.Adapter<AtaquesAdapter.AtaqueViewHolder>() {

    class AtaqueViewHolder(view: View) : RecyclerView.ViewHolder(view) {
        private val binding = RecyclerItemBinding.bind(view)

        fun bind(movimiento: Movimientos, onClickItem: (Movimientos) -> Unit) {
            binding.itemName.text = movimiento.movimiento.get("name")
            binding.root.setOnClickListener{onClickItem(movimiento)}
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): AtaqueViewHolder {
        val adapterLayout = LayoutInflater.from(parent.context)
            .inflate(R.layout.recycler_item, parent, false)

        return AtaqueViewHolder(adapterLayout)
    }

    override fun onBindViewHolder(holder: AtaqueViewHolder, position: Int) {
        holder.bind(movimientos[position], onClickItem)
    }

    override fun getItemCount() = movimientos.size
}