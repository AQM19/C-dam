package Hoja_7.Ex24;

import java.util.concurrent.Semaphore;

public class Main {
    public static void main(String[] args) {
        Semaphore semaphore = new Semaphore(0);

        Hilo[] h = {
                new Hilo("h1", semaphore, 0, 3),
                new Hilo("h2", semaphore, 1, 1),
                new Hilo("h3", semaphore, 1, 1),
                new Hilo("h4", semaphore, 1, 1),
                new Hilo("h5", semaphore, 3, 3),
                new Hilo("h6", semaphore, 1, 1),
                new Hilo("h7", semaphore, 3, 0)
        };

        for(Hilo hilos : h){
            hilos.start();
        }


    }
}
