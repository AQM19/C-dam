package es.sergiogonzalezvelez.app_03_api.view

import android.app.AlertDialog
import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.viewModels
import androidx.navigation.NavController
import androidx.navigation.findNavController
import androidx.recyclerview.widget.DividerItemDecoration
import androidx.recyclerview.widget.LinearLayoutManager
import coil.load
import es.sergiogonzalezvelez.app_03_api.databinding.FragmentDetalleBinding
import es.sergiogonzalezvelez.app_03_api.model.poke.Movimientos
import es.sergiogonzalezvelez.app_03_api.model.Pokemon
import es.sergiogonzalezvelez.app_03_api.model.poke.Habilidades
import es.sergiogonzalezvelez.app_03_api.viewmodel.PokemonViewModel

class DetalleFragment : Fragment() {
    private lateinit var binding: FragmentDetalleBinding
    private val viewModel: PokemonViewModel by viewModels()
    private lateinit var poke: Pokemon
    private lateinit var navController: NavController

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        arguments?.let {
            poke = it.get("poke") as Pokemon
        }
    }

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View {
        binding = FragmentDetalleBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        navController = view.findNavController()

        binding.pokeName.text = poke.nombre.substring(0, 1).uppercase() + poke.nombre.substring(1)
        val tipo1 = poke.tipos[0].tipos.get("name")
        var tipo2 = ""
        if (poke.tipos.size > 1) {
            tipo2 = poke.tipos[1].tipos.get("name").toString()
        }
        binding.tipo1.text = tipo1?.uppercase()
        binding.tipo2.text = tipo2.uppercase()

        binding.img1.load(poke.imagenes.front_default)
        binding.img2.load(poke.imagenes.back_default)
        binding.img3.load(poke.imagenes.front_shiny)
        binding.img4.load(poke.imagenes.back_shiny)

        binding.recyclerAtaques.apply {
            adapter = AtaquesAdapter(poke.movimientos) { movimiento -> onClickAtaque(movimiento) }
            layoutManager = LinearLayoutManager(context)
            addItemDecoration(DividerItemDecoration(context, DividerItemDecoration.VERTICAL))
        }

        binding.recyclerHabilidades.apply {
            adapter =
                HabilidadesAdapter(poke.habilidades) { habilidad -> onClickHabilidad(habilidad) }
            layoutManager = LinearLayoutManager(context)
            addItemDecoration(DividerItemDecoration(context, DividerItemDecoration.VERTICAL))
        }
    }

    fun onClickAtaque(movimiento: Movimientos) {
        val url = (movimiento.movimiento.get("url") as String).substring(31)
        val accion = DetalleFragmentDirections.actionDetalleFragmentToAtaqueFragment(url)

        navController.navigate(accion)
    }

    fun onClickHabilidad(habilidad: Habilidades) {
        val url = (habilidad.habilidad.get("url") as String).substring(34)
        var nombre = ""
        var efecto = ""
        viewModel.cargarHabilidad(url)

        viewModel.habilidadLiveData.observe(viewLifecycleOwner) {
            nombre = it.nombre.substring(0, 1).uppercase() + it.nombre.substring(1)
            efecto = it.efecto.filter { e -> e.idioma.get("name") == "en" }.first().efecto

            val builder = AlertDialog.Builder(context)
            with(builder) {
                setTitle(nombre)
                setMessage(efecto)
                setPositiveButton("OK", null)
            }
            val dialog = builder.create()
            dialog.show()
        }
    }
}