package es.intermodular.rest.modelo;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;

import org.hibernate.annotations.ColumnTransformer;

@Entity
@Table(name="profesores")
public class Profesor {
	
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int id;
	
	@Column(name = "user", length=15, nullable=false)
	private String user;
	
	@Column(name = "password", length=32, nullable=false)
	@ColumnTransformer(write = " MD5(?) ")
	private String password;
	
	@Column(name = "dni", length=9, nullable=false)
	private String dni;
	
	@Column(name = "nombre", length=45, nullable=false)
	private String nombre;
	
	@Column(name = "ape1", length=45, nullable=false)
	private String ape1;
	
	@Column(name = "ape2", length=45, nullable=true)
	private String ape2;
	
	@Column(name = "tfno", length=9, nullable=true)
	private String tfno;
	
	@Column(name = "baja", nullable=true)
	private boolean baja;
	
	@Column(name = "activo", nullable=true)
	private boolean activo;
	
	@Column(name = "dept_cod", length=5, nullable=true)
	private String dept_cod;
	
	@Column(name = "id_sustituye", nullable=true)
	private Integer id_sustituye;

	//Getters y setters
	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getUser() {
		return user;
	}

	public void setUser(String user) {
		this.user = user;
	}

	public String getPassword() {
		return password;
	}

	public void setPassword(String password) {
		this.password = password;
	}

	public String getDni() {
		return dni;
	}

	public void setDni(String dni) {
		this.dni = dni;
	}

	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public String getApe1() {
		return ape1;
	}

	public void setApe1(String ape1) {
		this.ape1 = ape1;
	}

	public String getApe2() {
		return ape2;
	}

	public void setApe2(String ape2) {
		this.ape2 = ape2;
	}

	public String getTfno() {
		return tfno;
	}

	public void setTfno(String tfno) {
		this.tfno = tfno;
	}

	public boolean isBaja() {
		return baja;
	}

	public void setBaja(boolean baja) {
		this.baja = baja;
	}

	public boolean isActivo() {
		return activo;
	}

	public void setActivo(boolean activo) {
		this.activo = activo;
	}

	public String getDept_cod() {
		return dept_cod;
	}

	public void setDept_cod(String dept_cod) {
		this.dept_cod = dept_cod;
	}

	public Integer getId_sustituye() {
		return id_sustituye;
	}

	public void setId_sustituye(int id_sustituye) {
		this.id_sustituye = id_sustituye;
	}
	
	
	
}
