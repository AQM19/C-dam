package es.aaronquintanal.app_ut2_06

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Toast
import androidx.fragment.app.activityViewModels
import androidx.navigation.fragment.findNavController
import es.aaronquintanal.app_ut2_06.databinding.FragmentResumenBinding

class FragmentResumen : Fragment() {

    private lateinit var binding: FragmentResumenBinding
    private val viewModelCompartido: ReservaZooViewModel by activityViewModels()

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View? {
        binding = FragmentResumenBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        binding.viewModel = viewModelCompartido

        binding.botonReservar.setOnClickListener {
            Toast.makeText(context, "Se ha realidazo la reserva", Toast.LENGTH_LONG).show()
            viewModelCompartido.resetearReserva()
            findNavController().navigate(R.id.action_fragmentResumen_to_fragmentInicio)
        }
    }

}