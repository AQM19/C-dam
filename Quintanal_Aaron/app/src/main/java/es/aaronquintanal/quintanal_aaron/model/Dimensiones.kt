package es.aaronquintanal.quintanal_aaron.model

import com.google.gson.annotations.SerializedName
import java.io.Serializable

data class Dimensiones (
    @SerializedName("largo")
    val largo : Double,
    @SerializedName("alto")
    val alto : Double,
    @SerializedName("peso")
    val peso : Double,
) : Serializable