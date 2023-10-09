package es.aaronquintanal.digiactivity.view

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import es.aaronquintanal.digiactivity.R
import es.aaronquintanal.digiactivity.databinding.ActivityLevelAdapterBinding
import es.aaronquintanal.digiactivity.model.DigiLevel

class LevelAdapter(private val levels: List<DigiLevel>) : RecyclerView.Adapter<LevelAdapter.LevelViewHolder>(){

    class LevelViewHolder(view: View): RecyclerView.ViewHolder(view){
        private val binding = ActivityLevelAdapterBinding.bind(view)

        fun bind(level: DigiLevel){
            binding.textViewLevel.text = level.level
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): LevelViewHolder {
        val adapterLayout = LayoutInflater.from(parent.context)
            .inflate(R.layout.activity_level_adapter, parent, false)
        return LevelViewHolder(adapterLayout)
    }

    override fun onBindViewHolder(holder: LevelViewHolder, position: Int) {
        val level = levels[position];
        holder.bind(level)
    }

    override fun getItemCount(): Int = levels.size
}