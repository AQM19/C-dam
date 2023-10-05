package org.example;

import java.io.IOException;
import java.util.concurrent.TimeUnit;

public class Ejercicio9 {
    public static void main(String[] args) {
        Process process;
        try{
             process = new ProcessBuilder("calc.exe").start();
            Thread.sleep(10000);
            System.out.println("Valor de salida: " + process.exitValue());
            int value = process.exitValue();
        }catch (IOException | InterruptedException | IllegalThreadStateException ioe){
            System.out.println(ioe.getMessage());
        }
    }
}
