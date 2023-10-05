package com.intermodular.guardiapp.model

import com.google.gson.annotations.SerializedName
import com.intermodular.guardiapp.viewmodel.Tipo
import java.io.Serializable
import java.util.*

data class BajasPermisos(
    @SerializedName("idbaja")
    private val idbaja: Int,
    @SerializedName("profesor")
    private val profesor: Int?,
    @SerializedName("fechainicio")
    private val fechainicio: Date?,
    @SerializedName("fechafin")
    private val fechafin: Date?,
    @SerializedName("tipo")
    private val tipo: Tipo
    ):Serializable
