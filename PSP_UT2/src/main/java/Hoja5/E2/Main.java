package Hoja5.E2;

public class Main {
    public static void main(String[] args) {
        Cuenta c = new Cuenta();

        Entrada e = new Entrada("Entrada", c);
        Salida s = new Salida("Salida", c);

        e.start();
        s.start();
    }
}
