package org.example;

import java.io.IOException;

public class Ejercicio11 {
    public static void main(String[] args) {
        try{
            Process process = new ProcessBuilder("Notepad.exe").start();
            Thread.sleep(300);
            process.destroy();
            System.out.println("Valor de salida: " + process.exitValue());
        } catch (IOException | InterruptedException e) {
            System.out.println(e.getMessage());
        }
    }
}
