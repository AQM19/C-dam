package com.example.btells.model

import com.example.btells.data.api.EscarabajosApi

class EscarabajosRepository {
    suspend fun get():List<Escarabajo> = EscarabajosApi.retrofitService.getEscarabajos()
}