package org.example;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Child {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        String a;
        String b;

        try {
            a = br.readLine();
            b = br.readLine();

            System.out.println("La suma de " + a + " + " + b + " = " + (Integer.parseInt(a) + Integer.parseInt(b)));

            br.close();

        }catch (Exception e) {

        }
    }
}