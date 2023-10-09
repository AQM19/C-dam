package com.example.digifragmentv2.view

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import com.example.digifragmentv2.R
import com.example.digifragmentv2.databinding.RecyclerItemDummyBinding
import com.example.digifragmentv2.model.DigiLevel

class LevelAdapter(private val levels: List<DigiLevel>) : RecyclerView.Adapter<LevelAdapter.LevelViewHolder>(){

    class LevelViewHolder(view: View): RecyclerView.ViewHolder(view){
        private val binding = RecyclerItemDummyBinding.bind(view)

        fun bind(level: DigiLevel){
            binding.textViewType.text = level.level
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): LevelViewHolder {
        val adapterLayout = LayoutInflater.from(parent.context)
            .inflate(R.layout.recycler_item_dummy, parent, false)
        return LevelViewHolder(adapterLayout)
    }

    override fun onBindViewHolder(holder: LevelViewHolder, position: Int) {
        val level = levels[position];
        holder.bind(level)
    }

    override fun getItemCount(): Int = levels.size
}