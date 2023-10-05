package es.intermodular.rest.controlador;

import java.util.List;
import java.util.function.Predicate;

import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;

import es.intermodular.rest.modelo.ProfesorTienePerfil;
import es.intermodular.rest.modelo.ProfesorTienePerfilRepositorio;

@RestController
public class ProfesorTienePerfilController {
	private final ProfesorTienePerfilRepositorio profesorTienePerfilRepositorio;
	
	public ProfesorTienePerfilController(ProfesorTienePerfilRepositorio profesorTienePerfilRepositorio) {
		this.profesorTienePerfilRepositorio = profesorTienePerfilRepositorio;
	}
	
	@GetMapping("/profesorestienenperfil")
	public List<ProfesorTienePerfil> getProfesorTienePerfil(){
		return this.profesorTienePerfilRepositorio.findAll();
	}
	@GetMapping("/profesorestienenperfil/profesor/{id}")
	public List<ProfesorTienePerfil> getHorariosPorProfesor(@PathVariable int id){
		Predicate<ProfesorTienePerfil> byProfesor = a -> a.getProfesor() == id;
		return this.profesorTienePerfilRepositorio.findAll().stream().filter(byProfesor).toList();
	}
	
	
	@GetMapping("/profesorestieneperfil/{id}")
	public ProfesorTienePerfil obtenerUno(@PathVariable int id) {
		return this.profesorTienePerfilRepositorio.findById(id).orElse(null);
	}
	
	@PostMapping("/profesorestieneperfil")
	public ProfesorTienePerfil nuevaProfesorTienePerfil(@RequestBody ProfesorTienePerfil nueva) {
		return this.profesorTienePerfilRepositorio.save(nueva);
	}
	
	@PutMapping("/profesorestieneperfil/{id}")
	public ProfesorTienePerfil editarProfesorTienePerfil(@RequestBody ProfesorTienePerfil editar, @PathVariable int id) {
		
		if(profesorTienePerfilRepositorio.existsById(id)) {
			editar.setId(id);
			return profesorTienePerfilRepositorio.save(editar);
		}
		else
		{
			return null;
		}
	}
	
	@DeleteMapping("/profesorestieneperfil/{id}")
	public ProfesorTienePerfil borrarProfesorTienePerfil(@PathVariable int id) {
		if(profesorTienePerfilRepositorio.existsById(id)) {
			ProfesorTienePerfil profesorTienePerfil = profesorTienePerfilRepositorio.findById(id).get();
			profesorTienePerfilRepositorio.delete(profesorTienePerfil);
			return profesorTienePerfil;
		}
		else {
			return null;
		}
	}
}