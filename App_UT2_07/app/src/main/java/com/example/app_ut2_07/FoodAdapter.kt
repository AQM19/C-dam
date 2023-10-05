package com.example.app_ut2_07

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.ImageView
import android.widget.TextView
import androidx.recyclerview.widget.RecyclerView
import com.example.app_ut2_07.databinding.FoodLayoutBinding

class FoodAdapter(val categoria : String, private val onClickAdapter: (Producto) -> Unit): RecyclerView.Adapter<FoodAdapter >() {

    private val listaProductos : List<Producto> = Datos.getProductosCategorias(categoria)

    class FoodViewHolder(view: View, private val onClickHolder: (Int) -> Unit): RecyclerView.ViewHolder(view) {
        val textViewFood = view.findViewById<TextView>(R.id.textViewFood)
        val imageViewFood = view.findViewById<ImageView>(R.id.imageViewFood)

        init{
            view.setOnClickListener{onClickHolder(adapterPosition)}
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): FoodViewHolder {
        val adapterLayout = LayoutInflater.from(parent.context).inflate(R.layout.food_layout, parent, false)
        return FoodViewHolder(adapterLayout, {pos -> onClickAdapter(listaProductos[pos])})
    }

    override fun onBindViewHolder(holder: FoodViewHolder, position: Int) {
        val producto = listaProductos[position]
        holder.textViewFood.text = producto.nombre
        holder.imageViewFood.setImageResource(producto.imagenId)
    }

    override fun getItemCount(): Int = listaProductos.size


}