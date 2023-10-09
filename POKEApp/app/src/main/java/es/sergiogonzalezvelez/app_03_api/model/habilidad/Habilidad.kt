package es.sergiogonzalezvelez.app_03_api.model.habilidad

import com.google.gson.annotations.SerializedName
import java.io.Serializable

data class Habilidad(
    @SerializedName("name")
    val nombre: String,
    @SerializedName("effect_entries")
    val efecto: List<Efecto>
): Serializable