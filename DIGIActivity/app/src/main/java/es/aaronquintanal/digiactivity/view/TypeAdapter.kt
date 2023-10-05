package es.aaronquintanal.digiactivity.view

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import es.aaronquintanal.digiactivity.R
import es.aaronquintanal.digiactivity.databinding.ActivityTypeAdapterBinding
import es.aaronquintanal.digiactivity.model.DigiType

class TypeAdapter(private val types: List<DigiType>): RecyclerView.Adapter<TypeAdapter.TypeViewHolder>(){

    class TypeViewHolder(view: View): RecyclerView.ViewHolder(view){
        private val binding = ActivityTypeAdapterBinding.bind(view)

        fun bind(type: DigiType){
            binding.textViewType.text = type.type
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): TypeViewHolder {
        val adapterLayout = LayoutInflater.from(parent.context)
            .inflate(R.layout.activity_type_adapter, parent, false)
        return TypeViewHolder(adapterLayout)
    }

    override fun onBindViewHolder(holder: TypeViewHolder, position: Int) {
        val type = types[position]
        holder.bind(type)
    }

    override fun getItemCount(): Int = types.size
}