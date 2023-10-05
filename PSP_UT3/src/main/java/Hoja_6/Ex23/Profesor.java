package Hoja_6.Ex23;

import java.util.concurrent.Semaphore;

public class Profesor extends Thread{

    Bienvenido saludo;
    private Semaphore semaphore;
    String nombre;
    int nalumnos;

    public Profesor(Bienvenido bienvenido, Semaphore semaphore, String nombre, int nalu){
        this.saludo = bienvenido;
        this.semaphore = semaphore;
        this.nombre = nombre;
        nalumnos = nalu;
    }

    @Override
    public void run() {
        System.out.println("El profesor ha llegado.");
        try{
            sleep(1000);
            saludo.llegadaProfesor(nombre);
            this.semaphore.release(nalumnos);
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }
    }
}
