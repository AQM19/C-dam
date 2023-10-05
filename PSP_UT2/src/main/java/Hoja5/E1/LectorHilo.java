package Hoja5.E1;

public class LectorHilo extends Thread{

    BuzonCorreo bc;

    public LectorHilo(String p_nombre, BuzonCorreo bc) {
        super(p_nombre);
        this.bc = bc;
    }

    public void run() {
        for(int i = 0; i < 20; i++) {
            bc.lee();
            try {
                sleep((int)(Math.random()*1000));
            } catch (InterruptedException e) {
                System.out.println("Interrupción del hilo...");
            }
        }
        System.out.println(this.getName() + " ha terminado de leer.");
    }
}
