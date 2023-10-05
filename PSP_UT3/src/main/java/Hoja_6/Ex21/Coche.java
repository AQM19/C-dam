package Hoja_6.Ex21;

import java.util.concurrent.Semaphore;

public class Coche extends Thread{

    private Semaphore semaphore;

    public Coche(String nombre, Semaphore semaphore){
        super(nombre);
        this.semaphore = semaphore;
    }

    @Override
    public void run() {
        try {
            semaphore.acquire();
        } catch (InterruptedException e) {
            System.out.println(e);
        }

        peticionEntradaTunel();
    }

    private void peticionEntradaTunel(){
        System.out.println("Estoy en el tunel " + this.getName());

        try {
            sleep((int) (Math.random() * 1000));
        } catch (InterruptedException e) {
            System.out.println(e);
        }

        System.out.println("Ya he salido del tunel : " + this.getName());
        semaphore.release();
    }
}
