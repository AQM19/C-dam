package es.intermodular.rest.modelo;

import java.sql.Date;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;
@Entity
@Table(name="bajas_permisos")
public class Baja_Permiso {
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int idbaja;
	
	@Column(name = "profesor")
	private int profesor;
	
	@Column(name = "fechainicio")
	private Date fechainicio;
	
	@Column(name = "fechafin")
	private Date fechafin;
	
	@Column(name = "tipo", nullable=false)
	private Tipo tipo;

	//Getters y setters
	public int getIdbaja() {
		return idbaja;
	}

	public void setIdbaja(int idbaja) {
		this.idbaja = idbaja;
	}

	public int getProfesor() {
		return profesor;
	}

	public void setProfesor(int profesor) {
		this.profesor = profesor;
	}

	public Date getFechainicio() {
		return fechainicio;
	}

	public void setFechainicio(Date fechainicio) {
		this.fechainicio = fechainicio;
	}

	public Date getFechafin() {
		return fechafin;
	}

	public void setFechafin(Date fechafin) {
		this.fechafin = fechafin;
	}

	public Tipo getTipo() {
		return tipo;
	}

	public void setTipo(Tipo tipo) {
		this.tipo = tipo;
	}
	
}
