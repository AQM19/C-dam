package Hoja5.E2;

public class Entrada extends Thread{

    Cuenta c;

    public Entrada(String n, Cuenta c){
        super(n);
        this.c = c;
    }

    public void run() {
        int rng = (int)(Math.random()*(15-1)+1);

        for(int i = 0; i < rng; i++) {
            c.entra();
        }

        System.out.println("Han terminado de entrar.");
    }
}
