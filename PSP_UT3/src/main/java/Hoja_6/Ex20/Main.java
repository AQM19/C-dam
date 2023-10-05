package Hoja_6.Ex20;

import java.util.concurrent.Semaphore;

public class Main {
    public static void main(String[] args) {

        Semaphore semaphore = new Semaphore(15);

        for(int i = 1; i <= 20; i++) {
            new Coche("Coche " + i, semaphore).start();
        }

    }
}
