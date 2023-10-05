package AD_Hoja_3_01;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;

@Entity
public class Cancion {
    @Id
    @GeneratedValue
    private Integer id;
    private String titulo;
    private String duracion;
    private Integer grupo;

    public Cancion(){}
    public Cancion(String titulo, String duracion, Integer grupo) {
        this.titulo = titulo;
        this.duracion = duracion;
        this.grupo = grupo;
    }

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
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

    public Integer getGrupo() {
        return grupo;
    }

    public void setGrupo(Integer grupo) {
        this.grupo = grupo;
    }

    @Override
    public String toString() {
        return "Cancion{" +
                "idCancion=" + id +
                ", titulo='" + titulo + '\'' +
                ", duracion='" + duracion + '\'' +
                ", grupo=" + grupo +
                '}';
    }
}
