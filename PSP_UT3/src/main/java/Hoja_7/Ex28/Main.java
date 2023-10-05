package Hoja_7.Ex28;

import Hoja_7.Ex26.Hilo;

import java.util.concurrent.Semaphore;

public class Main {
    public static void main(String[] args) {
        Semaphore semaphore = new Semaphore(0);

        Hoja_7.Ex26.Hilo[] hilos = {
                new Hoja_7.Ex26.Hilo("Thread - 0", semaphore, 0, 2),
                new Hoja_7.Ex26.Hilo("Thread - 1", semaphore, 1, 0),
                new Hoja_7.Ex26.Hilo("Thread - 2", semaphore, 1, 6),
                new Hoja_7.Ex26.Hilo("Thread - 3", semaphore, 3, 4),
                new Hoja_7.Ex26.Hilo("Thread - 4", semaphore, 3, 4),
                new Hoja_7.Ex26.Hilo("Thread - 5", semaphore, 8, 8)
        };

        for(Hilo h : hilos){
            h.start();
        }
    }
}
