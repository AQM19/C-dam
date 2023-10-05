package Hoja4;

public class HiloDecrementa extends Thread{

    public Contador contador;

    public HiloDecrementa(String n, Contador c){
        setName(n);
        contador = c;
    }

    public void run() {
        synchronized (contador) {
            for(int i = 0; i < 10; i++) {
                contador.decValor();
                System.out.println(getName() + " pone el contador " + contador.devValor());
                try{
                    sleep(1000);
                } catch (InterruptedException e) {
                    throw new RuntimeException(e);
                }
            }
        }
    }

}
