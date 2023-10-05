package es.sergiogonzalezvelez.app_03_api.model.ataque

import com.google.gson.annotations.SerializedName
import java.io.Serializable

data class Tipo(
    @SerializedName("name")
    val tipo: String
): Serializable