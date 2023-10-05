package model;

import java.util.Date;

import javax.persistence.Entity;
import javax.persistence.PrimaryKeyJoinColumn;
import javax.persistence.Table;

@Entity
@PrimaryKeyJoinColumn(name="numUsu")
@Table(name="usuarios_premium")
public class Premium extends Usuario{
	
	public static long getSerialversionuid() {
		return serialVersionUID;
	}
	
	private static final long serialVersionUID = 1l;
	private Integer antiguedad;
	private Float cuota;
	
	public Premium() {
		super();
	}

	public Integer getAntiguedad() {
		return antiguedad;
	}

	public void setAntiguedad(Integer antiguedad) {
		this.antiguedad = antiguedad;
	}

	public Float getCuota() {
		return cuota;
	}

	public void setCuota(Float cuota) {
		this.cuota = cuota;
	}
}
