package es.aaronquintanal.app_ut3_02.model

import es.aaronquintanal.app_ut3_02.data.api.CentrosApi

class CentroRepository {
    suspend fun get() : List<Centro> = CentrosApi.retrofitService.getCentros()
}