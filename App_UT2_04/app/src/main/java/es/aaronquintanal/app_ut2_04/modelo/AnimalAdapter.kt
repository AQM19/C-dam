package es.aaronquintanal.app_ut2_04.modelo

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.TextView
import androidx.recyclerview.widget.RecyclerView
import es.aaronquintanal.app_ut2_04.R
import es.aaronquintanal.app_ut2_04.datos.DatosAnimales

class AnimalAdapter: RecyclerView.Adapter<AnimalAdapter.AnimalViewHolder>(){

    private val listaAnimales = DatosAnimales.getDatosAnimales()
    // No tiene binding

    class AnimalViewHolder(view: View): RecyclerView.ViewHolder(view){
        val textViewNombreAnimal = view.findViewById<TextView>(R.id.textViewNombreAnimal)
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): AnimalViewHolder {
        val adapterLayout = LayoutInflater.from(parent.context).inflate(R.layout.item_animal, parent, false)
        return AnimalViewHolder(adapterLayout)
    }

    override fun onBindViewHolder(holder: AnimalViewHolder, position: Int) {
        val animal = listaAnimales[position]
        holder.textViewNombreAnimal.text = animal
    }

    override fun getItemCount(): Int = listaAnimales.size

    fun addAnimal(animal: String){
        listaAnimales.add(animal)
        notifyDataSetChanged()
    }
}