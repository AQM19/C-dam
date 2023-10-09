package com.example.btells.data.api

import com.example.btells.model.Escarabajo
import retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory
import retrofit2.http.GET

private const val URL_BASE =
    "https://bugs.verfasor.com/"

private val retrofit = Retrofit.Builder()
    .baseUrl(URL_BASE)
    .addConverterFactory(GsonConverterFactory.create())
    .build()

interface EscarabajosApiService{
    @GET("api")
    suspend fun getEscarabajos() : List<Escarabajo>
}

object EscarabajosApi{
    val retrofitService: EscarabajosApiService by lazy { retrofit.create(EscarabajosApiService::class.java) }
}