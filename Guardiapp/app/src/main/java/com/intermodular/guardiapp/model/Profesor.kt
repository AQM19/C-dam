package com.intermodular.guardiapp.model

import com.google.gson.annotations.SerializedName

data class Profesor (

        @SerializedName("id")
        val id: Int,
        @SerializedName("dni")
        val dni: String,
        @SerializedName("nombre")
        val nombre: String,
        @SerializedName("ape1")
        val ape1: String,
        @SerializedName("ape2")
        val ape2: String?,
        @SerializedName("tfno")
        val tfno: String?,
        @SerializedName("baja")
        val baja: Boolean?,
        @SerializedName("activo")
        val activo: Boolean?,
        @SerializedName("dept_cod")
        val dept_cod: String?,
        @SerializedName("id_sustituye")
        val id_sustituye: Int?
        ) : java.io.Serializable