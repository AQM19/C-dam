package Repaso_Examen.Ex2;

import java.io.*;

public class Main {
    public static void main(String[] args) {

        String[] comando1 = {"java", "-jar", "LadoAleatorio_Aaron.jar"};
        String[] comando2 = {"java", "-jar", "AreaCuadrado_Nombre.jar"};


        try {
            Process p1 = Runtime.getRuntime().exec(comando1);
            InputStream in = p1.getInputStream();
            String line = String.valueOf(in.read());
            in.close();

            System.out.println("Lado: " + line);

            Process p2 = Runtime.getRuntime().exec(comando2);
            OutputStream os = p2.getOutputStream();
            os.write(line.getBytes());
            os.flush();
            os.close();

            BufferedReader br = p2.inputReader();
            line = br.readLine();

            System.out.println("Cuadrado: " + line);


        } catch (IOException e) {
            throw new RuntimeException(e);
        }

    }
}
