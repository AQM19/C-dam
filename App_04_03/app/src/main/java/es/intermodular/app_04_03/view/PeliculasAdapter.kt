package es.intermodular.app_04_03.view

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import coil.load
import es.intermodular.app_04_03.R
import es.intermodular.app_04_03.databinding.PeliculaAdapterBinding
import es.intermodular.app_04_03.model.Pelicula

class PeliculasAdapter(
    private val listaPeliculas: List<Pelicula>,
    private val onClickPelicula: (Pelicula) -> Unit,
    private val cambiarFavorita: (Pelicula) -> Unit): RecyclerView.Adapter<PeliculasAdapter.PeliculasViewHolder>() {

    class PeliculasViewHolder(view: View): RecyclerView.ViewHolder(view) {
        private val binding = PeliculaAdapterBinding.bind(view)

        fun bind(pelicula: Pelicula, onClickPelicula: (Pelicula) -> Unit, cambiarFavorita: (Pelicula) -> Unit){
            val userAgent = "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko)Chrome/108.0.0.0 Safari/537.36"
            val url = pelicula.imagen
            binding.imageViewPortada.load(url){addHeader("User-Agent", userAgent)}
            if (pelicula.favorita) binding.imageViewFav.setImageResource(R.drawable.ic_favorito) else binding.imageViewFav.setImageResource(R.drawable.ic_no_favorito)
            binding.TextViewAnyo.text = pelicula.anyo.toString()
            binding.TextViewDirector.text = pelicula.director
            binding.TextViewPuntuacion.text = pelicula.puntuacion.toString()
            binding.TextViewTitulo.text = pelicula.titulo

            binding.containerPelicula.setOnClickListener{
                onClickPelicula(pelicula)
            }
            binding.imageViewFav.setOnClickListener{
                cambiarFavorita(pelicula)
            }
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): PeliculasAdapter.PeliculasViewHolder {
        val adapterLayout = LayoutInflater.from(parent.context)
            .inflate(R.layout.pelicula_adapter, parent, false)
        return PeliculasViewHolder(adapterLayout)
    }

    override fun onBindViewHolder(holder: PeliculasViewHolder, position: Int) {
        val peli = listaPeliculas[position]
        holder.bind(peli, onClickPelicula, cambiarFavorita)
    }

    override fun getItemCount() = listaPeliculas.size
}