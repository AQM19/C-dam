package es.sergiogonzalezvelez.app_03_api

import androidx.lifecycle.LifecycleOwner
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.Observer
import java.util.concurrent.atomic.AtomicBoolean


class SingleLiveEvent<Any>: MutableLiveData<Any>() {
    private var pendiente = false

    override fun observe(owner: LifecycleOwner, observer: Observer<in Any>) {
        super.observe(owner) { t ->
            if (pendiente) {
                observer.onChanged(t)
                pendiente = false
            }
        }
    }

    override fun setValue(t: Any?) {
        pendiente = true
        super.setValue(t)
    }
}