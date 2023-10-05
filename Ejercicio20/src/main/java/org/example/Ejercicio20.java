package org.example;

import java.io.*;

public class Ejercicio20 {
    public static void main(String[] args) {
        String[] command = {"java", "-jar", "GenerateRandom.jar", "|", "Order.jar"};
        ProcessBuilder builder = new ProcessBuilder(command).redirectOutput(new File("Order.jar"));
        try {
            Process process = builder.start();
            InputStream in = process.getInputStream();
            BufferedReader br = new BufferedReader(new InputStreamReader(in));
            String n;
            int i = 0;

            while ((n = br.readLine()) != null) {
                System.out.println(n);
                i++;
            }
            System.out.println("num " +i);

        }catch (IOException e) {
            System.out.println(e.getMessage());
        }
    }
}