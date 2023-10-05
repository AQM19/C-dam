package com.intermodular.quintanal_aaron_examen_ut4.model

import androidx.room.Entity
import androidx.room.ForeignKey
import com.intermodular.quintanal_aaron_examen_ut4.model.Casa
import com.intermodular.quintanal_aaron_examen_ut4.model.Personaje

@Entity(
    tableName = "casas_personajes",
    primaryKeys = ["casaId", "personajeId"],
    foreignKeys = [
        ForeignKey(
            entity = Casa::class,
            parentColumns = ["casaId"],
            childColumns = ["casaId"],
            onDelete = ForeignKey.RESTRICT),
        ForeignKey(
            entity = Personaje::class,
            parentColumns = ["personajeId"],
            childColumns = ["personajeId"],
            onDelete = ForeignKey.NO_ACTION)
    ]
)
data class CasaPersonaje(
    val casaId: Long,
    val personajeId: Long
)
