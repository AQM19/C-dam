package com.example.digifragment.view

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import com.example.digifragment.R
import com.example.digifragment.databinding.RecyclerItemDummyBinding
import com.example.digifragment.model.DigiType

class TypeAdapter(private val types: List<DigiType>): RecyclerView.Adapter<TypeAdapter.TypeViewHolder>(){

    class TypeViewHolder(view: View): RecyclerView.ViewHolder(view){
        private val binding = RecyclerItemDummyBinding.bind(view)

        fun bind(type: DigiType){
            binding.textViewType.text = type.type
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): TypeViewHolder {
        val adapterLayout = LayoutInflater.from(parent.context)
            .inflate(R.layout.recycler_item_dummy, parent, false)
        return TypeViewHolder(adapterLayout)
    }

    override fun onBindViewHolder(holder: TypeViewHolder, position: Int) {
        val type = types[position]
        holder.bind(type)
    }

    override fun getItemCount(): Int = types.size
}