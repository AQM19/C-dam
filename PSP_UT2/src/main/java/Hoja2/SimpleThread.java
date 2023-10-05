package Hoja2;

import java.io.*;

public class SimpleThread extends Thread{

    String nombre;

    public SimpleThread(String pares) {
        this.nombre = nombre;
    }

    public void run(int opt){
        int num = 0;

        switch (opt){
            case 1 -> {
                for(int i = 1; i <= 1000; i++){
                    if(i % 2 == 0) num += i;
                }
            }
            case 2 -> {
                for(int i = 1; i <= 1000; i++) {
                    if(i % 2 != 0) num += i;
                }
            }
            case 3 -> {
                for(int i = 1; i <= 1000; i++) {
                    if(String.valueOf(i).matches(".*[2-3]")) num += i;
                }
            }
        }

        System.out.println(num);
    }

    public void start(int i) {
        this.run(i);
    }

    public void count(File f) throws IOException, InterruptedException {
        BufferedReader br = new BufferedReader(new FileReader(f));
        String linea;
        int count = 0;

        while ((linea = br.readLine()) != null) {
            ++count;
            Thread.sleep(1000);
        }

        System.out.println("El archivo " + f.getName() + " tiene " + count + " líneas.");

    }
}
