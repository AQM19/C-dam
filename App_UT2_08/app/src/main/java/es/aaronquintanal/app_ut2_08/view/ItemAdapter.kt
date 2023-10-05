package es.aaronquintanal.app_ut2_08.view

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.ImageView
import android.widget.TextView
import androidx.recyclerview.widget.RecyclerView
import com.example.app_ut2_08.Producto
import es.aaronquintanal.app_ut2_08.R
import es.aaronquintanal.app_ut2_08.model.data.Datos

class ItemAdapter(val categoria: String, private val onclickAdapter: (Producto) -> Unit): RecyclerView.Adapter<ItemAdapter.ItemViewHolder>() {

    private val listaItems : List<Producto> = Datos.getProductosCategorias(categoria)

    class ItemViewHolder(view: View, private val onClickHolder: (Int) -> Unit): RecyclerView.ViewHolder(view){
        val txtViewItem = view.findViewById<TextView>(R.id.textViewItem)
        val imgViewItem = view.findViewById<ImageView>(R.id.imageViewItem)

        init{
            view.setOnClickListener{onClickHolder(adapterPosition)}
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): ItemViewHolder {
        val adapterLayout = LayoutInflater.from(parent.context).inflate(R.layout.item_layout, parent, false)
        return ItemViewHolder(adapterLayout, {pos -> onclickAdapter(listaItems[pos])})
    }

    override fun onBindViewHolder(holder: ItemViewHolder, position: Int) {
        val producto = listaItems[position]
        holder.txtViewItem.text = producto.nombre
        holder.imgViewItem.setImageResource(producto.imagenId)
    }

    override fun getItemCount(): Int = listaItems.size
}