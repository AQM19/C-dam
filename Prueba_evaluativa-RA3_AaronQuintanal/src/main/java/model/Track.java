package model;

import java.io.Serializable;
import javax.persistence.*;
import java.util.List;


/**
 * The persistent class for the tracks database table.
 * 
 */
@Entity
@Table(name="tracks")
@NamedQuery(name="Track.findAll", query="SELECT t FROM Track t")
public class Track implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@Column(name="num_track")
	private int numTrack;

	private short anno;

	private boolean disponible;

	@Column(name="dur_seg")
	private int durSeg;

	private String interprete;

	@Column(name="num_descargas")
	private short numDescargas;

	private String titulo;

	//bi-directional many-to-one association to DescargaTotale
	@OneToMany(mappedBy="track")
	private List<DescargaTotale> descargaTotales;

	//bi-directional many-to-one association to Solicitude
	@OneToMany(mappedBy="track")
	private List<Solicitude> solicitudes;

	public Track() {
	}

	public int getNumTrack() {
		return this.numTrack;
	}

	public void setNumTrack(int numTrack) {
		this.numTrack = numTrack;
	}

	public short getAnno() {
		return this.anno;
	}

	public void setAnno(short anno) {
		this.anno = anno;
	}

	public boolean getDisponible() {
		return this.disponible;
	}

	public void setDisponible(boolean disponible) {
		this.disponible = disponible;
	}

	public int getDurSeg() {
		return this.durSeg;
	}

	public void setDurSeg(int durSeg) {
		this.durSeg = durSeg;
	}

	public String getInterprete() {
		return this.interprete;
	}

	public void setInterprete(String interprete) {
		this.interprete = interprete;
	}

	public short getNumDescargas() {
		return this.numDescargas;
	}

	public void setNumDescargas(short numDescargas) {
		this.numDescargas = numDescargas;
	}

	public String getTitulo() {
		return this.titulo;
	}

	public void setTitulo(String titulo) {
		this.titulo = titulo;
	}

	public List<DescargaTotale> getDescargaTotales() {
		return this.descargaTotales;
	}

	public void setDescargaTotales(List<DescargaTotale> descargaTotales) {
		this.descargaTotales = descargaTotales;
	}

	public DescargaTotale addDescargaTotale(DescargaTotale descargaTotale) {
		getDescargaTotales().add(descargaTotale);
		descargaTotale.setTrack(this);

		return descargaTotale;
	}

	public DescargaTotale removeDescargaTotale(DescargaTotale descargaTotale) {
		getDescargaTotales().remove(descargaTotale);
		descargaTotale.setTrack(null);

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
		solicitude.setTrack(this);

		return solicitude;
	}

	public Solicitude removeSolicitude(Solicitude solicitude) {
		getSolicitudes().remove(solicitude);
		solicitude.setTrack(null);

		return solicitude;
	}

}