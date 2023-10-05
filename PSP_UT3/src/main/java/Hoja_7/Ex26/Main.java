package Hoja_7.Ex26;

import java.util.concurrent.Semaphore;

public class Main {
    public static void main(String[] args) {

        Semaphore semaphore = new Semaphore(0);

        Hilo[] hilos = {
                new Hilo("Thread - 0", semaphore, 0, 2),
                new Hilo("Thread - 1", semaphore, 1, 2),
                new Hilo("Thread - 2", semaphore, 4, 5),
                new Hilo("Thread - 3", semaphore, 1, 2),
                new Hilo("Thread - 4", semaphore, 5, 6),
                new Hilo("Thread - 5", semaphore, 6, 6)
        };

        for(Hilo h : hilos){
            h.start();
        }

    }
}
