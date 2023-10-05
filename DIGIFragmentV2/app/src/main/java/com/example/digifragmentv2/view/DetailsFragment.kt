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
import coil.load
import com.example.digifragmentv2.R
import com.example.digifragmentv2.databinding.FragmentDetailsBinding
import com.example.digifragmentv2.model.Digi

class DetailsFragment : Fragment() {
    private lateinit var binding: FragmentDetailsBinding
    private lateinit var digimon: Digi
    private lateinit var navController: NavController

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        arguments?.let {
            digimon = it.get("digimon") as Digi
        }
    }

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View? {
        binding = FragmentDetailsBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        navController = view.findNavController()

        binding.digiDetailsName.text = digimon.name
        binding.digimonDetailsImage.load(digimon.images[0].href)

        binding.recyclerDetails.apply {
            adapter = SkillAdapter(digimon.skills)
            layoutManager = LinearLayoutManager(context)
            addItemDecoration(DividerItemDecoration(context, DividerItemDecoration.VERTICAL))
        }

        binding.buttonPostEvolutions.setOnClickListener {
            navController.navigate(DetailsFragmentDirections.actionDetailsFragmentToFragmentLinearEvolutions(digimon, false))
        }
        binding.buttonPreEvolutions.setOnClickListener {
            navController.navigate(DetailsFragmentDirections.actionDetailsFragmentToFragmentLinearEvolutions(digimon, true))
        }
    }
}
