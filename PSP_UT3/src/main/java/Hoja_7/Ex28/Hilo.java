package Hoja_7.Ex28;

import java.util.concurrent.Semaphore;

public class Hilo extends Thread{
    private Semaphore semaphore;
    private int ac;
    private int rl;

    public Hilo(String name, Semaphore semaphore, int ac, int rl){
        super(name);
        this.semaphore = semaphore;
        this.ac = ac;
        this.rl = rl;
    }

    @Override
    public void run() {
        try{
            this.semaphore.acquire(ac);
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }

        System.out.println(getName() + " inicializado.");

        liberarTension();
    }

    private void liberarTension(){
        try{
            sleep(1000);
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }

        System.out.println(getName() + " finalizado.");
        this.semaphore.release(rl);
    }
}
