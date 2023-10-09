package com.example.digifragmentv2.view

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import com.example.digifragmentv2.R
import com.example.digifragmentv2.databinding.FragmentFieldAdapterBinding
import com.example.digifragmentv2.model.DigiFields

class FieldAdapter(private val fields: List<DigiFields>): RecyclerView.Adapter<FieldAdapter.FieldViewHolder>(){

    class FieldViewHolder(view: View): RecyclerView.ViewHolder(view){
        private val binding = FragmentFieldAdapterBinding.bind(view)

        fun bind(field: DigiFields){
            binding.imageViewField.setImageResource(getImage(field.id))
        }

        private fun getImage(id: Int): Int {
            when(id){
                1 -> return R.drawable.nature_spirits
                2 -> return R.drawable.virus_busters
                3 -> return R.drawable.wind_guardians
                4 -> return R.drawable.unknown
                5 -> return R.drawable.metal_empire
                6 -> return R.drawable.deep_savers
                7 -> return R.drawable.dark_area
                8 -> return R.drawable.nightmare_soldiers
                9 -> return R.drawable.dragon_s_roar
                10 -> return R.drawable.jungle_troopers
            }
            return -1
        }
    }


    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): FieldViewHolder {
        val adapterLayout = LayoutInflater.from(parent.context)
            .inflate(R.layout.fragment_field_adapter, parent, false)
        return FieldViewHolder(adapterLayout)
    }

    override fun onBindViewHolder(holder: FieldViewHolder, position: Int) {
        val field = fields[position]
        holder.bind(field)
    }

    override fun getItemCount(): Int = fields.size

}