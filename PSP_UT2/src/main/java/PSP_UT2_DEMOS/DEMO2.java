package PSP_UT2_DEMOS;

public class DEMO2 {
    public static void main(String[] args) {
        /*
        SimpleThread hilo1 = new SimpleThread("Hilo 1");
        SimpleThread hilo2 = new SimpleThread("Hilo 2");

        hilo1.start();
        hilo2.start();

        System.out.println("Fin de la ejecución.");
        */

        SimpleThreadRunnable hilo1 = new SimpleThreadRunnable("Hilo 1");
        SimpleThreadRunnable hilo2 = new SimpleThreadRunnable("Hilo 2");

        Thread h1 = new Thread(hilo1);
        Thread h2 = new Thread(hilo2);

        h1.start();
        h2.start();

        try{
            h1.join();
            h2.join();
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }

        System.out.println("Fin de la ejecución.");
    }
}
