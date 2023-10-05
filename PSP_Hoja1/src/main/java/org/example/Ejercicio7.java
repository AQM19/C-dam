package org.example;

import java.io.IOException;
import java.util.concurrent.TimeUnit;

public class Ejercicio7 {
    public static void main(String[] args) throws IOException, InterruptedException {
        Process process = new ProcessBuilder("Notepad.exe").start();
        //process.waitFor();
        process.waitFor(3, TimeUnit.SECONDS);
        process.destroy();
        int value = process.exitValue();
        if(value != 0) {
            System.out.println("Error en la ejecución.");
        }
        System.out.println("Valor de salida: " + value);
    }
}
