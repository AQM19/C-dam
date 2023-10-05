package com.intermodular.guardiapp.view

import android.content.Context
import android.content.SharedPreferences
import android.os.Bundle
import android.preference.PreferenceManager
import android.text.method.PasswordTransformationMethod
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Toast
import androidx.fragment.app.Fragment
import androidx.fragment.app.activityViewModels
import androidx.lifecycle.lifecycleScope
import androidx.navigation.NavController
import androidx.navigation.findNavController
import com.intermodular.guardiapp.R
import com.intermodular.guardiapp.databinding.FragmentLoginBinding
import com.intermodular.guardiapp.viewmodel.ProfesorViewModel
import kotlinx.coroutines.launch
import retrofit2.HttpException
import java.net.SocketTimeoutException
import java.security.MessageDigest

class LoginFragment : Fragment() {

    private lateinit var binding: FragmentLoginBinding
    private lateinit var sharedPreferences: SharedPreferences
    private lateinit var loginListener: LoginListener
    private lateinit var navController: NavController
    private val viewModel: ProfesorViewModel by activityViewModels()

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        sharedPreferences = PreferenceManager.getDefaultSharedPreferences(context)
    }

    override fun onStart() {
        super.onStart()
        val username = sharedPreferences.getString("username","")
        val password = sharedPreferences.getString("password","")

        if(!username.isNullOrEmpty() && !password.isNullOrEmpty()){
            binding.editTextUserLogin.setText(username)
            binding.editTextPassword.setText(password)
            binding.checkBoxRecordar.isChecked = true
        }
    }

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View {
        binding = FragmentLoginBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        navController = view.findNavController()

        binding.buttonLogin.setOnClickListener {
            login()
        }
        binding.editTextPassword.transformationMethod = PasswordTransformationMethod.getInstance()

        binding.imageViewLockIcon.setOnClickListener {
            if(binding.editTextPassword.transformationMethod == null){
                binding.editTextPassword.transformationMethod = PasswordTransformationMethod.getInstance()
                binding.imageViewLockIcon.setImageResource(R.drawable.lock_1_svgrepo_com)
            } else {
                binding.editTextPassword.transformationMethod = null
                binding.imageViewLockIcon.setImageResource(R.drawable.lock_slash_svgrepo_com)
            }
        }
    }

    fun login(){
        if(validarDatos()){
            val user = binding.editTextUserLogin.text.toString()
            val pass = hashMD5(binding.editTextPassword.text.toString())

            lifecycleScope.launch{
                try{
                    val profesor = viewModel.cargarProfe(user, pass)
                    viewModel.guardarProfe(profesor!!)

                    navController.navigate(LoginFragmentDirections.actionLoginFragmentToFragmentFecha())
                    (activity as LoginListener).onLogin()

                } catch (e: HttpException){
                    Toast.makeText(context, "Error en el inicio de sesión", Toast.LENGTH_LONG).show()
                } catch (e: SocketTimeoutException) {
                    Toast.makeText(context, "Servicio caído, inténtelo más tarde.", Toast.LENGTH_LONG).show()
                }
            }
        }
    }

    fun validarDatos() : Boolean {
        if(binding.editTextUserLogin.text.toString().isEmpty()){
            Toast.makeText(context, "Indica el nombre de usuario.", Toast.LENGTH_LONG).show()
            return false
        }

        if(binding.editTextPassword.text.toString().isEmpty()){
            Toast.makeText(context, "Indica la contraseña.", Toast.LENGTH_LONG).show()
            return false
        }

        if(binding.checkBoxRecordar.isChecked){
            val editor = sharedPreferences.edit()
            editor.putString("username", binding.editTextUserLogin.text.toString())
            editor.putString("password",binding.editTextPassword.text.toString())
            editor.apply()
        }

        return true
    }

    fun hashMD5(param: String): String {
        val md = MessageDigest.getInstance("MD5")
        val digested = md.digest(param.toByteArray())
        return digested.joinToString("") {
            String.format("%02x",it)
        }
    }

    interface LoginListener {
        fun onLogin()
    }

    override fun onAttach(context: Context) {
        super.onAttach(context)
        if (context is LoginListener) {
            loginListener = context
        }
    }

}