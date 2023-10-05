package AD_Hoja_2_07.Ex2;

import AD_Hoja_2_07.Ex2.Cancion;

import java.time.LocalDate;
import java.util.ArrayList;

public class Grupo {

    private int codgrupo;
    private String nombre;
    private String localidad;
    private String estilo;
    private boolean esgrupo;
    private int annoGrab;
    private LocalDate fechaEstreno;
    private String compania;
    private ArrayList<Cancion> canciones;

    public Grupo(int codgrupo, String nombre, String localidad, String estilo, boolean esgrupo, int annoGrab, LocalDate fechaEstreno, String compania) {
        this.codgrupo = codgrupo;
        this.nombre = nombre;
        this.localidad = localidad;
        this.estilo = estilo;
        this.esgrupo = esgrupo;
        this.annoGrab = annoGrab;
        this.fechaEstreno = fechaEstreno;
        this.compania = compania;
        this.canciones = new ArrayList<>();
    }

    public int getCodgrupo() {
        return codgrupo;
    }

    public String getNombre() {
        return nombre;
    }

    public String getLocalidad() {
        return localidad;
    }

    public String getEstilo() {
        return estilo;
    }

    public boolean isEsgrupo() {
        return esgrupo;
    }

    public int getAnnoGrab() {
        return annoGrab;
    }

    public LocalDate getFechaEstreno() {
        return fechaEstreno;
    }

    public String getCompania() {
        return compania;
    }

    public ArrayList<Cancion> getCanciones() {
        return canciones;
    }

    public boolean insertarCancion(Cancion cancion){
        return this.canciones.add(cancion);
    }

    @Override
    public String toString() {
        return "Grupo{" +
                "codgrupo=" + codgrupo +
                ", nombre='" + nombre + '\'' +
                ", localidad='" + localidad + '\'' +
                ", estilo='" + estilo + '\'' +
                ", esgrupo=" + esgrupo +
                ", annoGrab=" + annoGrab +
                ", fechaEstreno=" + fechaEstreno +
                ", compania='" + compania + '\'' +
                '}';
    }
}
