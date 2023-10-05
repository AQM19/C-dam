package es.intermodular.app_04_03.model

import androidx.room.Embedded
import androidx.room.Relation

data class PeliculaConCriticas(
    @Embedded val pelicula: Pelicula,
    @Relation(
        parentColumn = "id",
        entityColumn = "pelicula_id"
    )
    val criticas: List<Critica>
) : java.io.Serializable