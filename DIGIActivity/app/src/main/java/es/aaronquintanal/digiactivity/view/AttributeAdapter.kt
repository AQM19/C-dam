package es.aaronquintanal.digiactivity.view

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import es.aaronquintanal.digiactivity.R
import es.aaronquintanal.digiactivity.databinding.ActivityAttributeAdapterBinding
import es.aaronquintanal.digiactivity.model.DigiAttribute

class AttributeAdapter(private val attributes: List<DigiAttribute>): RecyclerView.Adapter<AttributeAdapter.AttributeViewHolder>() {


    class AttributeViewHolder(view: View): RecyclerView.ViewHolder(view){
        private val binding = ActivityAttributeAdapterBinding.bind(view)

        fun bind(attribute: DigiAttribute){
            binding.textViewAttribute.text = attribute.attribute
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): AttributeViewHolder {
        val adapterLayout = LayoutInflater.from(parent.context)
            .inflate(R.layout.activity_attribute_adapter, parent, false)
        return AttributeViewHolder(adapterLayout)
    }

    override fun onBindViewHolder(holder: AttributeViewHolder, position: Int) {
        val attribute = attributes[position]
        holder.bind(attribute)
    }

    override fun getItemCount(): Int = attributes.size

}