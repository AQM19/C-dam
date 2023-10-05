package Hoja_6.Ex20;

import java.util.concurrent.Semaphore;

public class Coche extends Thread{
    private Semaphore semaphore;

    public Coche(String nombre, Semaphore semaphore){
        super(nombre);
        this.semaphore = semaphore;
    }

    @Override
    public void run() {
        System.out.println(getName() + " intentando aparcar.");

        try{
            semaphore.acquire();
        } catch (InterruptedException e){
            System.out.println(e);
        }

        System.out.println(getName() + " : Aparcado.");

        try{
            sleep((int) (Math.random() * 1000));
        } catch (InterruptedException e) {
            System.out.println(e);
        }

        System.out.println(getName() + " : Ya me he ido del garaje.");
        semaphore.release();
    }
}
