package AD_Hoja_2_07.Ex1;

import java.sql.Time;
import java.util.ArrayList;

public class Cancion {

    private int numCancion;
    private int grupo;
    private Time duracion;
    private String titulo;
    private int total_votos;
    private Grupo maingrupo;

    public Cancion(int numCancion, int grupo, Time duracion, String titulo, int total_votos, Grupo maingrupo) {
        this.numCancion = numCancion;
        this.grupo = grupo;
        this.duracion = duracion;
        this.titulo = titulo;
        this.total_votos = total_votos;
        this.maingrupo = maingrupo;
    }

    public int getNumCancion() {
        return numCancion;
    }

    public int getGrupo() {
        return grupo;
    }

    public Time getDuracion() {
        return duracion;
    }

    public String getTitulo() {
        return titulo;
    }

    public int getTotal_votos() {
        return total_votos;
    }
}
