package es.intermodular.app_04_03.view

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.core.content.ContextCompat
import androidx.recyclerview.widget.RecyclerView
import es.intermodular.app_04_03.R
import es.intermodular.app_04_03.databinding.CriticasAdapterBinding
import es.intermodular.app_04_03.model.Critica

class CriticasAdapter(private val listaCriticas: List<Critica>): RecyclerView.Adapter<CriticasAdapter.CriticasViewHolder>()
{
    class CriticasViewHolder(view: View): RecyclerView.ViewHolder(view) {
        private val binding = CriticasAdapterBinding.bind(view)

        fun bind(critica: Critica){
            binding.textViewCritica.text = critica.texto
            val color = when(critica.valoracion)
            {
                "POS" -> R.color.LimeGreen
                "NEG" -> R.color.PaleVioletRed
                else -> R.color.Snow
            }
            binding.textViewCritica.setBackgroundColor(
                ContextCompat.getColor(binding.textViewCritica.context, color))
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): CriticasViewHolder {
        val adapterLayout = LayoutInflater.from(parent.context)
            .inflate(R.layout.criticas_adapter, parent, false)
        return CriticasViewHolder(adapterLayout)
    }

    override fun getItemCount(): Int = listaCriticas.size

    override fun onBindViewHolder(holder: CriticasViewHolder, position: Int) {
        val critica = listaCriticas[position]
        holder.bind(critica)
    }

}