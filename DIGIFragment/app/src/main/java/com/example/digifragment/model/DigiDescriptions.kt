package com.example.digifragment.model

import com.google.gson.annotations.SerializedName
import java.io.Serializable

data class DigiDescriptions (
    @SerializedName("origin")
    val origin : String,
    @SerializedName("language")
    val language : String,
    @SerializedName("description")
    val description: String
        ) : Serializable