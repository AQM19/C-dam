package org.example;

import java.io.BufferedReader;
import java.io.IOException;

public class Ejercicio15 {
    public static void main(String[] args) {
        ProcessBuilder processBuilder = new ProcessBuilder("cmd", "/c", "echo", "Hola mundo");
        try {
            Process process = processBuilder.start();
            BufferedReader br = process.inputReader();
            System.out.println(br.readLine().replace("\"", ""));
            br.close();
        } catch (IOException e) {
            System.out.println(e.getMessage());
        }
    }
}
