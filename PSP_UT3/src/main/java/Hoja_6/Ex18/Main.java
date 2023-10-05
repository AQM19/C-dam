package Hoja_6.Ex18;

import java.util.concurrent.Semaphore;

public class Main {
    public static void main(String[] args) {
        Contador cont = new Contador();
        Semaphore semaforo = new Semaphore(1);

        for(int i = 0; i < Integer.parseInt(args[0]); i++){
            ContadorHilo c1 = new ContadorHilo(cont, semaforo);
            c1.start();
        }
    }
}
