package Hoja_6.Ex19;

import java.io.*;

public class Fichero {

    private File f = new File("historia.txt");

    public void escribir(String palabra){
        try {
            BufferedWriter fichero = new BufferedWriter(new FileWriter(f, true));
            fichero.write(palabra);
            fichero.newLine();
            fichero.close();
        } catch (FileNotFoundException ex){
            System.out.println("No se encuentra el fichero.");
        } catch (IOException e) {
            System.out.println("Error de E/S");
        }
    }

    public void leer() throws IOException {
        BufferedReader fichero = new BufferedReader(new FileReader(f));
        String frase;
        while ((frase = fichero.readLine()) != null){
            System.out.println(frase);
        }
    }

}
