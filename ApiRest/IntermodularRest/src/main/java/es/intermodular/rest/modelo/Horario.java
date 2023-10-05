package es.intermodular.rest.modelo;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name="horario")
public class Horario {
	
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int id;
	
	@Column(name = "profesor", nullable=false)
	private int profesor;
	
	@Column(name = "dia_semana", nullable=false)
	private int dia_semana;
	
	@Column(name = "hora", nullable=false)
	private int hora;
	
	@Column(name = "aula", length=20, nullable=true)
	private String aula;
	
	@Column(name = "grupo", length=10, nullable=true)
	private String grupo;
	
	@Column(name = "materia", length=10, nullable=true)
	private String materia;
	
	@Column(name = "genera_guardia", nullable=true)
	private boolean genera_guardia;

	//Getters y setters
	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public int getProfesor() {
		return profesor;
	}

	public void setProfesor(int profesor) {
		this.profesor = profesor;
	}

	public int getDia_semana() {
		return dia_semana;
	}

	public void setDia_semana(int dia_semana) {
		this.dia_semana = dia_semana;
	}

	public int getHora() {
		return hora;
	}

	public void setHora(int hora) {
		this.hora = hora;
	}

	public String getAula() {
		return aula;
	}

	public void setAula(String aula) {
		this.aula = aula;
	}

	public String getGrupo() {
		return grupo;
	}

	public void setGrupo(String grupo) {
		this.grupo = grupo;
	}

	public String getMateria() {
		return materia;
	}

	public void setMateria(String materia) {
		this.materia = materia;
	}

	public boolean isGenera_guardia() {
		return genera_guardia;
	}

	public void setGenera_guardia(boolean genera_guardia) {
		this.genera_guardia = genera_guardia;
	}
	
	
}
