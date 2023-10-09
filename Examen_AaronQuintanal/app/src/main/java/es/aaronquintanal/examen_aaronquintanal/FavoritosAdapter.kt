package es.aaronquintanal.examen_aaronquintanal

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.ImageView
import android.widget.TextView
import androidx.recyclerview.widget.RecyclerView
import es.aaronquintanal.examen_aaronquintanal.modelo.Equipo

class FavoritosAdapter(private val onClickAdapter: (Equipo) -> Unit): RecyclerView.Adapter<FavoritosAdapter.FavoritoViewHolder>() {

    private val listaEquiposFavoritos: ArrayList<Equipo> = DatosSelecciones.getFavoritos()

    class FavoritoViewHolder(view: View, private val onClickHolder: (Int) -> Unit) : RecyclerView.ViewHolder(view) {
        val textViewFav = view.findViewById<TextView>(R.id.textViewFav)
        val imageViewFav = view.findViewById<ImageView>(R.id.imageViewFav)

        init {
            view.setOnClickListener{onClickHolder(adapterPosition)}
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): FavoritoViewHolder {
        val adapterLayout = LayoutInflater.from(parent.context).inflate(R.layout.favoritos_layout, parent, false)
        return FavoritoViewHolder(adapterLayout, {pos -> onClickAdapter(listaEquiposFavoritos[pos])})
    }

    override fun onBindViewHolder(holder: FavoritoViewHolder, position: Int) {
        val equipo = listaEquiposFavoritos[position]
        holder.textViewFav.text = equipo.pais
        holder.imageViewFav.setImageResource(equipo.bandera)
    }

    override fun getItemCount(): Int = listaEquiposFavoritos.size

    fun HacerFavorito(nombre: String, fav : Boolean){
        DatosSelecciones.establecerFavorito(nombre, fav)
    }

}