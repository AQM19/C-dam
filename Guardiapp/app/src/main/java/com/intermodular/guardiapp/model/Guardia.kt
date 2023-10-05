package com.intermodular.guardiapp.model

import com.google.gson.annotations.SerializedName
import com.intermodular.guardiapp.viewmodel.Estado
import java.io.Serializable

data class Guardia (
    @SerializedName("id")
    val id: Int,
    @SerializedName("prof_falta")
    val prof_falta: Int,
    @SerializedName("prof_hace_guardia")
    var prof_hace_guardia: Int?,
    @SerializedName("estado")
    var estado: Estado,
    @SerializedName("fecha")
    var fecha: String,
    @SerializedName("horario")
    var horario: Int,
    @SerializedName("dia_semana")
    var dia_semana: Int?,
    @SerializedName("hora")
    var hora: String?,
    @SerializedName("aviso")
    var aviso: Int?, //avisoguardia
    @SerializedName("grupo")
    var grupo: String?,
    @SerializedName("aula")
    var aula: String?,
    @SerializedName("observaciones")
    var observaciones: String?
) : Serializable