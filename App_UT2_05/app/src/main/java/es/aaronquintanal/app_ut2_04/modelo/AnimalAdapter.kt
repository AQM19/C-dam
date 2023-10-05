package es.aaronquintanal.app_ut2_04.modelo

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.ImageView
import android.widget.TextView
import android.widget.Toast
import androidx.recyclerview.widget.RecyclerView
import es.aaronquintanal.app_ut2_04.R
import es.aaronquintanal.app_ut2_04.datos.Animal
import es.aaronquintanal.app_ut2_04.datos.DatosAnimales

class AnimalAdapter(private val onClickAdapter: (Animal) -> Unit) : RecyclerView.Adapter<AnimalAdapter.AnimalViewHolder>(){

    private val listaAnimales = DatosAnimales.getDatosAnimales()

    class AnimalViewHolder(view: View, private val onClickHolder: (Int) -> Unit): RecyclerView.ViewHolder(view){
        val textViewNombreAnimal = view.findViewById<TextView>(R.id.textViewNombreAnimal)
        val imageViewAnimal = view.findViewById<ImageView>(R.id.imageView)
        val votosAnimal = view.findViewById<TextView>(R.id.votosAnimal)

        init {
            view.setOnClickListener{onClickHolder(adapterPosition)}
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): AnimalViewHolder {
        val adapterLayout = LayoutInflater.from(parent.context).inflate(R.layout.item_animal, parent, false)
        return AnimalViewHolder(adapterLayout, {pos -> onClickAdapter(listaAnimales[pos])})
    }

    override fun onBindViewHolder(holder: AnimalViewHolder, position: Int) {
        val animal = listaAnimales[position]
        holder.votosAnimal.text = animal.votos.toString() + " votos"
        holder.textViewNombreAnimal.text = animal.nombre
        holder.imageViewAnimal.setImageResource(animal.imagenId)
    }

    override fun getItemCount(): Int = listaAnimales.size

    fun addAnimal(animal: Animal){
        listaAnimales.add(animal)
        notifyDataSetChanged()
    }

    fun cambiarVoto(nombre: String, voto: Int){
        listaAnimales.find { animal -> animal.nombre.equals(nombre) }!!.votos += voto;
    }
}