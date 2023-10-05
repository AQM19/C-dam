package es.sergiogonzalezvelez.app_03_api.model

import es.sergiogonzalezvelez.app_03_api.data.api.PokeApi
import es.sergiogonzalezvelez.app_03_api.model.ataque.Ataque
import es.sergiogonzalezvelez.app_03_api.model.habilidad.Habilidad
import kotlin.random.Random

class PokemonRepository {
    private var id = 1

    suspend fun getPoke(): Pokemon = PokeApi.retrofitService.getPoke(id)
    suspend fun getHabilidad(path: String): Habilidad = PokeApi.retrofitService.getHabilidad(path)
    suspend fun getAtaque(path: String): Ataque = PokeApi.retrofitService.getAtaque(path)

    fun next() {
        if(id < 903) {
            id++
        }
    }

    fun rand() {
        id = Random.Default.nextInt(1, 904)
    }

    fun back() {
        if(id > 1) {
            id--
        }
    }
}