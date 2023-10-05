package es.aaronquintanal.app_ut2_08.view

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.AdapterView
import android.widget.ArrayAdapter
import android.widget.Toast
import androidx.fragment.app.activityViewModels
import androidx.recyclerview.widget.DividerItemDecoration
import androidx.recyclerview.widget.LinearLayoutManager
import es.aaronquintanal.app_ut2_08.R
import es.aaronquintanal.app_ut2_08.databinding.FragmentInicioBinding
import es.aaronquintanal.app_ut2_08.viewmodel.ItemViewModel

class FragmentInicio : Fragment() {

    private lateinit var binding : FragmentInicioBinding
    private val viewModel: ItemViewModel by activityViewModels()

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View? {
        binding = FragmentInicioBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {

        viewModel.listaCategorias.observe(viewLifecycleOwner){
            val adapterCategorias = ArrayAdapter(requireContext(), R.layout.simple_spinner_item, it)
            binding.spinner.adapter = adapterCategorias
            binding.spinner.setSelection(0, false)
        }

        viewModel.listaItems.observe(viewLifecycleOwner){
            binding.apply {
                listaItems.adapter = ItemAdapter(viewModel)
                listaItems.layoutManager = LinearLayoutManager(context)
                listaItems.addItemDecoration(DividerItemDecoration(context, DividerItemDecoration.VERTICAL))
            }
        }

        viewModel.cargarCategorias()

        binding.spinner.onItemSelectedListener = object : AdapterView.OnItemSelectedListener{
            override fun onItemSelected(p0: AdapterView<*>?, p1: View?, p2: Int, p3: Long) {
                val categoria = p0?.selectedItem.toString()
                viewModel.cargarProductos(categoria)
                Toast.makeText(context,categoria, Toast.LENGTH_SHORT).show()
            }

            override fun onNothingSelected(p0: AdapterView<*>?) = Unit
        }
    }
}