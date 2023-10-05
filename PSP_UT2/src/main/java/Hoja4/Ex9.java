package Hoja4;

public class Ex9 {
    public static void main(String[] args) {

        args = new String[]{"6"};

        Count count = new Count();

        for(int i = 0; i < Integer.parseInt(args[0]); i++){
            MiHilo h = new MiHilo(count);
            h.start();
        }

    }
}
