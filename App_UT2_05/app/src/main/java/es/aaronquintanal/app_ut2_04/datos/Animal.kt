package es.aaronquintanal.app_ut2_04.datos

import java.io.Serializable

data class Animal (val nombre: String, val imagenId: Int, val descripcion: String, var votos: Int) : Serializable