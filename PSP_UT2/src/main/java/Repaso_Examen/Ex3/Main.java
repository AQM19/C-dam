package Repaso_Examen.Ex3;

import java.io.*;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        Process process2;
        OutputStream os = null;
        InputStream in = null;
        String num;
        String line = "";

        try {
            System.out.println("Introduce una frase:");
            num = new Scanner(System.in).nextLine();

            while(!num.equalsIgnoreCase("fin")) {
                process2 = Runtime.getRuntime().exec("java -jar Ejercicio3_Padre.jar");
                os = process2.getOutputStream();
                os.write(num.getBytes());
                os.flush();
                os.close();

                in = process2.getInputStream();
                BufferedReader br = new BufferedReader(new InputStreamReader(in));

                while ((line = br.readLine()) != null){
                    System.out.println(line);
                }

                in.close();
                System.out.println("Introduce una frase:");
                num = new Scanner(System.in).nextLine();
            }

        } catch (IOException e) {
            System.out.println(e.getMessage());
        }

    }
}
