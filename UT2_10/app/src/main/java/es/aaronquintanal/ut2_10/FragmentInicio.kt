package es.aaronquintanal.app_ut2_06

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Button
import androidx.navigation.findNavController
import es.aaronquintanal.ut2_10.R

class FragmentInicio : Fragment() {
    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        // Inflate the layout for this fragment
        return inflater.inflate(R.layout.fragment_inicio2, container, false)
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        val botonzoo : Button = view.findViewById<Button>(R.id.botonZoologico)
        val botonrep : Button = view.findViewById<Button>(R.id.botonReptario)
        val botongui : Button = view.findViewById<Button>(R.id.botonVisitaGuiada)
        val accion = R.id.action_fragmentInicio_to_fragmentPersonas

        botonzoo.setOnClickListener {
            view.findNavController().navigate(accion)
        }

        botonrep.setOnClickListener {
            view.findNavController().navigate(accion)
        }

        botongui.setOnClickListener {
            view.findNavController().navigate(accion)
        }
    }
}