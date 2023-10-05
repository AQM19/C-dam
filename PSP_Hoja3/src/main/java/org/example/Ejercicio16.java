package org.example;

import java.io.BufferedReader;
import java.io.IOException;

public class Ejercicio16 {
    public static void main(String[] args) {
        ProcessBuilder processBuilder = new ProcessBuilder("ipconfig");
        try {
            Process process = processBuilder.start();
            BufferedReader br = process.inputReader();

            String line;

            while ((line = br.readLine()) != null) {
                if(line.contains("IPv4")) {
                    System.out.println(line);
                    break;
                }
            }
            br.close();
        } catch (IOException e) {
            System.out.println(e.getMessage());
        }
    }
}
