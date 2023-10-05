package Hoja3;

public class Hijo extends Thread{

    public int numHijo;

    public Hijo(int numHijo){
        super();
        this.numHijo = numHijo;
    }

    public void run(){
        System.out.println("Mi numero de generación es: " + numHijo);

        if(numHijo > 1){
            Hijo hijo = new Hijo(numHijo - 1);
            hijo.start();

            try {
                hijo.join();
            } catch (InterruptedException e) {
                System.out.println("Interrupción del hilo...");
            }
        }

        for(int i = 0; i < 10; i++) {
            System.out.println("Soy el hijo " + numHijo + " ejecutando " + i + " veces.");

            try {
                Thread.sleep((long)(Math.random()*600));
            } catch (InterruptedException e) {
                System.out.println("Interrupción del hilo...");
            }
        }
    }
}
