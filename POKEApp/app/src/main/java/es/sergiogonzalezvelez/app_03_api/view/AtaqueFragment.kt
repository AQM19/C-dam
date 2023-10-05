package es.sergiogonzalezvelez.app_03_api.view

import android.annotation.SuppressLint
import android.os.Bundle
import android.text.method.ScrollingMovementMethod
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.viewModels
import es.sergiogonzalezvelez.app_03_api.databinding.FragmentAtaqueBinding
import es.sergiogonzalezvelez.app_03_api.viewmodel.PokemonViewModel

class AtaqueFragment : Fragment() {
    private lateinit var binding: FragmentAtaqueBinding
    private val viewModel: PokemonViewModel by viewModels()
    private lateinit var path: String

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        arguments?.let {
            path = it.get("path") as String
        }
    }

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View {
        binding = FragmentAtaqueBinding.inflate(inflater, container, false)

        return binding.root
    }

    @SuppressLint("SetTextI18n")
    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        binding.textoDesc.movementMethod = ScrollingMovementMethod()

        viewModel.cargarAtaque(path)

        viewModel.ataqueLiveData.observe(viewLifecycleOwner) {
            binding.apply {
                nombreAtaque.text = it.nombre.substring(0, 1).uppercase() + it.nombre.substring(1)
                textoDesc.text = it.efecto[0].descripcion.substring(0, 1).uppercase() + it.efecto[0].descripcion.substring(1)
                modoAtaque.text = "Modo: ${it.modoAtaque.tipo}."
                textoPrecision.text = "Precisión: ${it.precision}%."
                textoUsos.text = "Usos: ${it.usos} pp."
                textoPotencia.text = "Potencia: ${it.potencia}."
                textoTipo.text = "Tipo: ${it.tipo.tipo}."
            }
        }
    }
}