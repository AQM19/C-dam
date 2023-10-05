package org.example;

import java.io.IOException;

public class Ejercicio3 {
    public static void main(String[] args) throws InterruptedException, IOException {
        ProcessBuilder pb = new ProcessBuilder("Notepad.exe", "prueba.txt");
        Process process = pb.start();
        process.waitFor();
    }
}
