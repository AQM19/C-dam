package Hoja_6.Ex18;

import java.util.concurrent.Semaphore;

public class ContadorHilo extends Thread{

    private Contador cont;
    private Semaphore semaforo;

    public ContadorHilo(Contador cont, Semaphore semaforo) {
        super();
        this.cont = cont;
        this.semaforo = semaforo;
    }

    public void run(){
        for(int i = 0; i < 4; i++){
            try {
                semaforo.acquire();
            } catch (InterruptedException ex) {
            }
            System.out.println(getName() + " - contador: "+cont.incContador(1));
            semaforo.release();
        }
        System.out.println("Fin "+getName()+"...");
    }

}
