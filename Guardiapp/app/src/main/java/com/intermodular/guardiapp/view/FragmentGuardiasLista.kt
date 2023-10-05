package com.intermodular.guardiapp.view

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.Fragment
import androidx.fragment.app.activityViewModels
import androidx.recyclerview.widget.LinearLayoutManager
import com.intermodular.guardiapp.databinding.FragmentGuardiasListaBinding
import com.intermodular.guardiapp.viewmodel.ProfesorViewModel

class FragmentGuardiasLista : Fragment() {

    private lateinit var binding: FragmentGuardiasListaBinding
    private val profeViewModel: ProfesorViewModel by activityViewModels()

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View {
        binding = FragmentGuardiasListaBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        profeViewModel.cargarGuardias()

        profeViewModel.guardiasLiveData.observe(viewLifecycleOwner){
            val guardias = it.sortedByDescending { x -> x.fecha }
            binding.recyclerEvolutions.apply {
                adapter = GuardiaAdapter(guardias, profeViewModel)
                layoutManager = LinearLayoutManager(context)
            }
        }
    }
}
