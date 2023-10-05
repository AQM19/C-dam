package org.example;

import java.io.IOException;

public class Ejercicio2 {
    public static void main(String[] args) throws IOException, InterruptedException {
        ProcessBuilder pb = new ProcessBuilder();
        pb.command("Notepad.exe");
        Process process = pb.start();
        process.waitFor();
    }
}
