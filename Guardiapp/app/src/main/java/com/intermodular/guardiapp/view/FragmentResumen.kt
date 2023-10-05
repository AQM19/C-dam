package com.intermodular.guardiapp.view

import android.annotation.SuppressLint
import android.app.AlertDialog
import android.os.Build
import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Toast
import androidx.annotation.RequiresApi
import androidx.fragment.app.Fragment
import androidx.fragment.app.activityViewModels
import androidx.lifecycle.viewModelScope
import androidx.navigation.findNavController
import com.intermodular.guardiapp.R
import com.intermodular.guardiapp.databinding.FragmentResumenBinding
import com.intermodular.guardiapp.model.AvisoGuardia
import com.intermodular.guardiapp.model.Horario
import com.intermodular.guardiapp.model.Profesor
import com.intermodular.guardiapp.viewmodel.AvisoGuardiaViewModel
import com.intermodular.guardiapp.viewmodel.ProfesorViewModel
import kotlinx.coroutines.launch
import java.sql.Date
import java.sql.Time
import java.time.LocalDate
import java.time.LocalDateTime


class FragmentResumen : Fragment() {
    private lateinit var binding: FragmentResumenBinding
    private val viewModelGuardia: AvisoGuardiaViewModel by activityViewModels()
    private val viewModelProfesor: ProfesorViewModel by activityViewModels()

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View {
        binding = FragmentResumenBinding.inflate(inflater, container, false)
        return binding.root
    }

    @SuppressLint("SetTextI18n")
    @RequiresApi(Build.VERSION_CODES.O)
    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        binding.textViewProfesor.text = "Profesor: ${viewModelProfesor.profesorLiveData.value!!.nombre} ${viewModelProfesor.profesorLiveData.value!!.ape1} ${viewModelProfesor.profesorLiveData.value!!.ape2}"
        binding.textViewFecha.text = "Fecha: ${viewModelGuardia.fechaAviso.value}"
        binding.textViewMotivo.text = "Motivo: ${viewModelGuardia.motivo.value}"
        binding.textViewObservaciones.text = "Observaciones: ${viewModelGuardia.observaciones.value}"

        if(viewModelGuardia.horario.value != null){
            var horas = ""
            viewModelGuardia.horario.value!!.forEach {
                horas += "\t${it.hora}ª hora\n"
            }
            binding.textViewHorarios.text = horas
        }

        binding.buttonAvisarGuardia.setOnClickListener {
            AlertDialog.Builder(context)
                .setTitle("¿Confirmar aviso de guardia?")
                .setMessage("¿Está seguro que desea confirmar el aviso de guardia?")
                .setNegativeButton("No") { _,_ ->
                    Toast.makeText(context, "No ha realizado el aviso", Toast.LENGTH_LONG).show()
                }
                .setPositiveButton("Si") { _,_ ->
                    val tiempoActual = LocalDateTime.now()
                    val profesor: Profesor = viewModelProfesor.profesorLiveData.value!!

                    viewModelGuardia.setHoraAviso(tiempoActual.toString())
                    viewModelGuardia.setProfesor(profesor)

                    viewModelGuardia.horario.value!!.forEach{
                        //Toast.makeText(context, "Generando aviso", Toast.LENGTH_SHORT).show()
                        generarAviso(it)
                    }
                    view.findNavController().navigate(R.id.fragmentAvisos)
                }.show()
        }
    }

    @RequiresApi(Build.VERSION_CODES.O)
    private fun generarAviso(param: Horario){
        val profesor: Profesor = viewModelGuardia.profesor.value!!
        val motivo: String? = viewModelGuardia.motivo.value
        val observaciones: String? = viewModelGuardia.observaciones.value
        val confirmado: Boolean? = viewModelGuardia.confirmado.value
        val anulado: Boolean? = viewModelGuardia.anulado.value
        val fecha: String = viewModelGuardia.fechaAviso.value!!
        val tiempo: String = viewModelGuardia.horaAviso.value!!

        val aviso = AvisoGuardia(
            -1,
            profesor.id,
            param.id,
            motivo,
            observaciones,
            confirmado,
            anulado,
            fecha,
            tiempo
        )

        /*
        if(aviso.confirmado == true) {
            // generar guardia
        }
        */

        viewModelGuardia.viewModelScope.launch {
            viewModelGuardia.crearAviso(aviso)
        }
    }

}