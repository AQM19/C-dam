package com.example.digifragment.model

import com.google.gson.annotations.SerializedName
import java.io.Serializable

data class DigiFields (
    @SerializedName("id")
    val id : Int,
    @SerializedName("field")
    val field : String
        ) : Serializable