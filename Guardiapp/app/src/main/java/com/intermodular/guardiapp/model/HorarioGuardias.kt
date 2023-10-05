package com.intermodular.guardiapp.model

import com.google.gson.annotations.SerializedName
import java.io.Serializable

data class HorarioGuardias(
    @SerializedName("id")
    private val id: Int,
    @SerializedName("profesor")
    private val profesor: Int,
    @SerializedName("dia_semana")
    private val dia_semana: Int,
    @SerializedName("hora_guardia")
    private val hora_guardia: Int,
    @SerializedName("realizadas")
    private val realizadas: Int
):Serializable
