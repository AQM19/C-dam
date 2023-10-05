package es.aaronquintanal.quintanal_aaron.data.api

import es.aaronquintanal.quintanal_aaron.model.Dino
import retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory
import retrofit2.http.GET

private const val URL_BASE = "https://aplicaciones.ivanlorenzo.es/pmdm/dinosaurios/";
private val retrofit = Retrofit.Builder()
    .baseUrl(URL_BASE)
    .addConverterFactory(GsonConverterFactory.create())
    .build()

interface DinoApiService{
    @GET("dinosaurios.json")
    suspend fun getDinos(): MutableList<Dino>
}

object DinoApi{
    val retrofitService: DinoApiService by lazy { retrofit.create(DinoApiService::class.java)}
}