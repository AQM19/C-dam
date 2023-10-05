package Hoja_7.Ex27;

import Hoja_7.Ex26.Hilo;

import java.util.concurrent.Semaphore;

public class Main {
    public static void main(String[] args) {
        Semaphore semaphore = new Semaphore(0);

        Hoja_7.Ex26.Hilo[] hilos = {
                new Hoja_7.Ex26.Hilo("Thread - 1", semaphore, 0, 3),
                new Hoja_7.Ex26.Hilo("Thread - 2", semaphore, 1, 4),
                new Hoja_7.Ex26.Hilo("Thread - 3", semaphore, 1, 4),
                new Hoja_7.Ex26.Hilo("Thread - 4", semaphore, 1, 8),
                new Hoja_7.Ex26.Hilo("Thread - 5", semaphore, 4, 4),
                new Hoja_7.Ex26.Hilo("Thread - 6", semaphore, 4, 4),
                new Hoja_7.Ex26.Hilo("Thread - 7", semaphore, 12, 12)
        };

        for(Hilo h : hilos){
            h.start();
        }
    }
}
