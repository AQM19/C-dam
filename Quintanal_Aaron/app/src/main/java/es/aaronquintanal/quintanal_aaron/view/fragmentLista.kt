package es.aaronquintanal.quintanal_aaron.view

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.Fragment
import androidx.fragment.app.activityViewModels
import androidx.navigation.NavController
import androidx.navigation.findNavController
import androidx.recyclerview.widget.DividerItemDecoration
import androidx.recyclerview.widget.LinearLayoutManager
import es.aaronquintanal.quintanal_aaron.databinding.FragmentListaBinding
import es.aaronquintanal.quintanal_aaron.model.Dino
import es.aaronquintanal.quintanal_aaron.viewmodel.DinosauriosViewModel

class fragmentLista : Fragment() {

    private lateinit var binding: FragmentListaBinding
    private lateinit var navController: NavController
    private val dinoViewModel: DinosauriosViewModel by activityViewModels()

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View? {
        binding = FragmentListaBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        navController = view.findNavController()

        dinoViewModel.dinoLiveData.observe(viewLifecycleOwner){
            binding.recyclerLista.apply{
                adapter = DinoAdapter(it) { dino -> onClickDino(dino)}
                layoutManager = LinearLayoutManager(context)
                addItemDecoration(DividerItemDecoration(context, DividerItemDecoration.VERTICAL))
            }
        }
    }

    private fun onClickDino(dino: Dino){
        navController.navigate(fragmentListaDirections.actionFragmentListaToFragmentDinosaurio(dino))
    }

}