package com.example.app_ut2_08

import java.io.Serializable

data class Categoria (val nombre : String, val listaProductos : List<Producto>) : Serializable