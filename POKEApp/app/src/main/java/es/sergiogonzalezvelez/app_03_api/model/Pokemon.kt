package es.sergiogonzalezvelez.app_03_api.model

import com.google.gson.annotations.SerializedName
import es.sergiogonzalezvelez.app_03_api.model.poke.Habilidades
import es.sergiogonzalezvelez.app_03_api.model.poke.Imagenes
import es.sergiogonzalezvelez.app_03_api.model.poke.Movimientos
import es.sergiogonzalezvelez.app_03_api.model.poke.Tipos
import java.io.Serializable

data class Pokemon(
    @SerializedName("name")
    var nombre: String,
    @SerializedName("moves")
    val movimientos: List<Movimientos>,
    @SerializedName("types")
    val tipos: List<Tipos>,
    @SerializedName("sprites")
    val imagenes: Imagenes,
    @SerializedName("abilities")
    val habilidades: List<Habilidades>
): Serializable