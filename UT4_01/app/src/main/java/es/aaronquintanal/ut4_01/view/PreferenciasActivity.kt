package es.aaronquintanal.ut4_01.view

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import es.aaronquintanal.ut4_01.R

class PreferenciasActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?)
    {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_preferencias)

        if(savedInstanceState == null){
            supportFragmentManager
                .beginTransaction()
                .replace(R.id.preferencias, PreferenciasFragment())
                .commit()
        }
    }
}