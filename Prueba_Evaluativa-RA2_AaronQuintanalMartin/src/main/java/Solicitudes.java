import java.sql.Time;
import java.time.LocalDate;

public class Solicitudes {

    private int num;
    private int num_usu;
    private int video;
    private LocalDate fecha;
    private Time hora;
    private String via;

    public Solicitudes(){}

    public Solicitudes(int num, int num_usu, int video, LocalDate fecha, Time hora, String via) {
        this.num = num;
        this.num_usu = num_usu;
        this.video = video;
        this.fecha = fecha;
        this.hora = hora;
        this.via = via;
    }
}
