package com.intermodular.quintanal_aaron_examen_ut4.model

import androidx.room.Entity
import androidx.room.PrimaryKey

@Entity(tableName = "casas")
data class Casa (
    @PrimaryKey(autoGenerate = true)
    val casaId: Long,
    val titulo: String,
    val nombre: String,
    val blason: String?,
    val lema: String?,
    val lugar: String?,
    val region: String?,
    val imagen: String?
): java.io.Serializable