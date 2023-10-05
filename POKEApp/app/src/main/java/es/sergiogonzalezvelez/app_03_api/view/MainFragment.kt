package es.sergiogonzalezvelez.app_03_api.view

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.viewModels
import androidx.navigation.NavController
import androidx.navigation.findNavController
import coil.load
import es.sergiogonzalezvelez.app_03_api.databinding.FragmentMainBinding
import es.sergiogonzalezvelez.app_03_api.model.Pokemon
import es.sergiogonzalezvelez.app_03_api.viewmodel.PokemonViewModel

class MainFragment : Fragment() {
    private lateinit var binding: FragmentMainBinding
    private val viewModel: PokemonViewModel by viewModels()
    private lateinit var navController: NavController
    private lateinit var pokemon: Pokemon

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View {
        binding = FragmentMainBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        navController = view.findNavController()

        viewModel.cargarDatos()

        viewModel.pokeLiveData.observe(viewLifecycleOwner) {
            binding.pokeName.text = it.nombre.substring(0,1).uppercase() + it.nombre.substring(1)
            val tipo1 = it.tipos[0].tipos.get("name")
            var tipo2 = ""
            if(it.tipos.size > 1) {
                tipo2 = it.tipos[1].tipos.get("name").toString()
            }
            binding.tipo1.text = tipo1?.uppercase()
            binding.tipo2.text = tipo2.uppercase()

            binding.pokeImg.load(it.imagenes.front_default)
            pokemon = viewModel.pokeLiveData.value!!
        }

        binding.pokeName.setOnClickListener { viewModel.cargarNombre() }

        binding.btnRandom.setOnClickListener { viewModel.datosAleatorios() }
        binding.btnSiguiente.setOnClickListener { viewModel.datosSiguientes() }
        binding.btnAnterior.setOnClickListener { viewModel.datosAnteriores() }
        binding.pokeImg.setOnClickListener { navController.navigate(MainFragmentDirections.actionMainFragmentToDetalleFragment(pokemon)) }
    }
}