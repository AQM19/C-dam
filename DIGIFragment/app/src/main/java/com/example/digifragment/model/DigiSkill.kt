package com.example.digifragment.model

import com.google.gson.annotations.SerializedName
import java.io.Serializable

data class DigiSkill (
    @SerializedName("id")
    val id : Int,
    @SerializedName("skill")
    val skill : String,
    @SerializedName("translation")
    val translation : String,
    @SerializedName("description")
    val description : String
        ) : Serializable