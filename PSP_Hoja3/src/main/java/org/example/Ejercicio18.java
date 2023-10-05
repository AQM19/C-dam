package org.example;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Scanner;

public class Ejercicio18 {
    public static void main(String[] args) {
        ProcessBuilder processBuilder = new ProcessBuilder("convMayus.exe");
        try {
            Process process = processBuilder.start();
            BufferedReader br = process.inputReader();
            BufferedWriter bw = process.outputWriter();
            System.out.println("Introduce un texto");
            String text = new Scanner(System.in).nextLine();
            bw.write(text);
            bw.flush();
            bw.close();

            String result;

            System.out.print("El texto resultado es: ");
            while((result = br.readLine()) != null) {
                System.out.print(result);
            }

            br.close();
        } catch (IOException e) {
            System.out.println(e.getMessage());
        }
    }
}
