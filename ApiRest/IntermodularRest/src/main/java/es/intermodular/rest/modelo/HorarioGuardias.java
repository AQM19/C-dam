package es.intermodular.rest.modelo;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name="horarioguardias")
public class HorarioGuardias {
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)	
	private int id;
	
	@Column(name = "profesor", nullable=false)
	private int profesor;
	
	@Column(name = "dia_semana", nullable=false)
	private int dia_semana;
	
	@Column(name = "hora_guardia", nullable=false)
	private int hora_guardia;
	
	@Column(name = "realizadas", nullable=false)
	private int realizadas;

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

	public int getHora_guardia() {
		return hora_guardia;
	}

	public void setHora_guardia(int hora_guardia) {
		this.hora_guardia = hora_guardia;
	}

	public int getRealizadas() {
		return realizadas;
	}

	public void setRealizadas(int realizadas) {
		this.realizadas = realizadas;
	}
	
	
	
}
