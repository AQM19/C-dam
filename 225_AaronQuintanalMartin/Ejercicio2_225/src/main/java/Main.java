import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        String string = new Scanner(System.in).nextLine();
        string = "El arzobispo de Parangaricutimiricuaro se quiere desarzobispoparangaricutimiricuarizar, el desarzobispoparangaricutimiricuarizador de lo desarzobispoparangaricutimiricuarice buen desarzobispoparangaricutimiricuarizador sera.";
        // frase unicamente puesta por conveniencia, no es necesaria ni se pide, pero es para ir más rápido.
        Frase frase = new Frase(string);

        CuentaVocal a = new CuentaVocal("a", frase);
        CuentaVocal e = new CuentaVocal("e", frase);
        CuentaVocal i = new CuentaVocal("i", frase);
        CuentaVocal o = new CuentaVocal("o", frase);
        CuentaVocal u = new CuentaVocal("u", frase);

        a.start();
        e.start();
        i.start();
        o.start();
        u.start();

        try {
            a.join();
            e.join();
            i.join();
            o.join();
            u.join();
        } catch (InterruptedException ex) {
            System.out.println("Interrupción del hilo...");
        }

    }
}
