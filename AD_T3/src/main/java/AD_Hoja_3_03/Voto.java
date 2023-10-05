package AD_Hoja_3_03;

import javax.persistence.*;

@Entity
public class Voto {
    @Id
    @Embedded
    private KeyVoto id;
    @ManyToOne
    private Cancion cancion;

    public Voto(){}
    public Voto(KeyVoto id, Cancion cancion) {
        this.id = id;
        this.cancion = cancion;
    }

    public KeyVoto getId() {
        return id;
    }

    public void setId(KeyVoto id) {
        this.id = id;
    }

    public Cancion getCancion() {
        return cancion;
    }

    public void setCancion(Cancion cancion) {
        this.cancion = cancion;
    }

    @Override
    public String toString() {
        return "Voto{" +
                "id=" + id.toString() +
                ", cancion=" + cancion +
                '}';
    }
}
