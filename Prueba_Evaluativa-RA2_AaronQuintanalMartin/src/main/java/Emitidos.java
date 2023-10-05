import java.sql.Time;
import java.time.LocalDate;

public class Emitidos {

    public int num_emision;
    public int video;
    public LocalDate fecha;
    public Time hora;
    public int num_peticiones;

    public Emitidos(){}

    public Emitidos(int num_emision, int video, LocalDate fecha, Time hora, int num_peticiones) {
        this.num_emision = num_emision;
        this.video = video;
        this.fecha = fecha;
        this.hora = hora;
        this.num_peticiones = num_peticiones;
    }
}
