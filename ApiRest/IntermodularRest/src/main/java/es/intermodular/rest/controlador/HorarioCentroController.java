package es.intermodular.rest.controlador;

import java.util.List;

import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;

import es.intermodular.rest.modelo.HorarioCentro;
import es.intermodular.rest.modelo.HorarioCentroRepositorio;

@RestController
public class HorarioCentroController {
	private final HorarioCentroRepositorio horarioCentroRepositorio;
	
	public HorarioCentroController( HorarioCentroRepositorio horarioCentroRepositorio) {
		this.horarioCentroRepositorio = horarioCentroRepositorio;
	}
	
	@GetMapping("/horarioscentro")
	public List<HorarioCentro> getHorarioCentros(){
		return this.horarioCentroRepositorio.findAll();
	}
	
	@GetMapping("/horarioscentro/{id}")
	public HorarioCentro obtenerUno(@PathVariable int id) {
		return this.horarioCentroRepositorio.findById(id).orElse(null);
	}
	
	@PostMapping("/horarioscentro")
	public HorarioCentro nuevaHorarioCentro(@RequestBody HorarioCentro nueva) {
		return this.horarioCentroRepositorio.save(nueva);
	}
	
	@PutMapping("/horarioscentro/{id}")
	public HorarioCentro editarHorarioCentro(@RequestBody HorarioCentro editar, @PathVariable int id) {
		
		if(horarioCentroRepositorio.existsById(id)) {
			editar.setId(id);
			return horarioCentroRepositorio.save(editar);
		}
		else
		{
			return null;
		}
	}
	
	@DeleteMapping("/horarioscentro/{id}")
	public HorarioCentro borrarBaja(@PathVariable int id) {
		if(horarioCentroRepositorio.existsById(id)) {
			HorarioCentro horariocentro = horarioCentroRepositorio.findById(id).get();
			horarioCentroRepositorio.delete(horariocentro);
			return horariocentro;
		}
		else {
			return null;
		}
	}
}