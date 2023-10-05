package com.example.digifragment.model

import com.google.gson.annotations.SerializedName
import java.io.Serializable

data class Digi (
    @SerializedName("id")
    val id: Int,
    @SerializedName("name")
    val name : String,
    @SerializedName("xAntibody")
    val xAntibody : Boolean,
    @SerializedName("images")
    val images : List<DigiImagen>,
    @SerializedName("levels")
    val levels : List<DigiLevel>,
    @SerializedName("types")
    val types : List<DigiType>,
    @SerializedName("attributes")
    val attributes : List<DigiAttribute>,
    @SerializedName("fields")
    val fields : List<DigiFields>,
    @SerializedName("releasesDate")
    val releaseDate : Int,
    @SerializedName("descriptions")
    val descriptions : List<DigiDescriptions>,
    @SerializedName("skills")
    val skills : List<DigiSkill>,
    @SerializedName("priorEvolutions")
    val priorEvolutions : List<Digimon>,
    @SerializedName("nextEvolutions")
    val nextEvolutions : List<Digimon>
    ) : Serializable