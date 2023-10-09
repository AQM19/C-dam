package com.example.digifragmentv2.view

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.navigation.NavController
import androidx.navigation.findNavController
import androidx.recyclerview.widget.DividerItemDecoration
import androidx.recyclerview.widget.LinearLayoutManager
import com.example.digifragmentv2.databinding.FragmentLinearEvolutionsBinding
import com.example.digifragmentv2.model.Digi
import com.example.digifragmentv2.model.Digimon

class FragmentLinearEvolutions : Fragment() {

    private lateinit var binding: FragmentLinearEvolutionsBinding
    private lateinit var navController: NavController
    private lateinit var digimon: Digi
    private var pre: Boolean = false

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        arguments?.let {
            digimon = it.get("digimon") as Digi
            pre = it.get("pre") as Boolean
        }
    }

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View? {
        binding = FragmentLinearEvolutionsBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        navController = view.findNavController()

        binding.recyclerEvolutions.apply {
            when(pre){
                false -> adapter = EvolutionAdapter(digimon.nextEvolutions) { digimon -> onClickDigimon(digimon) }
                true -> adapter = EvolutionAdapter(digimon.priorEvolutions) { digimon -> onClickDigimon(digimon) }
            }
            layoutManager = LinearLayoutManager(context)
            addItemDecoration(DividerItemDecoration(context, DividerItemDecoration.VERTICAL))
        }
    }

    private fun onClickDigimon(digimon: Digimon){
        navController.navigate(FragmentLinearEvolutionsDirections.actionFragmentLinearEvolutionsToMainFragment(digimon))
    }
}