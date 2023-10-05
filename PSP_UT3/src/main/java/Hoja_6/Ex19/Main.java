package Hoja_6.Ex19;

import java.io.IOException;
import java.util.concurrent.Semaphore;

public class Main {
    public static void main(String[] args) throws IOException {
        Semaphore semaforo = new Semaphore(1);
        Fichero f = new Fichero();
        FicheroHilo hilo1 = new FicheroHilo("Quijote", "En un lugar de la mancha", f, semaforo);
        FicheroHilo hilo2 = new FicheroHilo("Hamlet", "Ser o no ser", f, semaforo);

        hilo1.start();
        hilo2.start();

        try {
            hilo1.join();
            hilo2.join();
        } catch (InterruptedException e){
            System.out.println("Interrupcion.");
        }
        System.out.println("Terminamos el programa...");
        f.leer();
    }
}
