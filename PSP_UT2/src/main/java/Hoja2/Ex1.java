package Hoja2;

public class Ex1 {
    public static void main(String[] args) {
        SimpleThread t1 = new SimpleThread("Pares");
        SimpleThread t2 = new SimpleThread("Impares");
        SimpleThread t3 = new SimpleThread("Dos/Tres");

        t1.start(1);
        t2.start(2);
        t3.start(3);
    }
}
