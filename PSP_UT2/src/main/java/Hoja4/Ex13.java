package Hoja4;

public class Ex13 {
    public static void main(String[] args) {

        Contador cont = new Contador();

        HiloIncrementa hi = new HiloIncrementa("HiloIncrementa", cont);
        HiloDecrementa hd = new HiloDecrementa("HiloDecrementa", cont);

        hi.start();
        hd.start();
    }
}
