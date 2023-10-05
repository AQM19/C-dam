package Hoja3;

public class Ex5 {
    public static void main(String[] args) {

        Hilo h = null;

        for(int i = 0; i < 5; i++){
            h = new Hilo("Hilo" + (i+1));
            h.start();
        }

    }
}
