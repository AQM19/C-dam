package AD_Hoja_3_03;

import javax.persistence.Embeddable;

@Embeddable
public class KeyVoto {
    private String usuario;
    private String fecha;


    public KeyVoto(){}
    public KeyVoto(String fecha, String usuario) {
        this.fecha = fecha;
        this.usuario = usuario;
    }

    public String getFecha() {
        return fecha;
    }

    public void setFecha(String fecha) {
        this.fecha = fecha;
    }

    public String getUsuario() {
        return usuario;
    }

    public void setUsuario(String usuario) {
        this.usuario = usuario;
    }

    @Override
    public String toString() {
        return "KeyVoto{" +
                "fecha='" + fecha + '\'' +
                ", usuario='" + usuario + '\'' +
                '}';
    }
}
