package es.sergiogonzalezvelez.app_03_api.data.api

import es.sergiogonzalezvelez.app_03_api.model.ataque.Ataque
import es.sergiogonzalezvelez.app_03_api.model.habilidad.Habilidad
import es.sergiogonzalezvelez.app_03_api.model.Pokemon
import retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory
import retrofit2.http.GET
import retrofit2.http.Path

private const val URL_BASE =
    "https://pokeapi.co/api/v2/"

private val retrofit = Retrofit.Builder()
    .baseUrl(URL_BASE)
    .addConverterFactory(GsonConverterFactory.create())
    .build()

interface PokeApiService
{
    @GET("pokemon/{id}")
    suspend fun getPoke(@Path(value = "id") id: Int) : Pokemon

    @GET("ability/{id}")
    suspend fun getHabilidad(@Path(value = "id") path: String) : Habilidad

    @GET("move/{id}")
    suspend fun getAtaque(@Path(value = "id") path: String) : Ataque
}
object PokeApi {
    val retrofitService: PokeApiService by lazy { retrofit.create(PokeApiService::class.java) }
}