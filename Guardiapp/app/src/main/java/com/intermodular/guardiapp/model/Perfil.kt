package com.intermodular.guardiapp.model

import com.google.gson.annotations.SerializedName
import java.io.Serializable

data class Perfil(
    @SerializedName("idperfil")
    private val idperfil: Int,
    @SerializedName("nom_perfil")
    private val nom_perfil: String
):Serializable
