package com.intermodular.guardiapp.view

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.activityViewModels
import androidx.lifecycle.viewModelScope
import androidx.recyclerview.widget.DividerItemDecoration
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import com.intermodular.guardiapp.R
import com.intermodular.guardiapp.databinding.FragmentAvisosBinding
import com.intermodular.guardiapp.model.Profesor
import com.intermodular.guardiapp.viewmodel.AvisoGuardiaViewModel
import com.intermodular.guardiapp.viewmodel.ProfesorViewModel
import kotlinx.coroutines.launch

class FragmentAvisos : Fragment() {

    private lateinit var binding: FragmentAvisosBinding
    private val viewModelProfesor: ProfesorViewModel by activityViewModels()
    private val viewModelGuardia: AvisoGuardiaViewModel by activityViewModels()

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View? {
        binding = FragmentAvisosBinding.inflate(inflater,container,false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        val profesor: Profesor = viewModelProfesor.profesorLiveData.value!!
        viewModelProfesor.getAvisos(profesor.id)

        viewModelProfesor.avisosLiveData.observe(viewLifecycleOwner){
            binding.recyclerAvisos.apply {
                adapter = AvisoAdapter(it, viewModelGuardia)
                layoutManager = LinearLayoutManager(context)
            }
        }
    }

}