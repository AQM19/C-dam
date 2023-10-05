package org.example;

import java.io.File;
import java.io.IOException;

public class Ejercicio19 {
    public static void main(String[] args) {
        String arg = "Bienvenido";
        ProcessBuilder builder = new ProcessBuilder("ejercicio19.bat", arg);
        builder.redirectOutput(new File("output.txt"));
        String text = "text";
        builder.environment().put(text, "mundo");

        try {
            Process process = builder.start();
            int value = process.waitFor();

            System.out.println("Valor de salida: " + value);
        }catch (IOException | InterruptedException e) {
            System.out.println(e.getMessage());
        }
    }
}