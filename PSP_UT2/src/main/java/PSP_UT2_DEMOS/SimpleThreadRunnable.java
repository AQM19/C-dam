package PSP_UT2_DEMOS;

public class SimpleThreadRunnable implements Runnable{
    String nombre;

    public SimpleThreadRunnable(String nombre){
        this.nombre = nombre;
    }

    public void run(){
        for(int i = 0; i < 10; i++){
            System.out.println(i + " -> " + this.nombre);
        }
        System.out.println("El hilo " + this.nombre + " ha finalizado.");
    }
}
