package es.sergiogonzalezvelez.app_03_api.model.ataque

import com.google.gson.annotations.SerializedName
import java.io.Serializable

data class Ataque(
    @SerializedName("name")
    val nombre: String,
    @SerializedName("accuracy")
    val precision: Int,
    @SerializedName("damage_class")
    val modoAtaque: ModoAtaque,
    @SerializedName("effect_entries")
    val efecto: List<Descripcion>,
    @SerializedName("power")
    val potencia: Int,
    @SerializedName("pp")
    val usos: Int,
    @SerializedName("type")
    val tipo: Tipo
): Serializable