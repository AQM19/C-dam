package AD_Hoja_3_02;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;
import javax.persistence.ManyToOne;

@Entity
public class Cancion {
    @Id
    @GeneratedValue
    private Integer idCancion;
    private String titulo;
    private String duracion;
    @ManyToOne
    private Grupo grupo;

    public Cancion(){}
    public Cancion(Integer idCancion, String titulo, String duracion, Grupo grupo) {
        this.idCancion = idCancion;
        this.titulo = titulo;
        this.duracion = duracion;
        this.grupo = grupo;
    }

    public Integer getIdCancion() {
        return idCancion;
    }

    public void setIdCancion(Integer idCancion) {
        this.idCancion = idCancion;
    }

    public String getTitulo() {
        return titulo;
    }

    public void setTitulo(String titulo) {
        this.titulo = titulo;
    }

    public String getDuracion() {
        return duracion;
    }

    public void setDuracion(String duracion) {
        this.duracion = duracion;
    }

    public Grupo getGrupo() {
        return grupo;
    }

    public void setGrupo(Grupo grupo) {
        this.grupo = grupo;
    }

    @Override
    public String toString() {
        return "Cancion{" +
                "idCancion=" + idCancion +
                ", titulo='" + titulo + '\'' +
                ", duracion='" + duracion + '\'' +
                ", grupo=" + grupo.getNombre() +
                '}';
    }
}
