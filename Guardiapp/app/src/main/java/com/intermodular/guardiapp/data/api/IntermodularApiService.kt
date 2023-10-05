package com.intermodular.guardiapp.data.api

import com.intermodular.guardiapp.model.*
import retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory
import retrofit2.http.Body
import retrofit2.http.GET
import retrofit2.http.Header
import retrofit2.http.POST
import retrofit2.http.PUT
import retrofit2.http.Path

private const val URL_BASE = "http://192.168.1.136:8080"
private val retrofit = Retrofit.Builder()
    .baseUrl(URL_BASE)
    .addConverterFactory(GsonConverterFactory.create())
    .build()

interface IntermodularApiService{
    @GET("/guardias")
    suspend fun getGuardias(): List<Guardia>

    @POST("/login")
    suspend fun getProfesor(
        @Header(value = "user")user: String,
        @Header(value ="password")password: String
    ) : Profesor?

    @GET("/profesores/{id}")
    suspend fun getProfeFalta(
        @Path(value = "id")id: Int
    ): Profesor?

    @PUT("/guardia/actualizar/{id}")
    suspend fun setGuardiaConfirmada(
        @Path(value = "id")id: Int,
        @Body()guardia: Guardia
    ): Guardia?

    @PUT("/aviso/confirmar/{id}")
    suspend fun setAvisoConfirmado(
        @Path(value = "id")id: Int,
        @Body()aviso: AvisoGuardia
    ): AvisoGuardia?

    @PUT("/aviso/anular/{id}")
    suspend fun setAvisoAnulado(
        @Path(value = "id")id: Int,
        @Body()aviso: AvisoGuardia
    ): AvisoGuardia?

    @POST("/aviso")
    suspend fun crearAviso(
        @Body()aviso: AvisoGuardia
    ): AvisoGuardia?

    @GET("/horario/{id}")
    suspend fun getHorarioProfesor(
        @Path(value = "id")id: Int
    ): List<Horario>

    @GET("/avisos/{id}")
    suspend fun getAvisos(
        @Path(value = "id")id: Int
    ): List<AvisoGuardia>
}

object IntermodularApi{
    val retrofitService: IntermodularApiService by lazy { retrofit.create(IntermodularApiService::class.java) }
}