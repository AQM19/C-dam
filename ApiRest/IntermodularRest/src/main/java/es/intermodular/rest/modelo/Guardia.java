package es.intermodular.rest.modelo;

import java.sql.Date;
import java.time.LocalDate;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;

import com.fasterxml.jackson.annotation.JsonFormat;

@Entity
@Table(name="guardias")
public class Guardia {
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int id;
	
	@Column(name = "prof_falta", nullable=false)
	private int prof_falta;
	
	@Column(name = "prof_hace_guardia", nullable=true)
	private Integer prof_hace_guardia;
	
	@Column(name = "estado", nullable=false)
	private String estado;
	
	@Column(name = "fecha", nullable=false)
	@JsonFormat(pattern="yyyy-MM-dd'T'HH:mm:ss")
	private Date fecha;

	@Column(name = "horario", nullable=false)
	private int horario;
	
	@Column(name = "dia_semana", nullable=true)
	private Integer dia_semana;
	
	@Column(name = "hora", nullable=true)
	private String hora;
	
	@Column(name = "aviso", nullable=true)
	private Integer aviso;
	
	@Column(name = "grupo", length=10, nullable=true)
	private String grupo;
	
	@Column(name = "aula", length=10, nullable=true)
	private String aula;
	
	@Column(name = "observaciones", nullable=true)
	private String observaciones;

	//Getters y setters
	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public int getProf_falta() {
		return prof_falta;
	}

	public void setProf_falta(int prof_falta) {
		this.prof_falta = prof_falta;
	}

	public Integer getProf_hace_guardia() {
		return prof_hace_guardia;
	}

	public void setProf_hace_guardia(Integer prof_hace_guardia) {
		this.prof_hace_guardia = prof_hace_guardia;
	}

	public String getEstado() {
		return estado;
	}

	public void setEstado(String estado) {
		this.estado = estado;
	}

	public Date getFecha() {
		return fecha;
	}

	public void setFecha(Date fecha) {
		this.fecha = fecha;
	}

	public int getHorario() {
		return horario;
	}

	public void setHorario(int horario) {
		this.horario = horario;
	}

	public Integer getDia_semana() {
		return dia_semana;
	}

	public void setDia_semana(Integer dia_semana) {
		this.dia_semana = dia_semana;
	}

	public String getHora() {
		return hora;
	}

	public void setHora(String hora) {
		this.hora = hora;
	}

	public Integer getAviso() {
		return aviso;
	}

	public void setAviso(Integer aviso) {
		this.aviso = aviso;
	}

	public String getGrupo() {
		return grupo;
	}

	public void setGrupo(String grupo) {
		this.grupo = grupo;
	}

	public String getAula() {
		return aula;
	}

	public void setAula(String aula) {
		this.aula = aula;
	}

	public String getObservaciones() {
		return observaciones;
	}

	public void setObservaciones(String observaciones) {
		this.observaciones = observaciones;
	}
	
	
	
}
