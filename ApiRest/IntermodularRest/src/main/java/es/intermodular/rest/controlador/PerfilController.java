package es.intermodular.rest.controlador;

import java.util.List;

import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;

import es.intermodular.rest.modelo.Perfil;
import es.intermodular.rest.modelo.PerfilRepositorio;

@RestController
public class PerfilController {
	private final PerfilRepositorio perfilRepositorio;
	
	public PerfilController( PerfilRepositorio perfilRepositorio) {
		this.perfilRepositorio = perfilRepositorio;
	}
	
	@GetMapping("/perfiles")
	public List<Perfil> getPerfiles(){
		return this.perfilRepositorio.findAll();
	}
	
	@GetMapping("/perfiles/{id}")
	public Perfil obtenerUno(@PathVariable int id) {
		return this.perfilRepositorio.findById(id).orElse(null);
	}
	
	@PostMapping("/perfiles")
	public Perfil nuevoPerfil(@RequestBody Perfil nueva) {
		return this.perfilRepositorio.save(nueva);
	}
	
	@PutMapping("/perfiles/{id}")
	public Perfil editarPerfil(@RequestBody Perfil editar, @PathVariable int id) {
		
		if(perfilRepositorio.existsById(id)) {
			editar.setIdperfil(id);
			return perfilRepositorio.save(editar);
		}
		else
		{
			return null;
		}
	}
	
	@DeleteMapping("/perfiles/{id}")
	public Perfil borrarPerfil(@PathVariable int id) {
		if(perfilRepositorio.existsById(id)) {
			Perfil perfil = perfilRepositorio.findById(id).get();
			perfilRepositorio.delete(perfil);
			return perfil;
		}
		else {
			return null;
		}
	}
}

