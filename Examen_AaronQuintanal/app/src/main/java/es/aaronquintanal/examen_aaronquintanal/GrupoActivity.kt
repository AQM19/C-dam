package es.aaronquintanal.examen_aaronquintanal

import android.app.Activity
import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import androidx.activity.result.contract.ActivityResultContracts
import es.aaronquintanal.examen_aaronquintanal.databinding.ActivityGrupo2Binding
import es.aaronquintanal.examen_aaronquintanal.modelo.Equipo
import es.aaronquintanal.examen_aaronquintanal.modelo.Grupo

class GrupoActivity : AppCompatActivity() {
    lateinit var binding: ActivityGrupo2Binding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityGrupo2Binding.inflate(layoutInflater)
        setContentView(binding.root)

        val grupo = intent.extras?.get("grupo") as Grupo

        val titulo = binding.textViewTitulo
        val bandera1 = binding.imageView1
        val bandera2 = binding.imageView2
        val bandera3 = binding.imageView3
        val bandera4 = binding.imageView4

        titulo.text = grupo.nombre
        bandera1.setImageResource(grupo.listaEquipos[0].bandera)
        bandera2.setImageResource(grupo.listaEquipos[1].bandera)
        bandera3.setImageResource(grupo.listaEquipos[2].bandera)
        bandera4.setImageResource(grupo.listaEquipos[3].bandera)

        bandera1.setOnClickListener{
            onClickEquipo(grupo.listaEquipos[0])
        }
        bandera2.setOnClickListener{
            onClickEquipo(grupo.listaEquipos[1])
        }
        bandera3.setOnClickListener{
            onClickEquipo(grupo.listaEquipos[2])
        }
        bandera4.setOnClickListener{
            onClickEquipo(grupo.listaEquipos[3])
        }

    }

    private val segundaActivityLauncher = registerForActivityResult(ActivityResultContracts.StartActivityForResult()){
        if(it.resultCode == Activity.RESULT_OK){
            val equipo = it.data?.getStringExtra("equipo")?:""
            val fav = it.data?.getBooleanExtra("fav", false)?:false
            DatosSelecciones.establecerFavorito(equipo, fav)
            // Aqui no se hacer el dataChanged
        }
    }

    private fun onClickEquipo(equipo : Equipo) {
        val intent = Intent(applicationContext, DetalleEquipoActivity::class.java)
        intent.putExtra("equipo", equipo)
        startActivity(intent)
    }
}