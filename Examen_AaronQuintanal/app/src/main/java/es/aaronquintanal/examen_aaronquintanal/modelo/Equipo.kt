package es.aaronquintanal.examen_aaronquintanal.modelo

import android.media.Image
import android.widget.ImageView
import java.io.Serializable

data class Equipo (val pais : String, val descripcion : String, val bandera : Int, val imagen : Int, var pasa : Boolean = false) : Serializable