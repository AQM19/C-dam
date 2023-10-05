package com.intermodular.guardiapp.model

import com.intermodular.guardiapp.data.api.IntermodularApi
import retrofit2.HttpException

class IntermodularRepository {
    suspend fun getGuardias():List<Guardia> = IntermodularApi.retrofitService.getGuardias()
    suspend fun getProfesor(user: String, password: String) = IntermodularApi.retrofitService.getProfesor(user, password)
    suspend fun getProfeFalta(id: Int) = IntermodularApi.retrofitService.getProfeFalta(id)
    suspend fun setGuardiaConfirmada(id: Int, guardia: Guardia) = IntermodularApi.retrofitService.setGuardiaConfirmada(id, guardia)
    suspend fun setAvisoConfirmado(id: Int, avisoGuardia: AvisoGuardia) = IntermodularApi.retrofitService.setAvisoConfirmado(id, avisoGuardia)
    suspend fun setAvisoAnulado(id: Int, avisoGuardia: AvisoGuardia) = IntermodularApi.retrofitService.setAvisoAnulado(id, avisoGuardia)
    suspend fun getHorarioProfesor(id: Int) = IntermodularApi.retrofitService.getHorarioProfesor(id)
    suspend fun crearAviso(avisoGuardia: AvisoGuardia) = IntermodularApi.retrofitService.crearAviso(avisoGuardia)
    suspend fun getAviso(id: Int) = IntermodularApi.retrofitService.getAvisos(id)
}