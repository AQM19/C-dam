package Hoja4;

public class Ex14 {
    public static void main(String[] args) {

        CuentaBancaria cuenta = new CuentaBancaria();

        Titular t1 = new Titular("Titular1", cuenta);
        Titular t2 = new Titular("Titular2", cuenta);

        t1.start();
        t2.start();

        try {
            t1.join();
            t2.join();
        } catch (InterruptedException e){
            System.out.println(e.getMessage());
        }

        System.out.println("Finalizado.");
    }
}
