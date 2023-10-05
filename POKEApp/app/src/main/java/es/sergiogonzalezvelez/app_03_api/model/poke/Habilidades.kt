package es.sergiogonzalezvelez.app_03_api.model.poke

import com.google.gson.annotations.SerializedName
import java.io.Serializable

data class Habilidades(
    @SerializedName("ability")
    val habilidad: Map<String, String>
) : Serializable