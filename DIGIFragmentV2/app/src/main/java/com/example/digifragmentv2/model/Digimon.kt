package com.example.digifragmentv2.model

import com.google.gson.annotations.SerializedName
import java.io.Serializable

data class Digimon (
    @SerializedName("id")
    val id : Int,
    @SerializedName("digimon")
    val digimon : String,
    @SerializedName("condition")
    val condition : String
) : Serializable