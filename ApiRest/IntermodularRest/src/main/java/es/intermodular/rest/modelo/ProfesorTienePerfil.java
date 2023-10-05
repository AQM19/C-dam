package es.intermodular.rest.modelo;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name="profesor_tiene_perfil")
public class ProfesorTienePerfil {
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)	
	private int id;
	
	@Column(name = "profesor", nullable=false)
	private int profesor;
	
	@Column(name = "perfil", nullable=false)
	private int perfil;

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

	public int getPerfil() {
		return perfil;
	}

	public void setPerfil(int perfil) {
		this.perfil = perfil;
	}
	
	
}
