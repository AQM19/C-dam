package AD_Hoja_3_01;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;

@Entity
public class Grupo {
    @Id
    @GeneratedValue
    private Integer id;
    private String nombre;
    private String localidad;
    private String estilo;
    private boolean esGrupo;
    public Integer yearFundation;

    public Grupo(){}
    public Grupo(String nombre, String localidad, String estilo, boolean esGrupo, Integer yearFundation) {
        this.nombre = nombre;
        this.localidad = localidad;
        this.estilo = estilo;
        this.esGrupo = esGrupo;
        this.yearFundation = yearFundation;
    }

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
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

    @Override
    public String toString() {
        return "Grupo{" +
                "id=" + id +
                ", nombre='" + nombre + '\'' +
                ", localidad='" + localidad + '\'' +
                ", estilo='" + estilo + '\'' +
                ", esGrupo=" + esGrupo +
                ", yearFundation=" + yearFundation +
                '}';
    }
}
