package org.example;

import java.io.IOException;

public class Ejercicio5 {
    public static void main(String[] args) throws IOException, InterruptedException {
        Process process = new ProcessBuilder("Notepad.exe").start();
        for (int i = 0; i < 10; i++) {
            System.out.print((int) (Math.random()*9) + " ");
        }
        process.waitFor();
    }
}
