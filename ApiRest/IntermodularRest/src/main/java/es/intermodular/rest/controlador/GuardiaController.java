package es.intermodular.rest.controlador;

import java.rmi.ServerException;
import java.sql.Date;
import java.time.LocalDate;
import java.util.List;
import java.util.Optional;

import org.springframework.dao.EmptyResultDataAccessException;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;

import es.intermodular.rest.modelo.GuardiasRepositorio;
import es.intermodular.rest.modelo.Guardia;

@RestController
public class GuardiaController {
	private final GuardiasRepositorio guardiaRepositorio;
	
	public GuardiaController(GuardiasRepositorio guardiasRepositorio) {
		this.guardiaRepositorio = guardiasRepositorio;
	}
	
	@GetMapping("/listadoguardias")
	public List<Guardia> getGuardias(){
		return this.guardiaRepositorio.findAll();
	}
	
	@GetMapping("/guardias")
	public ResponseEntity<?> getGuardiasHoy(){
		List<Guardia> guardias = this.guardiaRepositorio.findAll().stream()
				.filter(x -> x.getFecha().equals(Date.valueOf(LocalDate.now())))
				.filter(x -> x.getEstado().equals("C"))
				.toList();
		

		return ResponseEntity.ok(guardias);
	}
	
	@PutMapping("/guardia/actualizar/{id}")
	public ResponseEntity<?> actualizarGuardia(@PathVariable int id, @RequestBody Guardia guardiaactualizada){
		Optional<Guardia> optionalGuardia = guardiaRepositorio.findById(id);
		
		if(optionalGuardia.isPresent()) {
			Guardia guardia = optionalGuardia.get();
			
			guardia.setProf_falta(guardiaactualizada.getProf_falta());
			guardia.setProf_hace_guardia(guardiaactualizada.getProf_hace_guardia());
			guardia.setEstado(guardiaactualizada.getEstado());
			guardia.setFecha(guardiaactualizada.getFecha());
			guardia.setHorario(guardiaactualizada.getHorario());
			guardia.setDia_semana(guardiaactualizada.getDia_semana());
			guardia.setHora(guardiaactualizada.getHora());
			guardia.setAviso(guardiaactualizada.getAviso());
			guardia.setGrupo(guardiaactualizada.getGrupo());
			guardia.setAula(guardiaactualizada.getAula());
			guardia.setObservaciones(guardiaactualizada.getObservaciones());

			return ResponseEntity.ok(guardiaRepositorio.save(guardia));
		} else {
			return ResponseEntity.notFound().build();
		}
	}
	
	@PostMapping("/guardias/crear")
	public  ResponseEntity<?> CrearGuardia(@RequestBody Guardia guardia){
		return ResponseEntity.ok(guardiaRepositorio.save(guardia));
	}

	@DeleteMapping(value = "/guardia/eliminar/{id}")
	public ResponseEntity<String> eliminarGuardiaPorId(@PathVariable int id) {
	    try {
	        guardiaRepositorio.deleteById(id);
	        return ResponseEntity.ok("Guardia eliminado con éxito.");
	    } catch (EmptyResultDataAccessException e) {
	        return ResponseEntity.status(HttpStatus.NOT_FOUND).body("No se encontró el guardia con el id proporcionado.");
	    }
	}

}
