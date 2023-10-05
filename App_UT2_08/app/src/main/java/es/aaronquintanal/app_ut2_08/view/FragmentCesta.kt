package es.aaronquintanal.app_ut2_08.view

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import es.aaronquintanal.app_ut2_08.R
import es.aaronquintanal.app_ut2_08.databinding.FragmentCestaBinding

class FragmentCesta : Fragment() {

    private lateinit var binding : FragmentCestaBinding

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View? {
        binding = FragmentCestaBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
    }
}