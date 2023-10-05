package Hoja3;

public class TicTac extends Thread{

    private String palabra;

    public TicTac(String palabra){
        super();
        this.palabra = palabra;
    }

    public void run() {
        while(true){
            System.out.println(getPalabra());

            try {
                sleep(1000);
            } catch (InterruptedException e) {}
        }
    }

    public String getPalabra() {
        return palabra;
    }
}
