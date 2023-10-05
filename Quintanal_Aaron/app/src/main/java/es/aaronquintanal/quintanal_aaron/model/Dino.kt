package es.aaronquintanal.quintanal_aaron.model

import com.google.gson.annotations.SerializedName
import java.io.Serializable

data class Dino (
    @SerializedName("nombre")
    val nombre: String,
    @SerializedName("dimensiones")
    val dimensiones: Dimensiones,
    @SerializedName("alimentacion")
    val alimentacion: String,
    @SerializedName("era")
    val era: String,
    @SerializedName("significado")
    val significado: String,
    @SerializedName("yacimientos")
    val yacimientos: List<String>,
    @SerializedName("anyo")
    val anyo: Int
        ) : Serializable