package Hoja5.E1;

public class Main {
    public static void main(String[] args) {
        BuzonCorreo bc = new BuzonCorreo();

        EscritorHilo e1 = new EscritorHilo("Escritor 1", bc);
        EscritorHilo e2 = new EscritorHilo("Escritor 2", bc);
        LectorHilo l1 = new LectorHilo("Lector 1", bc);
        LectorHilo l2 = new LectorHilo("Lector 2", bc);

        e1.start();
        e2.start();
        l1.start();
        l2.start();
    }
}
