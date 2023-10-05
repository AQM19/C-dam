package com.intermodular.guardiapp.view

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Toast
import androidx.core.widget.addTextChangedListener
import androidx.fragment.app.Fragment
import androidx.fragment.app.activityViewModels
import androidx.navigation.findNavController
import com.intermodular.guardiapp.R
import com.intermodular.guardiapp.databinding.FragmentMotivosGuardiaBinding
import com.intermodular.guardiapp.viewmodel.AvisoGuardiaViewModel

class FragmentMotivosGuardia : Fragment() {

    private lateinit var binding: FragmentMotivosGuardiaBinding
    private val viewModelGuardia: AvisoGuardiaViewModel by activityViewModels()

    override fun onStart() {
        super.onStart()
        if(viewModelGuardia.motivo.value != null){
            binding.editTextMotivo.setText(viewModelGuardia.motivo.value)
        }
        if(viewModelGuardia.observaciones.value != null){
            binding.editTextTextMultiLineObservaciones.setText(viewModelGuardia.observaciones.value)
        }

        if(viewModelGuardia.confirmado.value != null){
            binding.checkBoxConfirmacion.isChecked = viewModelGuardia.confirmado.value!!
        }
    }

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View? {
        binding = FragmentMotivosGuardiaBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        binding.viewModel = viewModelGuardia
        binding.lifecycleOwner = viewLifecycleOwner


        binding.botonSiguiente.setOnClickListener {
            viewModelGuardia.setMotivo(binding.editTextMotivo.text.toString())
            viewModelGuardia.setObservaciones(binding.editTextTextMultiLineObservaciones.text.toString())
            viewModelGuardia.setConfirmado(binding.checkBoxConfirmacion.isChecked)
            view.findNavController().navigate(R.id.fragmentHorarioGuardia)
        }
    }
}