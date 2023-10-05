package com.example.digifragment.view

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import com.example.digifragment.R
import com.example.digifragment.databinding.FragmentSkillAdapterBinding
import com.example.digifragment.model.DigiSkill

class SkillAdapter(private val skills: List<DigiSkill>): RecyclerView.Adapter<SkillAdapter.SkillViewHolder>() {

    class SkillViewHolder(view: View): RecyclerView.ViewHolder(view){
        private val binding = FragmentSkillAdapterBinding.bind(view)

        fun bind(skill: DigiSkill){
            binding.textViewSkill.text = skill.skill
            binding.textViewDescription.text = skill.description
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): SkillViewHolder {
        val adapterLayout = LayoutInflater.from(parent.context)
            .inflate(R.layout.fragment_skill_adapter, parent, false)
        return SkillViewHolder(adapterLayout)
    }

    override fun onBindViewHolder(holder: SkillViewHolder, position: Int) {
        val skill = skills[position]
        holder.bind(skill)
    }

    override fun getItemCount(): Int = skills.size
}