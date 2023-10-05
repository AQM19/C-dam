package es.sergiogonzalezvelez.app_03_api.model.ataque

import com.google.gson.annotations.SerializedName
import java.io.Serializable

data class Descripcion(
    @SerializedName("effect")
    val descripcion: String
): Serializable