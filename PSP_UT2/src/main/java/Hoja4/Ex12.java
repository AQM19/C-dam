package Hoja4;

public class Ex12 {

    public static void main(String[] args) {

        CuentaBancaria cuenta = new CuentaBancaria();

        Titular t1 = new Titular("Titular1", cuenta);
        Titular t2 = new Titular("Titular2", cuenta);
        Titular t3 = new Titular("Titular3", cuenta);
        Titular t4 = new Titular("Titular4", cuenta);
        Titular t5 = new Titular("Titular5", cuenta);

        t1.start();
        t2.start();
        t3.start();
        t4.start();
        t5.start();

        try {
            t1.join();
            t2.join();
            t3.join();
            t4.join();
            t5.join();
        } catch (InterruptedException ex) {
            System.out.println(ex.getMessage());
        }

        System.out.println("Finalización.");
    }
}
