package es.aaronquintanal.quintanal_aaron.view

import android.graphics.ColorSpace
import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.AdapterView
import android.widget.ArrayAdapter
import androidx.fragment.app.Fragment
import androidx.fragment.app.activityViewModels
import androidx.fragment.app.viewModels
import androidx.navigation.NavController
import androidx.navigation.findNavController
import androidx.recyclerview.widget.DividerItemDecoration
import androidx.recyclerview.widget.LinearLayoutManager
import es.aaronquintanal.quintanal_aaron.R
import es.aaronquintanal.quintanal_aaron.databinding.FragmentYacimientosBinding
import es.aaronquintanal.quintanal_aaron.model.Dino
import es.aaronquintanal.quintanal_aaron.viewmodel.DinosauriosViewModel

class fragmentYacimientos : Fragment() {

    private lateinit var binding: FragmentYacimientosBinding
    private lateinit var navController: NavController
    private val dinoViewModel: DinosauriosViewModel by activityViewModels()

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View? {
        binding = FragmentYacimientosBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        navController = view.findNavController()

        // Cargar Spinner
        val adapterSpinner = ArrayAdapter(requireContext(), android.R.layout.simple_spinner_item, dinoViewModel.getYacimientos())
        binding.spinner.adapter = adapterSpinner

        // Item Selected of Spinner
        binding.spinner.onItemSelectedListener = object: AdapterView.OnItemSelectedListener {
            override fun onItemSelected(parent: AdapterView<*>?, view: View?, position: Int, id: Long) {

                val pais = parent?.selectedItem.toString()

                dinoViewModel.dinosariosDeYacimiento(pais).observe(viewLifecycleOwner){
                    with(binding.recyclerLista){
                        adapter = DinoAdapter(it) {dino -> onClickDino(dino)}
                        layoutManager = LinearLayoutManager(context)
                        addItemDecoration(DividerItemDecoration(context, DividerItemDecoration.VERTICAL))
                    }
                }

            }

            override fun onNothingSelected(parent: AdapterView<*>?) {}
        }
    }

    private fun onClickDino(dino: Dino){
        navController.navigate(fragmentYacimientosDirections.actionFragmentYacimientosToFragmentDinosaurio(dino))
    }
}