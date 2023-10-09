package es.aaronquintanal.digiactivity.view

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import es.aaronquintanal.digiactivity.R
import es.aaronquintanal.digiactivity.databinding.ActivitySkillAdapterBinding
import es.aaronquintanal.digiactivity.model.DigiSkill

class SkillAdapter(private val skills: List<DigiSkill>): RecyclerView.Adapter<SkillAdapter.SkillViewHolder>() {

    class SkillViewHolder(view: View): RecyclerView.ViewHolder(view){
        private val binding = ActivitySkillAdapterBinding.bind(view)

        fun bind(skill: DigiSkill){
            binding.textViewSkill.text = skill.skill
            binding.textViewDescription.text = skill.description
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): SkillViewHolder {
        val adapterLayout = LayoutInflater.from(parent.context)
            .inflate(R.layout.activity_skill_adapter, parent, false)
        return SkillViewHolder(adapterLayout)
    }

    override fun onBindViewHolder(holder: SkillViewHolder, position: Int) {
        val skill = skills[position]
        holder.bind(skill)
    }

    override fun getItemCount(): Int = skills.size
}