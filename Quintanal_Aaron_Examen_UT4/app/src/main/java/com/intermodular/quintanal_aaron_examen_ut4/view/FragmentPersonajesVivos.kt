package com.intermodular.quintanal_aaron_examen_ut4.view

import android.app.AlertDialog
import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Toast
import androidx.fragment.app.activityViewModels
import androidx.navigation.NavController
import androidx.navigation.findNavController
import androidx.recyclerview.widget.LinearLayoutManager
import com.intermodular.quintanal_aaron_examen_ut4.R
import com.intermodular.quintanal_aaron_examen_ut4.databinding.FragmentPersonajesVivosBinding
import com.intermodular.quintanal_aaron_examen_ut4.model.Personaje
import com.intermodular.quintanal_aaron_examen_ut4.viewmodel.JuegoTronosViewModel

class FragmentPersonajesVivos : Fragment() {

    lateinit var binding: FragmentPersonajesVivosBinding
    private val juegoTronosViewModel: JuegoTronosViewModel by activityViewModels { JuegoTronosViewModel.Factory }
    private lateinit var navController: NavController

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View? {
        binding = FragmentPersonajesVivosBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        navController = view.findNavController()

        juegoTronosViewModel.personajesVivos.observe(viewLifecycleOwner){
            binding.recyclerViewPersonajesVivos.apply {
                adapter = PersonajeEstadoAdapter(it, { personaje -> onClickMuerte(personaje) })
                layoutManager = LinearLayoutManager(context)
            }
        }
    }

    private fun onClickMuerte(personaje: Personaje){
        AlertDialog.Builder(context)
            .setTitle("¿Matar a ${personaje.nombre}?")
            .setMessage("¿Está seguro que desea matar a ${personaje.nombre}?")
            .setNegativeButton("No") { _,_ ->
                Toast.makeText(context, "No se ha conseguido matar a ${personaje.nombre}", Toast.LENGTH_LONG).show()
            }
            .setPositiveButton("Si") { _,_ ->
                juegoTronosViewModel.hacerseUnRRMartin(personaje.personajeId)
            }.show()
    }
}