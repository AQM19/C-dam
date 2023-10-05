package org.example;

import java.io.IOException;

public class Ejercicio4 {
    public static void main(String[] args) throws InterruptedException, IOException {
        ProcessBuilder pb = new ProcessBuilder(args);
        Process process = pb.start();
        process.waitFor();
    }
}
