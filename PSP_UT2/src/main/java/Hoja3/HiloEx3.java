package Hoja3;

public class HiloEx3  extends Thread{

    private boolean stopHilo;

    public HiloEx3(){
        this.stopHilo = false;
    }

    public void pararHilo(){
        System.out.println("Se para el hilo.");
        this.stopHilo = true;
    }

    public void run(){
        while(!this.stopHilo){
            try {
                System.out.println("El hilo sigue en falso.");
                sleep(1000);
            } catch (InterruptedException e) {
                throw new RuntimeException(e);
            }
        }
    }

}
