package es.intermodular.rest.controlador;

import java.sql.Date;
import java.time.LocalDate;
import java.util.List;
import java.util.function.Predicate;
import java.util.Optional;

import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;

import es.intermodular.rest.modelo.Horario;
import es.intermodular.rest.modelo.HorarioRepositorio;

@RestController
public class HorarioController {
	private final HorarioRepositorio horarioRepositorio;
	
	public HorarioController( HorarioRepositorio horarioRepositorio) {
		this.horarioRepositorio = horarioRepositorio;
	}

	@GetMapping("/horario/{id}")
	public ResponseEntity<?> getHorarioProfesor(@PathVariable int id) {
		List<Horario> horarios = this.horarioRepositorio.findAll().stream()
				.filter(x -> x.getProfesor() == id)
				.filter(x -> x.getDia_semana() == LocalDate.now().getDayOfWeek().getValue())
				.toList();
		
		return ResponseEntity.ok(horarios);
	}
	
	@GetMapping("/horario/{id}/{hora}/{dia}")
	public ResponseEntity<?> getHorarioProfesorHora(@PathVariable int id, @PathVariable int hora, @PathVariable int dia){
		Optional<Horario> horario = this.horarioRepositorio.findAll().stream()
				.filter(x -> x.getProfesor() == id)
				.filter(x -> x.getDia_semana() == dia)
				.filter(x -> x.getHora() == hora)
				.findFirst();
		
		if(horario != null) {
			return ResponseEntity.ok(horario);
		}
		
		return ResponseEntity.status(HttpStatus.UNAUTHORIZED).body("Acceso denegado");
	}
	
}
