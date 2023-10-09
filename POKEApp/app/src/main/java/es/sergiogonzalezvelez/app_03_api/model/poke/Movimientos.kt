package es.sergiogonzalezvelez.app_03_api.model.poke

import com.google.gson.annotations.SerializedName
import java.io.Serializable

data class Movimientos(
    @SerializedName("move")
    val movimiento: Map<String, String>
) : Serializable