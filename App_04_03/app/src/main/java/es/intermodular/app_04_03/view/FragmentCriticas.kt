package es.intermodular.app_04_03.view

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.activityViewModels
import androidx.recyclerview.widget.LinearLayoutManager
import es.intermodular.app_04_03.databinding.FragmentCriticasBinding
import es.intermodular.app_04_03.viewmodel.PeliculasViewModel

@Suppress("UNREACHABLE_CODE") //Para quitar lo amarillo tan molesto
class FragmentCriticas : Fragment() {

    private val peliculasViewModel: PeliculasViewModel by activityViewModels { PeliculasViewModel.Factory}
    private lateinit var binding: FragmentCriticasBinding
    private var idPelicula: Long = 0

    override fun onCreate(savedInstanceState: Bundle?)
    {
        super.onCreate(savedInstanceState)
        arguments?.let {
            idPelicula = it.getLong("peliculaId")
        }
    }

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View {
        binding = FragmentCriticasBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        peliculasViewModel.getCriticas(idPelicula).observe(viewLifecycleOwner) {
            with (binding.recyclerViewCriticas){
                adapter = CriticasAdapter(it)
                layoutManager = LinearLayoutManager(context)
            }
        }
    }


}