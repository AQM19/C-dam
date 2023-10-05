package com.example.digifragment.model

import com.example.digifragment.data.api.DigimonApi

class DigiRepository {
    private var param: String = "Agumon";
    suspend fun get():Digi? = DigimonApi.retrofitService.getDigimon(param)


    fun setParam(param: String){
        this.param = param;
    }
}