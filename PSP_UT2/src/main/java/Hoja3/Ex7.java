package Hoja3;

public class Ex7 {
    public static void main(String[] args) throws InterruptedException {
        HiloEx3 h = new HiloEx3();
        h.start();
        Thread.sleep(10000);
        h.pararHilo();
    }
}
