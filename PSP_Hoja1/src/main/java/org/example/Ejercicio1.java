package org.example;

import java.io.IOException;

public class Ejercicio1 {
    public static void main(String[] args) throws IOException, InterruptedException {
        ProcessBuilder pb = new ProcessBuilder("notepad.exe");
        Process process = pb.start();
        process.waitFor();
    }
}