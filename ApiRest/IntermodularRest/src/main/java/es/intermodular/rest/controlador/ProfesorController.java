package es.intermodular.rest.controlador;

import java.util.List;
import java.util.Map;
import java.util.Optional;
import java.util.function.Predicate;

import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestHeader;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import es.intermodular.rest.modelo.Profesor;
import es.intermodular.rest.modelo.ProfesorRepositorio;

@RestController
public class ProfesorController {
	private final ProfesorRepositorio profesorRepositorio;
	
	public ProfesorController(  ProfesorRepositorio profesorRepositorio) {
		this.profesorRepositorio = profesorRepositorio;
	}
	
	@GetMapping("/profesores")
	public List<Profesor> getProfesores(){
		return this.profesorRepositorio.findAll();
	}
	
	@PostMapping("/login")
	public ResponseEntity<?> getProfesorLogin(@RequestHeader String user, @RequestHeader String password) {
	    Predicate<Profesor> byLogin = p -> p.getUser().equals(user) && p.getPassword().equals(password);
	    Profesor profesor = this.profesorRepositorio.findAll().stream().filter(byLogin).findFirst().orElse(null);
	    if(profesor != null) {
	    	return ResponseEntity.ok(profesor);
	    }
	    return ResponseEntity.status(HttpStatus.UNAUTHORIZED).body("Acceso denegado");
	}
	
	@PostMapping("/adminlogin")
	public ResponseEntity<?> getAdminLogin(@RequestBody Map<String, String> data) {
	    String user = data.get("user");
	    String password = data.get("password");
		Predicate<Profesor> byLogin = p -> p.getUser().equals(user) && p.getPassword().equals(password);
		Profesor profesor = this.profesorRepositorio.findAll().stream().filter(byLogin).findFirst().orElse(null);
		if(profesor != null) {
			List<Profesor> profesoresConPerfiles2y4 = this.profesorRepositorio.findProfesoresConPerfiles2y4();
			if (profesoresConPerfiles2y4.contains(profesor)) {
				return ResponseEntity.ok(profesor);
			} else {
				return ResponseEntity.status(HttpStatus.UNAUTHORIZED).body("Acceso denegado");
			}
		}
		return ResponseEntity.status(HttpStatus.UNAUTHORIZED).body("Acceso denegado");
	}

	
	
	@GetMapping("/profesores/{id}")
	public Profesor obtenerUnu(@PathVariable int id) {
		return this.profesorRepositorio.findById(id).orElse(null);
	}
	
	@PostMapping("/profesores")
	public Profesor nuevoProfesor(@RequestBody Profesor nueva) {
		return this.profesorRepositorio.save(nueva);
	}
	
	@PutMapping("/profesores/{id}")
	public Profesor editarProfesor(@RequestBody Profesor editar, @PathVariable int id) {
		
		if(profesorRepositorio.existsById(id)) {
			editar.setId(id);
			return profesorRepositorio.save(editar);
		}
		else
		{
			return null;
		}
	}
	
	@DeleteMapping("/profesores/{id}")
	public Profesor borrarHorario(@PathVariable int id) {
		if(profesorRepositorio.existsById(id)) {
			Profesor profesor = profesorRepositorio.findById(id).get();
			profesorRepositorio.delete(profesor);
			return profesor;
		}
		else {
			return null;
		}
	}
	
	
	@GetMapping("/profesor/{nombreCompleto}")
	public ResponseEntity<?> obtenerProfesorPorNombreCompleto(@PathVariable("nombreCompleto") String nombreCompleto) {
	    Optional<Profesor> profesor = this.profesorRepositorio.findAll().stream()
	    		.filter(x -> x.getNombre().equalsIgnoreCase(nombreCompleto))
	    		.findFirst();
	    
	    if(profesor != null) {
	    	return ResponseEntity.ok(profesor);
	    }
	    
	    return ResponseEntity.status(HttpStatus.UNAUTHORIZED).body("Acceso denegado");
	}
	

}
