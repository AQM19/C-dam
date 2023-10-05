package com.intermodular.guardiapp.model

import com.google.gson.annotations.SerializedName

data class Horario (

    @SerializedName("id")
    public val id: Int,
    @SerializedName("profesor")
    public val profesor: Int,
    @SerializedName("dia_semana")
    public val dia_semana: Int,
    @SerializedName("hora")
    public val hora: Int,
    @SerializedName("aula")
    public val aula: String?,
    @SerializedName("grupo")
    public val grupo : String?,
    @SerializedName("materia")
    public val materia : String?,
    @SerializedName("genera_guardia")
    public val genera_guardia : Boolean

        ): java.io.Serializable