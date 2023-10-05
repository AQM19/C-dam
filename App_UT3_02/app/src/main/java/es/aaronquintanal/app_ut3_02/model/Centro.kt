package es.aaronquintanal.app_ut3_02.model

import com.google.gson.annotations.SerializedName
import java.io.Serializable


data class Centro (
    @SerializedName("titulo")
    val nombre:String,
    @SerializedName("correo_electronico")
    val correo:String,
    @SerializedName("direccion")
    val direccion:String,
    @SerializedName("horario")
    val horario:String,
    @SerializedName("localizacion")
    val localizacion:String,
    @SerializedName("telefono")
    val telefono:String,
    @SerializedName("web")
    val web:String
) : Serializable