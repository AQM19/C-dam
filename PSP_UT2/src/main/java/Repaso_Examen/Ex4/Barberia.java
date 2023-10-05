package Repaso_Examen.Ex4;

public class Barberia {

    private String mensaje = "";
    private boolean cortando = true;

    public synchronized void cortarPelo(String valor){
        while(!cortando) {
            try {
                wait();
            } catch (InterruptedException e) {
                System.out.println("Interrupción del hilo...");
            }
        }

        mensaje = valor;
        System.out.println("Esperando a cortar el pelo: " + mensaje);
        cortando = false;

        notifyAll();
    }

    public synchronized void siguienteCliente(String valor){
        while (cortando) {
            try {
                wait();
            } catch (InterruptedException e) {
                System.out.println("Interrupción del hilo...");
            }
        }

        mensaje = valor;
        System.out.println("Cortando el pelo a " + mensaje);
        cortando = true;
        notifyAll();
    }

}
