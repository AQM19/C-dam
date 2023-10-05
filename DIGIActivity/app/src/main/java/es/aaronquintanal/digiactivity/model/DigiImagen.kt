package es.aaronquintanal.digiactivity.model

import com.google.gson.annotations.SerializedName
import java.io.Serializable

data class DigiImagen (
    @SerializedName("href")
    val href : String,
    @SerializedName("transparent")
    val transparent : Boolean
        ) : Serializable