import java.sql.Time;

public class Video {

    public int num_video;
    public String titulo;
    public String interprete;
    public Time duracion;
    public int anno;
    public int num_emisiones;
    public boolean disponible;

    public Video() {}

    public Video(int num_video, String titulo, String interprete, Time duracion, int anno, int num_emisiones, boolean disponible) {
        this.num_video = num_video;
        this.titulo = titulo;
        this.interprete = interprete;
        this.duracion = duracion;
        this.anno = anno;
        this.num_emisiones = num_emisiones;
        this.disponible = disponible;
    }
}
