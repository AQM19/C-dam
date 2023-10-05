package org.example;

import java.io.IOException;
import java.util.concurrent.TimeUnit;

public class Ejercicio12 {
    public static void main(String[] args) throws IOException {
        try{
            Process process = new ProcessBuilder("notepad.exe").start();
            process.destroy();
            Thread.sleep(10000);
            System.out.println("Valor de salida: " + process.exitValue());
        }catch (IOException | InterruptedException ioe) {
            System.out.println(ioe.getMessage());
        }
    }
}
