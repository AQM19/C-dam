package es.intermodular.rest.controlador;

import java.util.List;
import java.util.Optional;
import java.util.function.Predicate;

import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;

import es.intermodular.rest.modelo.AvisosRepositorio;
import es.intermodular.rest.modelo.Aviso_guardia;

@RestController
public class AvisosController {
	private final AvisosRepositorio avisosRepositorio;
	
	public AvisosController(AvisosRepositorio avisosRepositorio) {
		this.avisosRepositorio = avisosRepositorio;
	}
	
	@PostMapping("/aviso")
	public ResponseEntity<?> generarAviso(@RequestBody Aviso_guardia avisonuevo){
		return ResponseEntity.ok(avisosRepositorio.save(avisonuevo));
	}
	
	@GetMapping("/avisos/{id}")
	public ResponseEntity<?> getAvisos(@PathVariable int id){
		List<Aviso_guardia> avisos = this.avisosRepositorio.findAll().stream().filter(x -> x.getProfesor() == id).toList();
		return ResponseEntity.ok(avisos);
	}
	
	@PutMapping("/aviso/confirmar/{id}")
	public ResponseEntity<?> actualizarConfirmacion(@PathVariable int id, @RequestBody Aviso_guardia avisoactualizado){
		Optional<Aviso_guardia> optionalAviso = avisosRepositorio.findById(id);
		
		if(optionalAviso.isPresent()) {
			Aviso_guardia aviso = optionalAviso.get();
				aviso.setConfirmado(avisoactualizado.isConfirmado());
				aviso.setAnulado(avisoactualizado.isAnulado());
				return ResponseEntity.ok(avisosRepositorio.save(aviso));
		} else {
			return ResponseEntity.notFound().build();
		}
	}
	
	@PutMapping("/aviso/anular/{id}")
	public ResponseEntity<?> actualizarAnulacion(@PathVariable int id, @RequestBody Aviso_guardia avisoactualizado){
		Optional<Aviso_guardia> optionalAviso = avisosRepositorio.findById(id);
		
		if(optionalAviso.isPresent()) {
			Aviso_guardia aviso = optionalAviso.get();
				aviso.setConfirmado(avisoactualizado.isConfirmado());
				aviso.setAnulado(avisoactualizado.isAnulado());
				return ResponseEntity.ok(avisosRepositorio.save(aviso));
		} else {
			return ResponseEntity.notFound().build();
		}
	}
}

