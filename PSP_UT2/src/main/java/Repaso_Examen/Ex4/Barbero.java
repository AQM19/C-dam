package Repaso_Examen.Ex4;

public class Barbero extends Thread{

    Barberia barberia;

    public Barbero(String nombre, Barberia barberia) {
        super(nombre);
        this.barberia = barberia;
    }

    public void run() {

        for(int i = 0; i < 3; i++){
            barberia.cortarPelo(getName());
            try {
                sleep(1000);
            } catch (InterruptedException e) {
                System.out.println("Interrupcion del hilo...");
            }
        }
    }
}
