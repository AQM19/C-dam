package AD_Hoja_1_08;

import javax.xml.bind.annotation.*;
import java.util.ArrayList;

@XmlAccessorType(XmlAccessType.FIELD)
@XmlRootElement(name = "departamento")
public class Departamento {
    @XmlElement(name = "codigo")
    private String codigo;
    @XmlElement(name = "nombre")
    private String nombre;
    @XmlAttribute(name = "telefono")
    private String telefono;
    @XmlAttribute(name = "tipo")
    private String tipo;
    @XmlElement(name = "empleado")
    public ArrayList<Empleado> empleados = new ArrayList<Empleado>();

    public Departamento(){}
    public Departamento(String codigo, String nombre, String telefono, String tipo) {
        this.codigo = codigo;
        this.nombre = nombre;
        this.telefono = telefono;
        this.tipo = tipo;
    }

    public String getCodigo() {
        return codigo;
    }

    public void setCodigo(String codigo) {
        this.codigo = codigo;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getTelefono() {
        return telefono;
    }

    public void setTelefono(String telefono) {
        this.telefono = telefono;
    }

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    @Override
    public String toString() {
        return "Departamento{" +
                "codigo='" + codigo + '\'' +
                ", nombre='" + nombre + '\'' +
                ", telefono='" + telefono + '\'' +
                ", tipo='" + tipo + '\'' +
                '}';
    }
}
