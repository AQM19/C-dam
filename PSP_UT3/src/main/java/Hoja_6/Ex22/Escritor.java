package Hoja_6.Ex22;

import java.util.concurrent.Semaphore;

public class Escritor extends Thread{
    private Fichero fichero;
    private Semaphore semaphore;

    public Escritor(String name, Semaphore semaphore, Fichero fichero){
        super(name);
        this.semaphore = semaphore;
        this.fichero = fichero;
    }

    @Override
    public void run() {
        try{
            semaphore.acquire();
        } catch (InterruptedException e) {
            System.out.println(e);
        }
        fichero.escribir();
        try{
            sleep((int) (Math.random() * 1000));
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }
        System.out.println(getName() + ": Ya he escrito.");
        semaphore.release();
    }
}
