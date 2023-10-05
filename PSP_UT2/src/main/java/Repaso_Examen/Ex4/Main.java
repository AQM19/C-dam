package Repaso_Examen.Ex4;

public class Main {
    public static void main(String[] args) {

        Barberia barberia = new Barberia();

        Barbero barbero = new Barbero("Barbero 1", barberia);

        Cliente c1 = new Cliente("Cliente 1", barberia);
        Cliente c2 = new Cliente("Cliente 2", barberia);
        Cliente c3 = new Cliente("Cliente 3", barberia);

        barbero.start();

        c1.start();
        c2.start();
        c3.start();
    }
}
