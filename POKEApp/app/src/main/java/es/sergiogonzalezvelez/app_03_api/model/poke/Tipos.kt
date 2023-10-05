package es.sergiogonzalezvelez.app_03_api.model.poke

import com.google.gson.annotations.SerializedName
import java.io.Serializable

data class Tipos(
    @SerializedName("type")
    val tipos: Map<String, String>
): Serializable