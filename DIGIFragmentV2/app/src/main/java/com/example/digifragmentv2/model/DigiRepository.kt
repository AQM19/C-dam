package com.example.digifragmentv2.model

import com.example.digifragmentv2.data.api.DigimonApi

class DigiRepository {
    private var param: String = "Agumon";
    suspend fun get():Digi? = DigimonApi.retrofitService.getDigimon(param)


    fun setParam(param: String){
        this.param = param;
    }
}