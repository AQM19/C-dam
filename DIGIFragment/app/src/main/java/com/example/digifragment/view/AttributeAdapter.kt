package com.example.digifragment.view

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import com.example.digifragment.R
import com.example.digifragment.databinding.RecyclerItemDummyBinding
import com.example.digifragment.model.DigiAttribute

class AttributeAdapter(private val attributes: List<DigiAttribute>): RecyclerView.Adapter<AttributeAdapter.AttributeViewHolder>() {


    class AttributeViewHolder(view: View): RecyclerView.ViewHolder(view){
        private val binding = RecyclerItemDummyBinding.bind(view)

        fun bind(attribute: DigiAttribute){
            binding.textViewType.text = attribute.attribute
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): AttributeViewHolder {
        val adapterLayout = LayoutInflater.from(parent.context)
            .inflate(R.layout.recycler_item_dummy, parent, false)
        return AttributeViewHolder(adapterLayout)
    }

    override fun onBindViewHolder(holder: AttributeViewHolder, position: Int) {
        val attribute = attributes[position]
        holder.bind(attribute)
    }

    override fun getItemCount(): Int = attributes.size

}