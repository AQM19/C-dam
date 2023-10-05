package es.aaronquintanal.quintanal_aaron.model

import es.aaronquintanal.quintanal_aaron.data.api.DinoApi

class DinoRepository {
    suspend fun get():MutableList<Dino> = DinoApi.retrofitService.getDinos();
}