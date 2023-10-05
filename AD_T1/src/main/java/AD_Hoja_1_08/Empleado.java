package AD_Hoja_1_08;

import javax.xml.bind.annotation.*;

@XmlAccessorType(XmlAccessType.FIELD)
@XmlRootElement
public class Empleado {
    @XmlElement(name = "nombre")
    private String nombre;
    @XmlElement(name = "puesto")
    private String puesto;
    @XmlAttribute(name = "salario")
    private int salario;

    public Empleado(){};
    public Empleado(String nombre,String puesto,int salario){
        this.nombre = nombre;
        this.puesto = puesto;
        this.salario = salario;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getPuesto() {
        return puesto;
    }

    public void setPuesto(String puesto) {
        this.puesto = puesto;
    }

    public int getSalario() {
        return salario;
    }

    public void setSalario(int salario) {
        this.salario = salario;
    }
}
