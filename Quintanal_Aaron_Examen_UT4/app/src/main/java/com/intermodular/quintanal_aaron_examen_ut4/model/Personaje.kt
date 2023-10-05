package com.intermodular.quintanal_aaron_examen_ut4.model

import androidx.room.Entity
import androidx.room.PrimaryKey

@Entity(tableName = "personajes")
data class Personaje(
    @PrimaryKey(autoGenerate = true)
    val personajeId: Long,
    val titulo: String,
    val nombre: String,
    val alias: String?,
    val estado: String?,
    val edad: Int?,
    val nacimiento: String?,
    val muerte: String?,
    val actor: String?,
    val imagen: String?
): java.io.Serializable
