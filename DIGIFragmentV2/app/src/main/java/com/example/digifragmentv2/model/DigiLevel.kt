package com.example.digifragmentv2.model

import com.google.gson.annotations.SerializedName
import java.io.Serializable

data class DigiLevel (
    @SerializedName("id")
    val id : Int,
    @SerializedName("level")
    val level : String
) : Serializable