package Hoja1;

public class Corredor /*extends Thread*/ implements Runnable{

    private String nombre;
    private int tiempo;

    public int numeroEntrenamiento;

    public Corredor(String nombre, int tiempo) {
        super();
        this.nombre = nombre;
        this.tiempo = tiempo;
        this.numeroEntrenamiento = 0;
    }

    @Override
    public void run() {
        //System.out.println("El corredor " + this.nombre + " ha salido.");
        this.numeroEntrenamiento++;
        try {
            Thread.sleep(this.tiempo*1000);
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }
        //System.out.println("El corredor " + this.nombre + " ha llegado.");
    }

}
