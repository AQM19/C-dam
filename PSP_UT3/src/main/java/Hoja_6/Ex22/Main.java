package Hoja_6.Ex22;

import java.util.concurrent.Semaphore;

public class Main {
    public static void main(String[] args) {
        Semaphore semaphore = new Semaphore(4);

        Fichero f = new Fichero("texto.txt");

        for(int i = 1; i <= 3; i++) {
            new Escritor("Escritor " + i, semaphore, f).start();
        }

        for(int i = 1; i <= 4; i++) {
            new Lector("Lector " + i, semaphore, f).start();
        }
    }
}
