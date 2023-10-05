package com.intermodular.guardiapp.view

import android.os.Build
import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Toast
import androidx.annotation.RequiresApi
import androidx.fragment.app.Fragment
import androidx.fragment.app.activityViewModels
import androidx.navigation.findNavController
import com.intermodular.guardiapp.R
import com.intermodular.guardiapp.databinding.FragmentFechaBinding
import com.intermodular.guardiapp.viewmodel.AvisoGuardiaViewModel
import com.intermodular.guardiapp.viewmodel.ProfesorViewModel
import java.time.LocalDate
import java.util.*

class FragmentFecha : Fragment() {

    private lateinit var binding: FragmentFechaBinding
    private val viewModelGuardia: AvisoGuardiaViewModel by activityViewModels()

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View {
        binding = FragmentFechaBinding.inflate(inflater, container, false)
        return binding.root
    }

    @RequiresApi(Build.VERSION_CODES.O)
    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        binding.viewModel = viewModelGuardia
        binding.lifecycleOwner = viewLifecycleOwner

        binding.datePicker.apply {
                viewModelGuardia.setFechaAviso(LocalDate.now().toString())
            }

            binding.botonSiguiente.setOnClickListener{
                view.findNavController().navigate(R.id.fragmentMotivosGuardia)
            }
        }
    }