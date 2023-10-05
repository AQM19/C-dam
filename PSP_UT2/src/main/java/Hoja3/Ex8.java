package Hoja3;

public class Ex8 {
    public static void main(String[] args) throws InterruptedException {

        Hijo hijo = new Hijo(5);

        hijo.start();

        try {
            hijo.join();
        } catch (InterruptedException e){
            System.out.println("Interrupción del hilo.");
        }
    }
}
