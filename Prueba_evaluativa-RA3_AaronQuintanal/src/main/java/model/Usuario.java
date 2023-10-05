package model;

import java.io.Serializable;
import javax.persistence.*;
import java.util.Date;
import java.util.List;

@Entity
@Table(name="usuarios")
@Inheritance(strategy = InheritanceType.JOINED)
@NamedQuery(name="Usuario.findAll", query="SELECT u FROM Usuario u")
public class Usuario implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@Column(name="num_usu")
	private int numUsu;

	private String apellidos;

	private String contra;

	@Temporal(TemporalType.DATE)
	private Date fechanac;

	private String nombre;

	@Column(name="num_descargas")
	private int numDescargas;

	private String usuario;

	//bi-directional many-to-one association to DescargaTotale
	@OneToMany(mappedBy="usuario")
	private List<DescargaTotale> descargaTotales;

	//bi-directional many-to-one association to Solicitude
	@OneToMany(mappedBy="usuarioBean")
	private List<Solicitude> solicitudes;

	public Usuario() {
	}

	public int getNumUsu() {
		return this.numUsu;
	}

	public void setNumUsu(int numUsu) {
		this.numUsu = numUsu;
	}

	public String getApellidos() {
		return this.apellidos;
	}

	public void setApellidos(String apellidos) {
		this.apellidos = apellidos;
	}

	public String getContra() {
		return this.contra;
	}

	public void setContra(String contra) {
		this.contra = contra;
	}

	public Date getFechanac() {
		return this.fechanac;
	}

	public void setFechanac(Date fechanac) {
		this.fechanac = fechanac;
	}

	public String getNombre() {
		return this.nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public int getNumDescargas() {
		return this.numDescargas;
	}

	public void setNumDescargas(int numDescargas) {
		this.numDescargas = numDescargas;
	}

	public String getUsuario() {
		return this.usuario;
	}

	public void setUsuario(String usuario) {
		this.usuario = usuario;
	}

	public List<DescargaTotale> getDescargaTotales() {
		return this.descargaTotales;
	}

	public void setDescargaTotales(List<DescargaTotale> descargaTotales) {
		this.descargaTotales = descargaTotales;
	}

	public DescargaTotale addDescargaTotale(DescargaTotale descargaTotale) {
		getDescargaTotales().add(descargaTotale);
		descargaTotale.setUsuario(this);

		return descargaTotale;
	}

	public DescargaTotale removeDescargaTotale(DescargaTotale descargaTotale) {
		getDescargaTotales().remove(descargaTotale);
		descargaTotale.setUsuario(null);

		return descargaTotale;
	}

	public List<Solicitude> getSolicitudes() {
		return this.solicitudes;
	}

	public void setSolicitudes(List<Solicitude> solicitudes) {
		this.solicitudes = solicitudes;
	}

	public Solicitude addSolicitude(Solicitude solicitude) {
		getSolicitudes().add(solicitude);
		solicitude.setUsuarioBean(this);

		return solicitude;
	}

	public Solicitude removeSolicitude(Solicitude solicitude) {
		getSolicitudes().remove(solicitude);
		solicitude.setUsuarioBean(null);

		return solicitude;
	}

}