package AD_Hoja_3_03;

import javax.persistence.*;
import java.util.List;

@Entity
public class Grupo {
    @Id
    @GeneratedValue
    private Integer idGrupo;
    private String nombre;
    private String localidad;
    private String estilo;
    private boolean esGrupo;
    private Integer yearFundacion;
    private Contacto contacto;
    @OneToMany(mappedBy = "grupo")
    private List<Cancion> canciones;
    @OneToOne(mappedBy = "representa")
    private Representante representante;

    public Grupo() {}

    public Grupo(Integer idGrupo, String nombre, String localidad, String estilo, boolean esGrupo, Integer yearFundacion) {
        this.idGrupo = idGrupo;
        this.nombre = nombre;
        this.localidad = localidad;
        this.estilo = estilo;
        this.esGrupo = esGrupo;
        this.yearFundacion = yearFundacion;
    }

    public Integer getIdGrupo() {
        return idGrupo;
    }

    public void setIdGrupo(Integer idGrupo) {
        this.idGrupo = idGrupo;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getLocalidad() {
        return localidad;
    }

    public void setLocalidad(String localidad) {
        this.localidad = localidad;
    }

    public String getEstilo() {
        return estilo;
    }

    public void setEstilo(String estilo) {
        this.estilo = estilo;
    }

    public boolean isEsGrupo() {
        return esGrupo;
    }

    public void setEsGrupo(boolean esGrupo) {
        this.esGrupo = esGrupo;
    }

    public Integer getYearFundacion() {
        return yearFundacion;
    }

    public void setYearFundacion(Integer yearFundacion) {
        this.yearFundacion = yearFundacion;
    }

    public List<Cancion> getCanciones() {
        return canciones;
    }

    public void setCanciones(List<Cancion> canciones) {
        this.canciones = canciones;
    }

    public Contacto getContacto() {
        return contacto;
    }

    public void setContacto(Contacto contacto) {
        this.contacto = contacto;
    }

    public Representante getRepresentante() {
        return representante;
    }
    public void setRepresentante(Representante representante) {
        this.representante = representante;
    }

    @Override
    public String toString() {
        return "Grupo{" +
                "idGrupo=" + idGrupo +
                ", nombre='" + nombre + '\'' +
                ", localidad='" + localidad + '\'' +
                ", estilo='" + estilo + '\'' +
                ", esGrupo=" + esGrupo +
                ", yearFundacion=" + yearFundacion +
                ", canciones=" + canciones +
                '}';
    }
}
