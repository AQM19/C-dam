package es.aaronquintanal.digiactivity.data.api

import es.aaronquintanal.digiactivity.model.Digi
import retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory
import retrofit2.http.GET
import retrofit2.http.Path

private const val URL_BASE = "https://www.digi-api.com";
private val retrofit = Retrofit.Builder()
    .baseUrl(URL_BASE)
    .addConverterFactory(GsonConverterFactory.create())
    .build()

interface DigiApiService{
    @GET("/api/v1/digimon/{param}")
    suspend fun getDigimon(@Path(value = "param") param: String) : Digi
}

object DigimonApi{
    val retrofitService: DigiApiService by lazy { retrofit.create(DigiApiService::class.java)}
}