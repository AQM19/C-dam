package AD_Hoja_3_03;

import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.OneToMany;
import javax.persistence.OneToOne;

@Entity
public class Representante {
    @Id
    @OneToOne
    private String id;
    private String nombre;
    private String apellidos;
    @OneToOne
    private Grupo representa;

    public Representante() {}

    public Representante(String id, String nombre, String apellidos) {
        this.id = id;
        this.nombre = nombre;
        this.apellidos = apellidos;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getApellidos() {
        return apellidos;
    }

    public void setApellidos(String apellidos) {
        this.apellidos = apellidos;
    }

    public Grupo getRepresenta() {
        return representa;
    }

    public void setRepresenta(Grupo representa) {
        this.representa = representa;
    }
}
