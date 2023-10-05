package org.example;

import java.io.*;
import java.util.Arrays;

public class Father {
    public static void main(String[] args) {
        try {
            Process process = new ProcessBuilder(args).start();
            InputStream in = process.getInputStream();
            InputStreamReader inr = new InputStreamReader(in);
            BufferedReader br = new BufferedReader(inr);
            String line;
            System.out.println("Salida del proceso:" + Arrays.toString(args)
                    .replace('[', ' ')
                    .replace(']', ' ')
                    .replaceAll(",", ""));
            while((line = br.readLine()) != null) {
                System.out.println(line);
            }
        }catch (IOException ioe) {
            System.out.println(ioe.getMessage());
        }
    }
}