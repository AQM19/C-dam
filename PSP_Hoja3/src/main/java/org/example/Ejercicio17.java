package org.example;

import java.io.BufferedReader;
import java.io.IOException;
import java.util.Scanner;

public class Ejercicio17 {
    public static void main(String[] args) {
        String[] commandLine = {"cmd", "/c", "aleatorio.exe"};
        String read;
        try {
            do {
                Process process = new ProcessBuilder(commandLine).start();
                BufferedReader br = process.inputReader();

                System.out.println("Número aleatorio: " + br.readLine());
                br.close();

                System.out.println();
                System.out.println("\nIntroduce una letra para continuar (escribiendo 'fin' se finalizará el proceso.)");
                read = new Scanner(System.in).next();
                process.destroy();
            }while (!read.equalsIgnoreCase("fin"));

        }catch (IOException e) {
            System.out.println(e.getMessage());
        }
    }
}
