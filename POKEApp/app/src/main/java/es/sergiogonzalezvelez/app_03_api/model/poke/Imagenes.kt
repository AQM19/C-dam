package es.sergiogonzalezvelez.app_03_api.model.poke

import com.google.gson.annotations.SerializedName
import java.io.Serializable

data class Imagenes(
    @SerializedName("front_default")
    val front_default: String,
    @SerializedName("back_default")
    val back_default: String,
    @SerializedName("front_shiny")
    val front_shiny: String,
    @SerializedName("back_shiny")
    val back_shiny: String
): Serializable