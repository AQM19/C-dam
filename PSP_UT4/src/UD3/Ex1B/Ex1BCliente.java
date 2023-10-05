package UD3.Ex1B;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.net.Socket;
import java.util.Scanner;

public class Ex1BCliente {
    public static void main(String[] args) {
        String HOST = "localhost";
        int Puerto = 1500;
        Scanner teclado = new Scanner(System.in);

        try {
            // Me conecto al puerto
            Socket skCliente = new Socket(HOST, Puerto);

            // Creo los flujos de entrada y salida
            DataInputStream flujo_entrada = new DataInputStream(skCliente.getInputStream());
            DataOutputStream flujo_salida = new DataOutputStream(skCliente.getOutputStream());
            System.out.println("Introduce texto a enviar:");
            String texto = teclado.nextLine();
            flujo_salida.writeUTF(texto);
            while (!texto.equalsIgnoreCase("fin")) {

                System.out.println(flujo_entrada.readUTF());
                System.out.println("Introduce texto a enviar:");
                texto = teclado.nextLine();
                flujo_salida.writeUTF(texto);

            }

            // Se cierra la conexión
            skCliente.close();

        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }
}
