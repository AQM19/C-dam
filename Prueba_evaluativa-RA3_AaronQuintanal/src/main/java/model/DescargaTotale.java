package model;

import java.io.Serializable;
import javax.persistence.*;


/**
 * The persistent class for the descarga_totales database table.
 * 
 */
@Entity
@Table(name="descarga_totales")
@NamedQuery(name="DescargaTotale.findAll", query="SELECT d FROM DescargaTotale d")
public class DescargaTotale implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	private int num;

	private int total;

	//bi-directional many-to-one association to Track
	@ManyToOne
	@JoinColumn(name="num_audio")
	private Track track;

	//bi-directional many-to-one association to Usuario
	@ManyToOne
	@JoinColumn(name="num_usuario")
	private Usuario usuario;

	public DescargaTotale() {
	}

	public int getNum() {
		return this.num;
	}

	public void setNum(int num) {
		this.num = num;
	}

	public int getTotal() {
		return this.total;
	}

	public void setTotal(int total) {
		this.total = total;
	}

	public Track getTrack() {
		return this.track;
	}

	public void setTrack(Track track) {
		this.track = track;
	}

	public Usuario getUsuario() {
		return this.usuario;
	}

	public void setUsuario(Usuario usuario) {
		this.usuario = usuario;
	}

}