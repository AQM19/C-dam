package Hoja_7.Ex24;

import java.util.concurrent.Semaphore;

public class Hilo extends Thread{

    private Semaphore semaphore;
    private int acquire;
    private int release;

    public Hilo(String name, Semaphore semaphore, int acquire, int release){
        super(name);
        this.semaphore = semaphore;
        this.acquire = acquire;
        this.release = release;
    }

    @Override
    public void run() {
        try{
            this.semaphore.acquire(acquire);
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }

        System.out.println(getName() + " empezando.");

        try{
            sleep(1000);
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }

        System.out.println(getName() + " terminado.");
        this.semaphore.release(release);
    }
}
