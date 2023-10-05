package Hoja3;

public class Hilo extends Thread{

    private String nombre;

    public Hilo(String nombre) {
        super(nombre);
        this.nombre = nombre;
    }

    public void start() {
        System.out.println("Nombre: " + getNombre());
        System.out.println("Prioridad: " + this.getPriority());
        System.out.println("Id: " + this.getId() + "\n");
    }

    public String getNombre() {
        return this.nombre;
    }
}
