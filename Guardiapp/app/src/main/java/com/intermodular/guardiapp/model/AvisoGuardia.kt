package com.intermodular.guardiapp.model

import com.google.gson.annotations.SerializedName
import java.io.Serializable
import java.sql.Time
import java.time.LocalDate
import java.time.LocalDateTime
import java.util.*

data class AvisoGuardia(
    @SerializedName("id_aviso")
    var id_aviso:Int,
    @SerializedName("profesor")
    var profesor: Int,
    @SerializedName("horario")
     var horario: Int,
    @SerializedName("motivo")
    var motivo: String?,
    @SerializedName("observaciones")
    var observaciones: String?,
    @SerializedName("confirmado")
    var confirmado: Boolean?,
    @SerializedName("anulado")
    var anulado: Boolean?,
    @SerializedName("fecha_guardia")
    var fecha_aviso: String?,
    @SerializedName("fecha_hora_aviso")
    var hora_aviso: String?
) : Serializable
