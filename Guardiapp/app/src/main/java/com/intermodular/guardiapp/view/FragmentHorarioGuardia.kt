package com.intermodular.guardiapp.view

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.activityViewModels
import androidx.navigation.findNavController
import androidx.recyclerview.widget.DividerItemDecoration
import androidx.recyclerview.widget.LinearLayoutManager
import com.intermodular.guardiapp.R
import com.intermodular.guardiapp.databinding.FragmentHorarioGuardiaBinding
import com.intermodular.guardiapp.model.Horario
import com.intermodular.guardiapp.viewmodel.AvisoGuardiaViewModel
import com.intermodular.guardiapp.viewmodel.ProfesorViewModel
import java.util.LinkedList

class FragmentHorarioGuardia : Fragment() {

    private lateinit var binding: FragmentHorarioGuardiaBinding
    private val viewModelGuardia: AvisoGuardiaViewModel by activityViewModels()
    private val viewModelProfesor: ProfesorViewModel by activityViewModels()
    private lateinit var horarioAdapter: HorarioAdapter

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View? {
        binding = FragmentHorarioGuardiaBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        viewModelProfesor.getHorarioProfesor(viewModelProfesor.profesorLiveData.value!!.id)

        viewModelProfesor.horariosLiveData.observe(viewLifecycleOwner){
            horarioAdapter = HorarioAdapter(it)
            binding.recyclerViewHorario.apply{
                adapter = horarioAdapter
                layoutManager = LinearLayoutManager(context)
                addItemDecoration(DividerItemDecoration(context,DividerItemDecoration.VERTICAL))
            }
        }

        binding.buttonDiaCompleto.setOnClickListener{
            for(i in 0 until horarioAdapter.itemCount){
                val viewHolder = binding.recyclerViewHorario.findViewHolderForAdapterPosition(i) as HorarioAdapter.HorarioViewHolder
                viewHolder.binding.checkFalta.isChecked = binding.buttonDiaCompleto.isChecked
            }
        }

        binding.button.setOnClickListener {
            val horariosSeleccionados = mutableListOf<Horario>()
            for (i in 0 until horarioAdapter.itemCount) {
                val viewHolder = binding.recyclerViewHorario.findViewHolderForAdapterPosition(i) as HorarioAdapter.HorarioViewHolder
                if (viewHolder.binding.checkFalta.isChecked) {
                    horariosSeleccionados.add(horarioAdapter.getItem(i))
                }
            }
            viewModelGuardia.setHorario(horariosSeleccionados)
            view.findNavController().navigate(R.id.fragmentResumen)
        }
    }

}