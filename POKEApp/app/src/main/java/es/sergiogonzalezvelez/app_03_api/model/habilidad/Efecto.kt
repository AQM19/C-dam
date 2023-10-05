package es.sergiogonzalezvelez.app_03_api.model.habilidad

import com.google.gson.annotations.SerializedName
import java.io.Serializable

data class Efecto(
    @SerializedName("effect")
    val efecto: String,
    @SerializedName("language")
    val idioma: Map<String, String>
): Serializable