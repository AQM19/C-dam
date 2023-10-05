package Hoja4;

public class Ex11 {
    public static void main(String[] args) {

        WebServer wb = new WebServer();

        WebClient h1 = new WebClient("Hilo1", wb);
        WebClient h2 = new WebClient("Hilo2", wb);
        WebClient h3 = new WebClient("Hilo3", wb);
        WebClient h4 = new WebClient("Hilo4", wb);
        WebClient h5 = new WebClient("Hilo5", wb);

        h1.start();
        h2.start();
        h3.start();
        h4.start();
        h5.start();

        try{
            h1.join();
            h2.join();
            h3.join();
            h4.join();
            h5.join();
        } catch (InterruptedException ex) {
            System.out.println(ex.getMessage());
        }

        System.out.println("Fin del programa.");

    }
}
