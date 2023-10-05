package org.example;

import java.io.IOException;

public class Ejercicio10 {
    public static void main(String[] args) {
        int value;
        try {
            Process process = new ProcessBuilder("Notepad.exe").start();
            process.destroy();
            value = process.exitValue();
            System.out.println("Valor de salida: " + value);
        }catch (IOException ioe){
            System.out.println(ioe.getMessage());
        }
    }
}
