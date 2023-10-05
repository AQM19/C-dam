package es.intermodular.rest.modelo;

import java.sql.Date;
import java.sql.Time;
import java.time.LocalDate;
import java.time.LocalDateTime;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name="avisos_guardia")
public class Aviso_guardia {
	
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int id_aviso;
	
	@Column(name = "profesor", nullable=false)
	private int profesor;
	
	@Column(name = "horario", nullable=false)
	private int horario;
	
	@Column(name = "motivo", length=45, nullable=true)
	private String motivo;
	
	@Column(name = "observaciones", nullable=true)
	private String observaciones;
	
	@Column(name = "confirmado", nullable=true)
	private boolean confirmado;
	
	@Column(name = "anulado", nullable=true)
	private boolean anulado;
	
	@Column(name = "fecha_guardia", nullable=true)
	private LocalDate fecha_guardia;
	
	@Column(name = "fecha_hora_aviso", nullable=true)
	private LocalDateTime fecha_hora_aviso;

	//Getters y setters
	public int getId_aviso() {
		return id_aviso;
	}

	public void setId_aviso(int id) {
		this.id_aviso = id;
	}

	public int getProfesor() {
		return profesor;
	}

	public void setProfesor(int profesor) {
		this.profesor = profesor;
	}

	public int getHorario() {
		return horario;
	}

	public void setHorario(int horario) {
		this.horario = horario;
	}

	public String getMotivo() {
		return motivo;
	}

	public void setMotivo(String motivo) {
		this.motivo = motivo;
	}

	public String getObservaciones() {
		return observaciones;
	}

	public void setObservaciones(String observaciones) {
		this.observaciones = observaciones;
	}

	public boolean isConfirmado() {
		return confirmado;
	}

	public void setConfirmado(boolean confirmado) {
		this.confirmado = confirmado;
	}

	public boolean isAnulado() {
		return anulado;
	}

	public void setAnulado(boolean anulado) {
		this.anulado = anulado;
	}

	public LocalDate getFecha_guardia() {
		return fecha_guardia;
	}

	public void setFecha_guardia(LocalDate fecha_guardia) {
		this.fecha_guardia = fecha_guardia;
	}

	public LocalDateTime getFecha_hora_aviso() {
		return fecha_hora_aviso;
	}

	public void setFecha_hora_aviso(LocalDateTime fecha_hora_aviso) {
		this.fecha_hora_aviso = fecha_hora_aviso;
	}
	
	
	
}
