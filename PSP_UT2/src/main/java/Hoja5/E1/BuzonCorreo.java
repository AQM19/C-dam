package Hoja5.E1;

public class BuzonCorreo {

    private String mensaje = "";
    private boolean lleno = false;

    public synchronized String lee(){
        while (!lleno) {
            try {
                wait();
            } catch (InterruptedException e) {
                System.out.println("Interrupción del hilo...");
            }
        }
        lleno = false;
        System.out.println("Consumidor: " + mensaje);
        notifyAll();

        return mensaje;
    }

    public synchronized void almacena(String valor) {
        while(lleno) {
            try {
                wait();
            } catch (InterruptedException e) {
                System.out.println("Interrupción del hilo...");
            }
        }
        mensaje = valor;
        System.out.println("Escritor: " + mensaje);
        lleno = true;
        notifyAll();
    }

}
