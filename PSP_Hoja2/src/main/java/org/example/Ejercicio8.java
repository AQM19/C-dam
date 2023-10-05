package org.example;

import java.io.IOException;

public class Ejercicio8 {
    public static void main(String[] args) {
        try {
            Process process = new ProcessBuilder("Notepad.exe").start();
            process.waitFor();
            System.out.println("Valor de salida: " + process.exitValue());
        } catch (IllegalThreadStateException | IOException e) {
            System.out.println(e.getMessage());
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }
    }
}