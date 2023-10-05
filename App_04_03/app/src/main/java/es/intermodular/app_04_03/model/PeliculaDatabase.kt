package es.intermodular.app_04_03.model

import android.content.Context
import androidx.room.Database
import androidx.room.Room
import androidx.room.RoomDatabase
import es.intermodular.app_04_03.data.database.CriticaDao
import es.intermodular.app_04_03.data.database.PeliculaDao

@Database(
    entities = [Pelicula::class, Critica::class],
    version = 1
)
abstract class PeliculaDatabase: RoomDatabase()
{
    abstract fun peliculaDao(): PeliculaDao
    abstract fun criticaDao(): CriticaDao

    companion object {
        private var INSTANCE: PeliculaDatabase? = null
        fun getDatabase(context: Context): PeliculaDatabase
        {
            if(INSTANCE == null) {
                synchronized(this) {
                    INSTANCE =
                        Room.databaseBuilder(context, PeliculaDatabase::class.java, "peliculas.db")
                            .createFromAsset("peliculas-copiar.db")
                            .build()
                }
            }
            return INSTANCE!!
        }
    }
}