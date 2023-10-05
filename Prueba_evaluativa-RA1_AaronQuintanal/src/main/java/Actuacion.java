import javax.xml.bind.annotation.*;
import java.time.LocalDate;

@XmlAccessorType(XmlAccessType.FIELD)
@XmlRootElement(name = "actuacion")
public class Actuacion {

    @XmlAttribute(name = "numero")
    private int numero;
    @XmlElement(name = "grupo")
    private String grupo;
    @XmlElement(name = "fecha")
    private LocalDate fecha;
    @XmlElement(name = "hora")
    private String hora;
    @XmlElement(name = "escenario")
    private String escenario;

    public Actuacion(){}

    public Actuacion(int numero, String escenario, LocalDate fecha, String hora){
        this.numero = numero;
        this.grupo = "";
        this.fecha = fecha;
        this.hora = hora;
        this.escenario = escenario;
    }
    public Actuacion(int numero, String grupo, LocalDate fecha, String hora, String escenario) {
        this.numero = numero;
        this.grupo = grupo;
        this.fecha = fecha;
        this.hora = hora;
        this.escenario = escenario;
    }

    public int getNumero() {
        return numero;
    }

    public void setNumero(int numero) {
        this.numero = numero;
    }

    public String getGrupo() {
        return grupo;
    }

    public void setGrupo(String grupo) {
        this.grupo = grupo;
    }

    public LocalDate getFecha() {
        return fecha;
    }

    public void setFecha(LocalDate fecha) {
        this.fecha = fecha;
    }

    public String getHora() {
        return hora;
    }

    public void setHora(String hora) {
        this.hora = hora;
    }

    public String getEscenario() {
        return escenario;
    }

    public void setEscenario(String escenario) {
        this.escenario = escenario;
    }

    @Override
    public String toString() {
        return "Actuacion{" +
                "numero=" + numero +
                ", grupo='" + grupo + '\'' +
                ", fecha=" + fecha +
                ", hora='" + hora + '\'' +
                ", escenario='" + escenario + '\'' +
                '}';
    }
}
