package Repaso_Examen.Ex4;

public class Cliente extends Thread{

    Barberia barberia;

    public Cliente(String nombre, Barberia barberia) {
        super(nombre);
        this.barberia = barberia;
    }

    public void run() {
        barberia.siguienteCliente(getName());

        try{
            sleep(1000);
        } catch (InterruptedException e) {
            System.out.println("Interrupción del hilo...");
        }

        System.out.println(getName() + ": Ya me cortaron el pelo.");
    }

}
