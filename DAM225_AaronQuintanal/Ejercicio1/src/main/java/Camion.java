import java.util.concurrent.Semaphore;

public class Camion extends Thread{
    private Semaphore semaphore;
    private int size; // Esto indica el tamaño, 1, 2 o 3

    public Camion(String nombre, Semaphore semaphore, int size){
        super(nombre);
        this.semaphore = semaphore;
        this.size = size;
    }

    @Override
    public void run() {
        solicitarDescarga();
        try {
            sleep(size*100); //Con una clase solvento TODA la problemática de los tamaños
            semaphore.acquire(size*3); // Lo mismo aqui, todos son multiplos de 3, así que lo aprovecho
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }

        descargarCamion();
        semaphore.release(size*3);
        descargaTerminada();
    }
    public void solicitarDescarga(){
        System.out.println(getName() + " solicitando descarga...");
    }
    public void descargarCamion(){
        System.out.println(getName() + " descargando...");

    }
    public void descargaTerminada(){
        System.out.println(getName() + " descarga terminada...");
    }
}
