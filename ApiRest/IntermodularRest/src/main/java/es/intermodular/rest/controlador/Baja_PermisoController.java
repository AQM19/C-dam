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

import es.intermodular.rest.modelo.Baja_Permiso;
import es.intermodular.rest.modelo.Baja_PermisoRepositorio;

@RestController
public class Baja_PermisoController {
	private final Baja_PermisoRepositorio baja_permisoRepositorio;
	
	public Baja_PermisoController(Baja_PermisoRepositorio baja_permisoRepositorio) {
		this.baja_permisoRepositorio = baja_permisoRepositorio;
	}
	
	@GetMapping("/bajaspermisos")
	public List<Baja_Permiso> getBajasPermisos(){
		return this.baja_permisoRepositorio.findAll();
	}
	@GetMapping("/bajasPermisos/profesor/{id}")
	public List<Baja_Permiso> getBajasPermisosPorProfesor(@PathVariable int id){
		Predicate<Baja_Permiso> byProfesor = a -> a.getProfesor() == id;
		return this.baja_permisoRepositorio.findAll().stream().filter(byProfesor).toList();
	}
	@GetMapping("/bajaspermisos/{id}")
	public Baja_Permiso obtenerUno(@PathVariable int id) {
		return this.baja_permisoRepositorio.findById(id).orElse(null);
	}
	
	@PostMapping("/bajaspermisos")
	public Baja_Permiso nuevaBaja(@RequestBody Baja_Permiso nueva) {
		return this.baja_permisoRepositorio.save(nueva);
	}
	
	@PutMapping("/bajaspermisos/{id}")
	public Baja_Permiso editarBaja(@RequestBody Baja_Permiso editar, @PathVariable int id) {
		
		if(baja_permisoRepositorio.existsById(id)) {
			editar.setIdbaja(id);
			return baja_permisoRepositorio.save(editar);
		}
		else
		{
			return null;
		}
	}
	
	@DeleteMapping("/bajaspermisos/{id}")
	public Baja_Permiso borrarBaja(@PathVariable int id) {
		if(baja_permisoRepositorio.existsById(id)) {
			Baja_Permiso baja = baja_permisoRepositorio.findById(id).get();
			baja_permisoRepositorio.delete(baja);
			return baja;
		}
		else {
			return null;
		}
	}
}

