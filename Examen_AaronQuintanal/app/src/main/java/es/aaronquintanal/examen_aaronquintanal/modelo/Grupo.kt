package es.aaronquintanal.examen_aaronquintanal.modelo

import java.io.Serializable

data class Grupo (val nombre : String, val listaEquipos : List<Equipo>) : Serializable