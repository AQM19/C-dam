package Hoja5.E2;

public class Cuenta {

    private int cuenta = 100;
    private boolean lleno = false;

    public synchronized void sale(){
        while (!lleno) {
            try {
                wait();
            } catch (InterruptedException e) {
                System.out.println("Interrupción del hilo...");
            }
        }
        cuenta -= 1;
        System.out.println("Numero de personas: " + cuenta);
        lleno = false;
        notifyAll();
    }

    public synchronized void entra() {
        while (lleno) {
            try {
                wait();
            } catch (InterruptedException e) {
                System.out.println("interrupción del hilo....");
            }
        }
        cuenta += 1;
        System.out.println("Numero de personas: " + cuenta);
        lleno = true;
        notifyAll();
    }

}
