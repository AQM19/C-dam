package com.intermodular.quintanal_aaron_examen_ut4.view

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.activityViewModels
import androidx.lifecycle.map
import androidx.navigation.NavController
import androidx.navigation.findNavController
import androidx.recyclerview.widget.LinearLayoutManager
import com.intermodular.quintanal_aaron_examen_ut4.R
import com.intermodular.quintanal_aaron_examen_ut4.databinding.FragmentCasasBinding
import com.intermodular.quintanal_aaron_examen_ut4.model.Casa
import com.intermodular.quintanal_aaron_examen_ut4.viewmodel.JuegoTronosViewModel

class FragmentCasas : Fragment() {

    private lateinit var binding: FragmentCasasBinding
    private val juegoTronosViewModel:JuegoTronosViewModel by activityViewModels { JuegoTronosViewModel.Factory }
    private lateinit var navController: NavController

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View? {
        binding = FragmentCasasBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        navController = view.findNavController()

        juegoTronosViewModel.casas.observe(viewLifecycleOwner){
            binding.recyclerViewCasas.apply {
                adapter = CasaAdapter(it, {casa -> onClickCasa(casa)})
                layoutManager = LinearLayoutManager(context)
            }
        }
    }

    private fun onClickCasa(casa: Casa){
        navController.navigate(FragmentCasasDirections.actionFragmentCasasToFragmentDetalleCasa(casa))
    }

}