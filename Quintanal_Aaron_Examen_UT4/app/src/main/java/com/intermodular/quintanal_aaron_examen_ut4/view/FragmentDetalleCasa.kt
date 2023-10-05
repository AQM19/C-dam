package com.intermodular.quintanal_aaron_examen_ut4.view

import android.app.AlertDialog
import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Toast
import androidx.fragment.app.activityViewModels
import androidx.navigation.findNavController
import androidx.recyclerview.widget.GridLayoutManager
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.StaggeredGridLayoutManager
import coil.load
import com.intermodular.quintanal_aaron_examen_ut4.R
import com.intermodular.quintanal_aaron_examen_ut4.databinding.FragmentDetalleCasaBinding
import com.intermodular.quintanal_aaron_examen_ut4.model.Casa
import com.intermodular.quintanal_aaron_examen_ut4.model.Personaje
import com.intermodular.quintanal_aaron_examen_ut4.viewmodel.JuegoTronosViewModel

class FragmentDetalleCasa : Fragment() {

    private val juegoTronosViewModel: JuegoTronosViewModel by activityViewModels {JuegoTronosViewModel.Factory}
    private lateinit var casa: Casa
    private lateinit var binding: FragmentDetalleCasaBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        arguments?.let {
            casa = it.get("casa") as Casa
        }
    }

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View? {
        binding = FragmentDetalleCasaBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        val userAgent = "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko)Chrome/108.0.0.0 Safari/537.36"
        val url = casa.imagen
        binding.ivLogo.load(url){addHeader("User-Agent", userAgent)}
        binding.tvTitulo.text = casa.titulo
        if(casa.lema != null) binding.tvLema.text = casa.lema else binding.tvLema.text = "Sin lema"
        if(casa.blason != null) binding.tvBlason.text = casa.blason else binding.tvBlason.text = "Sin blasón"
        binding.tvLugar.text = casa.lugar
        binding.tvRegion.text = casa.region

        binding.ivPapelera.setOnClickListener {
            AlertDialog.Builder(context)
                .setTitle("¿Borrar casa?")
                .setMessage("¿Está seguro que desea borrar la casa ${casa.nombre}?")
                .setNegativeButton("No") { _,_ ->
                    Toast.makeText(context, "No se ha conseguido borrar la casa ${casa.nombre}", Toast.LENGTH_LONG).show()
                }
                .setPositiveButton("Si") { _,_ ->
                    juegoTronosViewModel.borrarCasaPersonajes(casa.casaId)
                    juegoTronosViewModel.borrarCasa(casa)
                    view.findNavController().navigate(R.id.fragmentCasas)
                }.show()
        }

        juegoTronosViewModel.getPersonajesCasa(casa.casaId).observe(viewLifecycleOwner){
            binding.recyclerViewPersonajesCasa.apply {
                adapter = PersonajeAdapter(it, { personaje -> onClickPersonaje(personaje) })
                layoutManager = GridLayoutManager(context,2)
            }
        }
    }

    fun onClickPersonaje(personaje: Personaje){
        Toast.makeText(context, personaje.actor, Toast.LENGTH_LONG).show()
    }

}