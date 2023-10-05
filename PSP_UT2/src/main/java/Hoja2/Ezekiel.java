package Hoja2;

import java.util.Scanner;

public class Ezekiel extends Thread{

    private boolean bandera = true;
    int num, numUsuario;

    public Ezekiel(){}

    public void run(){
        num = (int) (Math.random() * 10)+1;
        System.out.println(num);
        Scanner scanner = new Scanner(System.in);

        while(isBandera()) {
            System.out.println("Dame un numero:");
            numUsuario = scanner.nextInt();


            if(num == numUsuario) {
                System.out.println("GANASTE");
                setBandera(false);
            }
        }
    }

    public boolean isBandera(){
        return bandera;
    }

    public void setBandera(boolean bandera) {
        this.bandera = bandera;
    }
}
