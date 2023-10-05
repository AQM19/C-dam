import java.time.LocalDate;

public class Usuarios {

    public int num_usu;
    public String usuario;
    public String contra;
    public String nombre;
    public String apellidos;
    public LocalDate fechanac;
    public int num_peticiones;

    public Usuarios(){}

    public Usuarios(int num_usu, String usuario, String contra, String nombre, String apellidos, LocalDate fechanac, int num_peticiones) {
        this.num_usu = num_usu;
        this.usuario = usuario;
        this.contra = contra;
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.fechanac = fechanac;
        this.num_peticiones = num_peticiones;
    }
}
