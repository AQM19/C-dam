package com.intermodular.quintanal_aaron_examen_ut4.model

import android.content.Context
import androidx.room.Database
import androidx.room.Room
import androidx.room.RoomDatabase
import com.intermodular.quintanal_aaron_examen_ut4.data.database.CasaDAO

@Database(
    entities =[Casa::class, Personaje::class, CasaPersonaje::class],
    version =1
)
abstract class EntitiesDatabase: RoomDatabase()
{
    abstract fun CasaDAO(): CasaDAO

    companion object {
        private var INSTANCE: EntitiesDatabase? = null
        fun getDatabase(context: Context): EntitiesDatabase
        {
            if(INSTANCE == null) {
                synchronized(this) {
                    INSTANCE =
                        Room.databaseBuilder(context, EntitiesDatabase::class.java, "juegoTronos.db")
                            .createFromAsset("juegoTronos_copia.db")
                            .build()
                }
            }
            return INSTANCE!!
        }
    }
}