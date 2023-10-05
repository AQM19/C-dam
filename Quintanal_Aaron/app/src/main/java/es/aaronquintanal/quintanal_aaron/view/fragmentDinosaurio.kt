package es.aaronquintanal.quintanal_aaron.view

import android.app.AlertDialog
import android.app.ProgressDialog.show
import android.content.DialogInterface
import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Toast
import androidx.fragment.app.Fragment
import androidx.fragment.app.activityViewModels
import androidx.fragment.app.viewModels
import androidx.navigation.NavController
import androidx.navigation.findNavController
import coil.load
import es.aaronquintanal.quintanal_aaron.R
import es.aaronquintanal.quintanal_aaron.databinding.FragmentDinosaurioBinding
import es.aaronquintanal.quintanal_aaron.model.Dino
import es.aaronquintanal.quintanal_aaron.viewmodel.DinosauriosViewModel


class fragmentDinosaurio : Fragment() {

    private lateinit var binding: FragmentDinosaurioBinding
    private lateinit var dino: Dino
    private lateinit var navController: NavController
    private val dinoViewModel: DinosauriosViewModel by activityViewModels()

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        arguments?.let {
            dino = it.get("dino") as Dino
        }
    }

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View? {
        binding = FragmentDinosaurioBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        navController = view.findNavController()

        binding.ivDinosaurio.load("https://aplicaciones.ivanlorenzo.es/pmdm/dinosaurios/imagenes/"+dino.nombre+".png")
        binding.tvNombre.text = "Nombre: ${dino.nombre}"
        binding.tvSignificado.text = "Significado: ${dino.significado}"
        binding.tvAlimentacion.text = "Alimentación: ${dino.alimentacion}"
        binding.tvEra.text = "Era: ${dino.era}"
        binding.tvYacimientos.text = "Yacimientos: ${dino.yacimientos.toString()}"
        binding.tvAnyo.text = "Año: ${dino.anyo.toString()}"
        binding.tvLargo.text = "Lago: ${dino.dimensiones.largo.toString()}"
        binding.tvAlto.text = "Alto: ${dino.dimensiones.alto.toString()}"
        binding.tvPeso.text = "Peso: ${dino.dimensiones.peso.toString()}"

        binding.ivPapelera.setOnClickListener{
            AlertDialog.Builder(context)
                .setTitle("¿Borrar dinosaurio?")
                .setMessage("Está seguro que desea borrar el dinosaurio ${dino.nombre}?")
                .setNegativeButton("No") { _,_ ->
                    Toast.makeText(context, "No se ha conseguido borrar al ${dino.nombre}", Toast.LENGTH_LONG).show()
                }
                .setPositiveButton("Si") { _,_ ->
                    dinoViewModel.borrarDino(dino.nombre)
                    navController.navigate(R.id.fragmentLista)
                }.show()
        }
    }

}
