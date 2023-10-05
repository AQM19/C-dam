package com.example.digifragmentv2.model

import com.google.gson.annotations.SerializedName
import java.io.Serializable

data class DigiAttribute (
    @SerializedName("id")
    val id: Int,
    @SerializedName("attribute")
    val attribute : String,
) : Serializable