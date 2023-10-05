package org.example;

import java.io.*;

public class Ejercicio13_14 {
    public static void main(String[] args) throws IOException {
        ProcessBuilder processBuilder = new ProcessBuilder("cmd", "/c", "dir");
        //File out = new File("out.txt");
        //File err = new File("err.txt");

        Process process = processBuilder.start();
        //InputStream output = process.getInputStream();
        //InputStream error = process.getErrorStream();

        BufferedReader br = process.inputReader();
        BufferedReader err = process.errorReader();

        String line;
        while ((line = br.readLine()) != null) {
            System.out.println(line);
        }

        while ((line = err.readLine()) != null) {
            System.out.println(line);
        }
        /*
        int data;

        while((data = output.read()) != -1) {
            System.out.print((char) data);
        }

        while((data = error.read()) != -1) {
            System.out.print((char) data);
        }
        */
    }
}