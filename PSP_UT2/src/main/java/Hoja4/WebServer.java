package Hoja4;

public class WebServer extends Thread{

    protected int cuenta = 0;


    public synchronized int incCuenta(int valor){
        this.cuenta = this.cuenta + valor;
        try{
            Thread.sleep((long)(Math.random()*1000));
        }catch (InterruptedException ex) {
            System.out.println("Interrupción del hilo.");
        }

        return this.cuenta;
    }
}
