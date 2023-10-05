package es.aaronquintanal.quintanal_aaron.view

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import coil.load
import es.aaronquintanal.quintanal_aaron.R
import es.aaronquintanal.quintanal_aaron.databinding.FragmentDinoAdapterBinding
import es.aaronquintanal.quintanal_aaron.model.Dino

class DinoAdapter(private val dinos: List<Dino>, private val onClickDino: (Dino) -> Unit): RecyclerView.Adapter<DinoAdapter.DinoViewHolder>() {

    class DinoViewHolder(view: View):RecyclerView.ViewHolder(view){
        private val binding = FragmentDinoAdapterBinding.bind(view)

        fun bind(dino: Dino, onClickDino: (Dino) -> Unit){
            binding.imageDino.load("https://aplicaciones.ivanlorenzo.es/pmdm/dinosaurios/imagenes/"+dino.nombre+".png")
            binding.textViewNameDino.text = dino.nombre
            binding.layoutDino.setOnClickListener{ onClickDino(dino) }
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): DinoViewHolder {
        val adapterLayout = LayoutInflater.from(parent.context)
            .inflate(R.layout.fragment_dino_adapter, parent, false)
        return DinoViewHolder(adapterLayout)
    }

    override fun onBindViewHolder(holder: DinoViewHolder, position: Int) {
        val dino = dinos[position]
        holder.bind(dino, onClickDino)
    }

    override fun getItemCount(): Int = dinos.size

}