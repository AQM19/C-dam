package es.aaronquintanal.digiactivity.model

import es.aaronquintanal.digiactivity.data.api.DigimonApi

class DigiRepository {
    private var param: String = "Agumon";
    suspend fun get():Digi? = DigimonApi.retrofitService.getDigimon(param)


    fun setParam(param: String){
        this.param = param;
    }
}