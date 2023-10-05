package com.intermodular.guardiapp.model

import com.google.gson.annotations.SerializedName
import com.intermodular.guardiapp.viewmodel.Turno
import java.io.Serializable
import java.sql.Time

data class HorarioCentro(
    @SerializedName("id")
    private val id: Int,
    @SerializedName("horainicio")
    private val horainicio: Time,
    @SerializedName("horafin")
    private val horafin: Time,
    @SerializedName("turno")
    private val turno: Turno?
    ):Serializable
