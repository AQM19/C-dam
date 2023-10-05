package com.example.digifragment.view

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.Fragment
import androidx.fragment.app.viewModels
import androidx.navigation.NavController
import androidx.navigation.findNavController
import androidx.recyclerview.widget.DividerItemDecoration
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import coil.load
import com.example.digifragment.databinding.FragmentMainBinding
import com.example.digifragment.model.Digi
import com.example.digifragment.viewmodel.DigiViewModel

class MainFragment : Fragment() {

    private lateinit var binding: FragmentMainBinding
    private val digiViewModel: DigiViewModel by viewModels()
    private lateinit var navController: NavController
    private lateinit var digimon: Digi

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View? {
        binding = FragmentMainBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        navController = view.findNavController()

        digiViewModel.cargarDatos()

        digiViewModel.digiLiveData.observe(viewLifecycleOwner){
            digimon = it
            binding.digiName.text = it.name
            binding.digimonImage.load(it.images[0].href)
            binding.digimonLevels.apply {
                adapter = LevelAdapter(it.levels)
                layoutManager = LinearLayoutManager(context)
                addItemDecoration(DividerItemDecoration(context, DividerItemDecoration.VERTICAL))
            }
            binding.digimonAttributes.apply{
                adapter = AttributeAdapter(it.attributes)
                layoutManager = LinearLayoutManager(context)
                addItemDecoration(DividerItemDecoration(context, DividerItemDecoration.VERTICAL))
            }
            binding.digimonTypes.apply{
                adapter = TypeAdapter(it.types)
                layoutManager = LinearLayoutManager(context)
                addItemDecoration(DividerItemDecoration(context, DividerItemDecoration.VERTICAL))
            }
            binding.digimonFields.apply {
                adapter = FieldAdapter(it.fields)
                layoutManager = LinearLayoutManager(context, RecyclerView.HORIZONTAL, false)
                addItemDecoration(DividerItemDecoration(context, DividerItemDecoration.HORIZONTAL))
            }
            digimon = digiViewModel.digiLiveData.value!!
        }

        binding.digimonImage.setOnClickListener { navController.navigate(MainFragmentDirections.actionMainFragmentToDetailsFragment(digimon))}
    }

}