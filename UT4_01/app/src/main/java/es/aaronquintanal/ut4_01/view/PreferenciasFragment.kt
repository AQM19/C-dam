package es.aaronquintanal.ut4_01.view

import android.os.Bundle
import androidx.preference.PreferenceFragmentCompat
import es.aaronquintanal.ut4_01.R

class PreferenciasFragment : PreferenceFragmentCompat() {

    override fun onCreatePreferences(savedInstanceState: Bundle?, rootKey: String?) {
        setPreferencesFromResource(R.xml.preferencias, rootKey)
    }
}