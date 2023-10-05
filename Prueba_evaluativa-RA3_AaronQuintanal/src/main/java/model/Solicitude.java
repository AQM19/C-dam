package model;

import java.io.Serializable;
import javax.persistence.*;
import java.sql.Time;
import java.util.Date;


/**
 * The persistent class for the solicitudes database table.
 * 
 */
@Entity
@Table(name="solicitudes")
@NamedQuery(name="Solicitude.findAll", query="SELECT s FROM Solicitude s")
public class Solicitude implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	private int num;

	@Temporal(TemporalType.DATE)
	private Date fecha;

	private boolean finalizada;

	private Time hora;

	//bi-directional many-to-one association to Track
	@ManyToOne
	@JoinColumn(name="audio")
	private Track track;

	//bi-directional many-to-one association to Usuario
	@ManyToOne
	@JoinColumn(name="usuario")
	private Usuario usuarioBean;

	public Solicitude() {
	}

	public int getNum() {
		return this.num;
	}

	public void setNum(int num) {
		this.num = num;
	}

	public Date getFecha() {
		return this.fecha;
	}

	public void setFecha(Date fecha) {
		this.fecha = fecha;
	}

	public boolean getFinalizada() {
		return this.finalizada;
	}

	public void setFinalizada(boolean finalizada) {
		this.finalizada = finalizada;
	}

	public Time getHora() {
		return this.hora;
	}

	public void setHora(Time hora) {
		this.hora = hora;
	}

	public Track getTrack() {
		return this.track;
	}

	public void setTrack(Track track) {
		this.track = track;
	}

	public Usuario getUsuarioBean() {
		return this.usuarioBean;
	}

	public void setUsuarioBean(Usuario usuarioBean) {
		this.usuarioBean = usuarioBean;
	}

}