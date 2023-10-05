package com.intermodular.guardiapp.model

import com.google.gson.annotations.SerializedName
import java.io.Serializable

data class ProfesorTienePerfil(
    @SerializedName("id")
    private val id: Int,
    @SerializedName("profesor")
    private val profesor: Int,
    @SerializedName("perfik")
    private val perfil: Int
):Serializable
