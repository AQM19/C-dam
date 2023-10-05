package Hoja_6.Ex23;

import java.util.concurrent.Semaphore;

public class Alumno extends Thread{

    Bienvenido saludo;
    private Semaphore semaphore;

    public Alumno(Bienvenido bienvenido, Semaphore semaphore){
        this.saludo = bienvenido;
        this.semaphore = semaphore;
    }

    @Override
    public void run() {
        System.out.println("Un alumno ha llegado.");
        try{
            this.semaphore.acquire();
            sleep(1000);
            saludo.saludarProfesor();
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }
    }
}
