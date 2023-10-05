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

import es.intermodular.rest.modelo.HorarioGuardias;
import es.intermodular.rest.modelo.HorarioGuardiasRepositorio;

@RestController
public class HorarioGuardiasController {
	private final HorarioGuardiasRepositorio horarioGuardiasRepositorio;
	
	public HorarioGuardiasController( HorarioGuardiasRepositorio horarioGuardiasRepositorio) {
		this.horarioGuardiasRepositorio = horarioGuardiasRepositorio;
	}
	
	@GetMapping("/horariosguardias")
	public List<HorarioGuardias> getHorarioGuardias(){
		return this.horarioGuardiasRepositorio.findAll();
	}
	@GetMapping("/horariosguardias/profesor/{id}")
	public List<HorarioGuardias> getHorariosGuardiasPorProfesor(@PathVariable int id){
		Predicate<HorarioGuardias> byProfesor = a -> a.getProfesor() == id;
		return this.horarioGuardiasRepositorio.findAll().stream().filter(byProfesor).toList();
	}
	
	@GetMapping("/horariosguardias/{id}")
	public HorarioGuardias obtenerUno(@PathVariable int id) {
		return this.horarioGuardiasRepositorio.findById(id).orElse(null);
	}
	
	@PostMapping("/horariosguardias")
	public HorarioGuardias nuevaHorarioCentro(@RequestBody HorarioGuardias nueva) {
		return this.horarioGuardiasRepositorio.save(nueva);
	}
	
	@PutMapping("/horariosguardias/{id}")
	public HorarioGuardias editarHorarioCentro(@RequestBody HorarioGuardias editar, @PathVariable int id) {
		
		if(horarioGuardiasRepositorio.existsById(id)) {
			editar.setId(id);
			return horarioGuardiasRepositorio.save(editar);
		}
		else
		{
			return null;
		}
	}
	
	@DeleteMapping("/horariosguardias/{id}")
	public HorarioGuardias borrarHorarioCentro(@PathVariable int id) {
		if(horarioGuardiasRepositorio.existsById(id)) {
			HorarioGuardias horarioguardias = horarioGuardiasRepositorio.findById(id).get();
			horarioGuardiasRepositorio.delete(horarioguardias);
			return horarioguardias;
		}
		else {
			return null;
		}
	}
}