package com.example.btells.model

import com.google.gson.annotations.SerializedName
import java.io.Serializable

data class Escarabajo (
    @SerializedName("Number")
    val number : String,
    @SerializedName("Genus")
    val genus : String,
    @SerializedName("Species")
    val species : String,
    @SerializedName("Family")
    val family : String,
    @SerializedName("Order")
    val order : String,
    @SerializedName("BugGuideID")
    val gubguideid : String,
    @SerializedName("URL")
    val url : String,
    @SerializedName("CommonName")
    val commonname : String
) : Serializable