package Hoja_6.Ex22;

import java.io.*;

public class Fichero {
    private File f;

    public Fichero(String f){
        this.f = new File(f);
    }

    public void leer(){
        FileReader fileReader = null;
        try {
            fileReader = new FileReader(f);
            BufferedReader br = new BufferedReader(fileReader);
            String linea;
            System.out.println("Leyendo: ***********************");
            while ((linea = br.readLine()) != null) {
                System.out.println(Thread.currentThread().getName()+": "+linea);
            }
        } catch (FileNotFoundException e) {
            throw new RuntimeException(e);
        } catch (IOException e) {
            throw new RuntimeException(e);
        }
    }

    public void escribir(){
        try{
            BufferedWriter bw = new BufferedWriter(new FileWriter(f));
            bw.write(Thread.currentThread().getName()+": escribe una línea.");
            bw.newLine();
            System.out.println("Fin de la grabación.");
            bw.close();
        } catch (IOException e) {
            throw new RuntimeException(e);
        }
    }
}
