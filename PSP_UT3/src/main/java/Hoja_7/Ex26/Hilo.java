package Hoja_7.Ex26;

import java.util.concurrent.Semaphore;

public class Hilo extends Thread{

    private Semaphore semaphore;
    private int aq;
    private int rl;

    public Hilo(String name, Semaphore semaphore, int aq, int rl) {
        super(name);
        this.semaphore = semaphore;
        this.aq = aq;
        this.rl = rl;
    }

    @Override
    public void run() {
        try{
            this.semaphore.acquire(aq);
            sleep(2500);
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }

        System.out.println(getName() + " inicializado.");
        finalizarEjecucion();
    }

    private void finalizarEjecucion(){
        try{
            sleep(2500);
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }

        this.semaphore.release(rl);
        System.out.println(getName() + " finalizado.");
    }
}
