package com.example.digifragmentv2.model

import com.google.gson.annotations.SerializedName
import java.io.Serializable

data class DigiType (
    @SerializedName("id")
    val id : Int,
    @SerializedName("type")
    val type : String
) : Serializable