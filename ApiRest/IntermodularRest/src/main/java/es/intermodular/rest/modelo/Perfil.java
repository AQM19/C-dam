package es.intermodular.rest.modelo;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name="perfiles")
public class Perfil {
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int idperfil;
	
	@Column(name = "nom_perfil", nullable=false)
	private String nom_perfil;

	//Getters y setters
	public int getIdperfil() {
		return idperfil;
	}

	public void setIdperfil(int idperfil) {
		this.idperfil = idperfil;
	}

	public String getNom_perfil() {
		return nom_perfil;
	}

	public void setNom_perfil(String nom_perfil) {
		this.nom_perfil = nom_perfil;
	}
	
	
}
